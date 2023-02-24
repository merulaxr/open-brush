// Copyright 2020 The Tilt Brush Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

Shader "Brush/Special/Intersection" {

  Properties { }

  SubShader{

    // -------------------------------------------------------------------------------------- //
    // Intersection Test Pass
    // -------------------------------------------------------------------------------------- //

    Pass{
      Tags{ "Queue" = "Opaque" "IgnoreProjector" = "True" "RenderType" = "Opaque" "DisableBatching" = "True" }
      Lighting Off
      Cull Off
      Blend Off

      CGPROGRAM

#pragma vertex vert
#pragma fragment frag
#pragma geometry geom

#include "UnityCG.cginc" 
#include "Assets/Shaders/Include/Brush.cginc"
#include "Assets/Shaders/Include/PackInt.cginc"

      uniform float3 vSphereCenter;
      uniform float fSphereRad;

      struct appdata_t {
        float4 vertex : POSITION;
        UNITY_VERTEX_INPUT_INSTANCE_ID
      };

      struct v2g {
        float4 vertex : POSITION;
        float4 worldPos : TEXCOORD0;
        half4 color : COLOR;
        UNITY_VERTEX_INPUT_INSTANCE_ID
        UNITY_VERTEX_OUTPUT_STEREO
      };

      struct g2f {
        float4 vertex : POSITION;
        float4 worldPos : TEXCOORD0;
        half4 color : COLOR;
        UNITY_VERTEX_OUTPUT_STEREO
      };

      v2g vert(appdata_t v)
      {
        v2g o;

        UNITY_SETUP_INSTANCE_ID(v); //Insert
        UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o); //Insert 
        
        o.vertex = UnityObjectToClipPos(v.vertex);
        o.worldPos = mul(unity_ObjectToWorld, v.vertex);
        o.color = half4(0, 0, 0, 0);

        return o;
      }

      bool SphereInTriangle(float3 A, float3 B, float3 C, float3 P, float r) {
        // Separating Axis Test as proposed by Christer Ericson
        // http://realtimecollisiondetection.net/blog/?p=103
        //
        // Performing 7 axis tests:
        //  1) Normal to the triangle plane
        //  2) Perpendicular to AB through P
        //  3) Perpendicular to BC through P
        //  4) Perpendicular to CA through P
        //  5) Through A and P
        //  6) Through B and P
        //  7) Through C and P
        //
        A = A - P;
        B = B - P;
        C = C - P;
        float rr = r * r;
        float3 V = cross(B - A, C - A);
        float d = dot(A, V);
        float e = dot(V, V);
        bool sep1 = d * d > rr * e;

        float aa = dot(A, A);
        float ab = dot(A, B);
        float ac = dot(A, C);
        float bb = dot(B, B);
        float bc = dot(B, C);
        float cc = dot(C, C);
        bool sep2 = (aa > rr) & (ab > aa) & (ac > aa);
        bool sep3 = (bb > rr) & (ab > bb) & (bc > bb);
        bool sep4 = (cc > rr) & (ac > cc) & (bc > cc);

        float3 AB = B - A;
        float3 BC = C - B;
        float3 CA = A - C;
        float d1 = ab - aa;
        float d2 = bc - bb;
        float d3 = ac - cc;
        float e1 = dot(AB, AB);
        float e2 = dot(BC, BC);
        float e3 = dot(CA, CA);
        float3 Q1 = A * e1 - d1 * AB;
        float3 Q2 = B * e2 - d2 * BC;
        float3 Q3 = C * e3 - d3 * CA;
        float3 QC = C * e1 - Q1;
        float3 QA = A * e2 - Q2;
        float3 QB = B * e3 - Q3;
        bool sep5 = (dot(Q1, Q1) > rr * e1 * e1) && (dot(Q1, QC) > 0);
        bool sep6 = (dot(Q2, Q2) > rr * e2 * e2) && (dot(Q2, QA) > 0);
        bool sep7 = (dot(Q3, Q3) > rr * e3 * e3) && (dot(Q3, QB) > 0);

        return !(sep1 || sep2 || sep3 || sep4 || sep5 || sep6 || sep7);
      }

      bool SegmentSphereIntersection(float3 vSegA, float3 vSegB,
                       float3 vSphereCenter, float fSphereRad) {
        // Check segment start to sphere
        float3 vStartToSphere = vSphereCenter - vSegA;
        if (length(vStartToSphere) < fSphereRad) {
          return true;
        }

        // Check to see if our ray is pointing in the right direction
        float3 vSegment = vSegB - vSegA;
        float3 segmentRay = normalize(vSegment);
        float fDistToCenterProj = dot(vStartToSphere, segmentRay);

        if (fDistToCenterProj < 0.0f) {
          return false;
        }

        // If the distance to our projection is within the segment bounds, we're on the
        // right track
        if (fDistToCenterProj > length(vSegment)) {
          return false;
        }

        // See if this projected point is within the sphere
        float3 vProjectedPoint = vSegA + segmentRay * fDistToCenterProj;
        float3 vToProjectedPoint = vProjectedPoint - vSphereCenter;

        return length(vToProjectedPoint) <= fSphereRad;
      }

      [maxvertexcount(3)]
      void geom(triangle g2f input[3],
            inout TriangleStream<g2f> OutputStream,
            uint id : SV_PrimitiveID)
      {
        g2f o;

        // This method also handles the case of large triangles.
        // bool hit = any(o1.worldPos != o2.worldPos)
        //   && any(o1.worldPos != o3.worldPos)
        //   && any(o3.worldPos != o2.worldPos)
        //   && SphereInTriangle(o1.worldPos, o2.worldPos, o3.worldPos, vSphereCenter, fSphereRad);
        
        // // Discard the triangle if there is no hit.
        // if (!hit) {
        //   return;
        // }

        for (int i = 0; i < 3; i++)
        {
          o.worldPos = input[i].worldPos;
          o.vertex = input[i].vertex;
          o.color = PackUint16x2ToRgba8(uint2(_BatchID, id));

          UNITY_TRANSFER_VERTEX_OUTPUT_STEREO(input[i], o);
          
          // Note, world space pos has not been inflated.
          OutputStream.Append(o);
        }
      }

      half4 frag(g2f i) : COLOR
      {
        return i.color;
      }

        ENDCG
    }
  }

  Fallback "Unlit/Diffuse"
}
