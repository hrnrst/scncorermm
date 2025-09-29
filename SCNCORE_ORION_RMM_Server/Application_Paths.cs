using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Primitives;
using System.Runtime.InteropServices;

namespace SCNCORE_ORION_RMM_Server
{
    public class Application_Paths
    {
        public static string logs_dir = Path.Combine(GetBasePath(), "0x101 Cyber Security", "SCNCORE_ORION RMM", "Server", "Logs");

        public static string _public_uploads_user = Path.Combine(GetCurrentDirectory(), "www", "public", "uploads", "user");
        public static string _public_downloads_user = Path.Combine(GetCurrentDirectory(), "www", "public", "downloads", "user");

        public static string _private_files = Path.Combine(GetCurrentDirectory(), "www", "private", "files");
        public static string _private_files_admin_db_friendly = Path.Combine(GetCurrentDirectory(), "www", "private", "files");

        public static string _private_files_SCNCORE_ORION = Path.Combine(GetCurrentDirectory(), "www", "private", "files", "SCNCORE_ORION");
        public static string _private_files_SCNCORE_ORION_temp = Path.Combine(GetCurrentDirectory(), "www", "private", "files", "SCNCORE_ORION", "temp");

        public static string internal_dir = Path.Combine(GetCurrentDirectory(), "internal");
        public static string internal_temp_dir = Path.Combine(GetCurrentDirectory(), "internal", "temp");

        //OSSCH_START 03b0f623-d870-4a6d-bcac-704ee406519f //OSSCH_END

        public static string lettuceencrypt_persistent_data_dir = Path.Combine(GetCurrentDirectory(), "letsencrypt");

        // LLM
        public static string llm_model_path = Path.Combine(GetCurrentDirectory(), "llm", "model.gguf");

        private static string GetBasePath()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return "/var";
            }
            else
            {
                throw new NotSupportedException("Unsupported OS");
            }
        }

        private static string GetCurrentDirectory()
        {
            return AppContext.BaseDirectory;
        }
        
         public static string internal_packages_SCNCORE_ORION_core_metadata_json_path =>
            Path.Combine(AppContext.BaseDirectory, "internal_packages", "SCNCORE_ORION", "core_metadata.json");
    
    }
}