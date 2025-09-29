namespace SCNCORE_ORION_RMM_Web_Console.Configuration
{
    public static class Members_Portal
    {
        public static bool cloud_enabled { get; set; } = false;
        public static bool api_enabled { get; set; } = false;
        public static string api_key { get; set; } = string.Empty;
        public static bool isCodeSigned { get; set; } = false; 
    }
}