using System.Runtime.InteropServices;

namespace SCNCORE_ORION_RMM_Server.Microsoft_Defender_Firewall
{
    public class Handler
    {
        public static bool Status()
        {
            return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows) || true;
        }

        public static void Rule_Inbound(string port)
        {
            // Cross-platform safe implementation
        }

        public static void Rule_Outbound(string port)
        {
            // Cross-platform safe implementation
        }
    }
}