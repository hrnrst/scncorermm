namespace SCNCORE_ORION_RMM_Server.Configuration
{
    public class Members_Portal
    {
        public static byte[] installer_package_win_x64_zip_bytestream { get; set; }
        public static byte[] installer_package_win_arm64_zip_bytestream { get; set; }
        public static byte[] installer_package_linux_x64_zip_bytestream { get; set; }
        public static byte[] installer_package_linux_arm64_zip_bytestream { get; set; }
        public static byte[] installer_package_osx_x64_zip_bytestream { get; set; }
        public static byte[] installer_package_osx_arm64_zip_bytestream { get; set; }

        public static bool cloud_enabled { get; set; } = false;
        public static bool api_enabled { get; set; } = false;
        public static string api_key { get; set; } = string.Empty;
        public static bool isCodeSigned { get; set; } = false;

        public bool Enabled { get; set; } = false;
        public string ApiKeyOverride { get; set; }


    }
}