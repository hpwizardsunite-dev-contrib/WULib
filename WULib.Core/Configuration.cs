using WULib.Core.Util.Hash;

namespace WULib.Core
{
    public static class Configuration
    {

        /// <summary>
        /// Gets or sets the amount of milliseconds between HTTP requests to WizardsGo.
        /// </summary>
        public static int ThrottleDifference { get; set; } = 1000;

        /// <summary>
        /// Gets or sets the <see cref="IgnoreHashVersion"/> boolean. If set to true, HashVersion checking will be disabled.
        /// </summary>
        public static bool IgnoreHashVersion { get; set; } = false;

        /// <summary>
        /// Gets or sets the <see cref="IgnoreHashSemafore"/> boolean.
        /// </summary>
        public static bool IgnoreHashSemafore { get; set; } = false;

        /// <summary>
        /// Gets or sets the <see cref="IgnoreRPCSemafore"/> boolean.
        /// </summary>
        public static bool IgnoreRPCSemafore { get; set; } = false;

        /// <summary>
        /// Gets or sets the <see cref="EnableHeartbeat"/> boolean. If set to true, session Heartbeat.
        /// </summary>
        public static bool EnableHeartbeat { get; set; } = true;

        /// <summary>
        /// Gets or sets the <see cref="IHasher"/> used in <see cref="WULib.Core.Net.RpcEncryption"/>.
        /// </summary>
        public static IHasher Hasher { get; set; } = new LegacyHasher();
    }
}