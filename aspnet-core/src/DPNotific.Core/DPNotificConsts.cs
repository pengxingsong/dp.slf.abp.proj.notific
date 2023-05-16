using DPNotific.Debugging;

namespace DPNotific
{
    public class DPNotificConsts
    {
        public const string LocalizationSourceName = "DPNotific";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "155255316ab140fb919475238db0f459";
    }
}
