// Copyright 2022 The Open Brush Authors
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

namespace TiltBrush.Multiplayer
{
    [OrderAfter(typeof(NetworkTransform))]
    public class NetworkRig : NetworkBehaviour
    {
        public NetworkTransform playArea;
        public NetworkTransform head;
        public NetworkTransform leftHand;
        public NetworkTransform rightHand;

        private LocalRig localRig;
        public override void Spawned()
        {
            base.Spawned();
            if (Object.HasStateAuthority)
            {
                localRig = FindObjectOfType<LocalRig>();
                if (localRig == null)
                {
                    Debug.LogError("Could not find local player rig!");
                }
            }
        }

        public override void FixedUpdateNetwork()
        {
            base.FixedUpdateNetwork();

            // update the rig at each network tick
            if (GetInput<RigData>(out var input))
            {
                ApplyInputToRigParts(input);
            }
        }

        protected virtual void ApplyInputToRigParts(RigData input)
        {
            playArea.transform.position = input.playAreaPosition;
            playArea.transform.rotation = input.playAreaRotation;
            leftHand.transform.position = input.leftHandPosition;
            leftHand.transform.rotation = input.leftHandRotation;
            rightHand.transform.position = input.rightHandPosition;
            rightHand.transform.rotation = input.rightHandRotation;
            head.transform.position = input.headPosition;
            head.transform.rotation = input.headRotation;
        }

        public override void Render()
        {
            base.Render();
            if (Object.HasStateAuthority)
            {
                // Extrapolate for local user :
                // we want to have the visual at the good position as soon as possible, so we force the visuals to follow the most fresh hardware positions
                // To update the visual object, and not the actual networked position, we move the interpolation targets
                playArea.InterpolationTarget.position = localRig.playArea.position;
                playArea.InterpolationTarget.rotation = localRig.playArea.rotation;
                leftHand.InterpolationTarget.position = localRig.leftHand.position;
                leftHand.InterpolationTarget.rotation = localRig.leftHand.rotation;
                rightHand.InterpolationTarget.position = localRig.rightHand.position;
                rightHand.InterpolationTarget.rotation = localRig.rightHand.rotation;
                head.InterpolationTarget.position = localRig.headTransform.position;
                head.InterpolationTarget.rotation = localRig.headTransform.rotation;
            }
        }
    }
}
