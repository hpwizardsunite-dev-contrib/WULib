using System;
using System.Threading.Tasks;
using WUProtos.Networking.Envelopes;

namespace WULib.Core.Util.Hash
{
    public interface IHasher
    {

        /// <summary>
        /// The UniteVersion this <see cref="IHasher"/> is made for.
        /// Please use API versioning of WizardsGo only (https://uniterelease.nianticlabs.com/plfe/version).
        /// </summary>
        Version WizardsVersion { get; }

        long Unknown25 { get; }
        uint AppVersion { get; }

        Task<HashData> GetHashDataAsync(RequestEnvelope requestEnvelope, byte[] locationBytes, byte[][] requestsBytes, byte[] serializedTicket);

        byte[] GetEncryptedSignature(byte[] signatureBytes, uint timestampSinceStartMs);
    }
}
