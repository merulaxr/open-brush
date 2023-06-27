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
using System.Threading.Tasks;
using UnityEngine;

using Fusion;
using Fusion.Sockets;

namespace TiltBrush.Multiplayer
{
    public class ConnectionManager : MonoBehaviour, INetworkRunnerCallbacks
    {
        public string roomName = "testRoom";

        public bool connectOnStart = false;

        // Photon things, abstract?
        public NetworkRunner runner;
        public NetworkObject userPrefab;

        private void Awake()
        {
            if (runner == null)
            {
                runner = GetComponent<NetworkRunner>();
            }

            if (runner == null)
            {
                runner = gameObject.AddComponent<NetworkRunner>();
            }

            // needed?
            runner.ProvideInput = true;
        }

        private async void Start()
        {
            if (connectOnStart)
            {
                await Connect();
            }
        }

        public async Task Connect()
        {
            var args = new StartGameArgs()
            {
                GameMode = GameMode.Shared,
                SessionName = roomName,
                SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>(),
                Scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex,
            };
            await runner.StartGame(args);
        }

        #region INetworkRunnerCallbacks
        public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
        {
            if (player == runner.LocalPlayer)
            {
                // Spawn the user prefab for the local user
                NetworkObject networkPlayerObject = runner.Spawn(userPrefab, position: transform.position, rotation: transform.rotation, player, (runner, obj) =>
                {
                });
            }
        }
        #endregion


        #region Unused INetworkRunnerCallbacks 
        public void OnPlayerLeft(NetworkRunner runner, PlayerRef player) { }
        public void OnConnectedToServer(NetworkRunner runner) { }
        public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason) { }
        public void OnDisconnectedFromServer(NetworkRunner runner) { }
        public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason) { }
        public void OnInput(NetworkRunner runner, NetworkInput input) { }
        public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input) { }
        public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token) { }
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

