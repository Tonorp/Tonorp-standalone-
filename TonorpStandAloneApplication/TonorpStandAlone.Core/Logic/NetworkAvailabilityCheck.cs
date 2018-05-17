using System.Net.NetworkInformation;

namespace TonorpStandAlone.Core.Logic
{
    /// <summary>
    /// Checks whether Internet access is available or not
    /// </summary>
    public static class NetworkAvailabilityCheck
    {
        /// <summary>
        /// Returns whether Internet network is available or not
        /// </summary>
        /// <returns></returns>
        public static bool IsNetworkAvailable()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }
    }
}
