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

using System;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Fusion.Sockets;

namespace TiltBrush.Multiplayer
{
    [System.Serializable]
    public struct RigData : INetworkInput
    {
        public Vector3 playAreaPosition;
        public Quaternion playAreaRotation;
        public Vector3 headPosition;
        public Quaternion headRotation;
        public Vector3 leftHandPosition;
        public Quaternion leftHandRotation;
        public Vector3 rightHandPosition;
        public Quaternion rightHandRotation;
    }

    public class LocalRig : MonoBehaviour, INetworkRunnerCallbacks
    {
        public Transform playArea;
        public Transform headTransform;
        public Transform leftHand;
        public Transform rightHand;

        public NetworkRunner runner;

        protected virtual void Start()
        {
            if (runner == null)
            {
                Debug.LogWarning("Runner has to be set in the inspector to forward the input");
            }
            if (runner) runner.AddCallbacks(this);
        }

        #region INetworkRunnerCallbacks

        // Prepare the input, that will be read by NetworkRig in the FixedUpdateNetwork
        public virtual void OnInput(NetworkRunner runner, NetworkInput input)
        {
            RigData rigInput = PrepareRigInput();
            input.Set(rigInput);
        }

        protected virtual RigData PrepareRigInput()
        {
            rightHand = App.VrSdk.VrControls?.Brush.ControllerGeometry.PointerAttachPoint ?? playArea;
            leftHand = App.VrSdk.VrControls?.Wand.ControllerGeometry.PointerAttachPoint ?? playArea;

            RigData rigData = new RigData
            {
                playAreaPosition = playArea.position,
                playAreaRotation = playArea.rotation,
                leftHandPosition = leftHand.position,
                leftHandRotation = leftHand.rotation,
                rightHandPosition = rightHand.position,
                rightHandRotation = rightHand.rotation,
                headPosition = headTransform.position,
                headRotation = headTransform.rotation
            };
            return rigData;
        }

        #endregion

        #region INetworkRunnerCallbacks (unused)
        public void OnPlayerJoined(NetworkRunner runner, PlayerRef player) { }

        public void OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }


        public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }

        public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }

        public void OnConnectedToServer(NetworkRunner runner) { }

        public void OnDisconnectedFromServer(NetworkRunner runner) { }

        public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token) { }

        public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }

        public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message) { }

        public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

        public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data) { }

        public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken) { }

        public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data) { }

        public void OnSceneLoadDone(NetworkRunner runner) { }

        public void OnSceneLoadStart(NetworkRunner runner) { }
        #endregion
    }
}
