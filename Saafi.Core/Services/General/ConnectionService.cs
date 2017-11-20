using Saafi.Core.Contracts.Services;
using Plugin.Connectivity;

namespace Saafi.Core.Services.General
{
    public class ConnectionService : IConnectionService
    {
        public bool CheckOnline()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
