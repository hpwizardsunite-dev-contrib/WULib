using System;
using System.Linq;
using System.Threading.Tasks;
using WULib.Core.Util.Encryption.Legacy;
using WUProtos.Networking.Envelopes;

namespace WULib.Core.Util.Hash
{
    /// <summary>
    ///     This is the default <see cref="IHasher"/> used by WULib.Core.
    /// 
    ///     Android version: 0.8.0
    /// </summary>
    public class LegacyHasher : IHasher
    {
        public Version WizardsVersion { get; } = new Version("0.8.0");
        public uint AppVersion { get; } = 0800;

        public long Unknown25 { get; } = -1553869577012279119;

        public async Task<HashData> GetHashDataAsync(RequestEnvelope requestEnvelope, byte[] locationBytes, byte[][] requestsBytes, byte[] serializedTicket)
        {
            return await Task.Run(() =>
            {
                return new HashData
                {
                    LocationAuthHash = NiaHashLegacy.Hash32Salt(locationBytes, NiaHashLegacy.Hash32(serializedTicket)),
                    LocationHash = NiaHashLegacy.Hash32(locationBytes),
                    RequestHashes = requestsBytes.Select(x => NiaHashLegacy.Hash64Salt64(x, NiaHashLegacy.Hash64(serializedTicket))).ToArray()
                };
            });
        }

        public byte[] GetEncryptedSignature(byte[] signatureBytes, uint timestampSinceStartMs)
        {
            return PCryptLegacy.Encrypt(signatureBytes, timestampSinceStartMs);
        }
    }
}
