﻿#pragma warning disable CS1998

using System.Threading.Tasks;
using PhotonWire.Server;
using PhotonWire.Server.ServerToServer;
using PhotonWire.Sample.ServerApp.GameServer.ReceiveServerHubs;

namespace PhotonWire.Sample.ServerApp.MasterServer.ServerHubs
{
    [Hub(31)]
    public class MasterTest2 : ServerHub
    {
        [Operation(53)]

        public virtual async Task<int> SumAsync(int x, int y)
        {
            // broadcast to other servers
            var ai = await GetReceiveServerHubProxy<TestReceive>().All.Invoke(h => h.TakoChop("nanone"));

            return x + y; // return result
        }
    }
}

#pragma warning restore CS1998