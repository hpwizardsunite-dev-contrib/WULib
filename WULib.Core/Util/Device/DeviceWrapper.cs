using System.Net;
using static WUProtos.Networking.Requests.Messages.CreateOrUpdatePlayerMessage.Types;

namespace WULib.Core.Util.Device
{
    public class DeviceWrapper
    {
        public string UserAgent { get; set; }
        public IWebProxy Proxy { get; set; }
        public ClientDeviceInfo DeviceInfo { get; set; }
    }
}
