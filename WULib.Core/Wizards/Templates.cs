using WULib.Core.Net;
namespace WULib.Core.Wizards
{
    public class Templates
    {
        private readonly Session _session;

        public ulong AssetDigestTimestampMs { get; set; }
        public ulong ItemTemplatesTimestampMs { get; set; }

        internal Templates(Session session)
        {
            _session = session;
        }
    }
}