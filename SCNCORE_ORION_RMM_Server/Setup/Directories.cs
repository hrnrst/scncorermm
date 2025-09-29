namespace SCNCORE_ORION_RMM_Server.Setup
{
    public class Directories
    {
        public static void Check_Directories()
        {
            // Create the directories if they do not exist
            if (!Directory.Exists(Application_Paths.logs_dir))
                Directory.CreateDirectory(Application_Paths.logs_dir);

            if (!Directory.Exists(Application_Paths.internal_dir))
                Directory.CreateDirectory(Application_Paths.internal_dir);

            if (!Directory.Exists(Application_Paths.internal_temp_dir))
                Directory.CreateDirectory(Application_Paths.internal_temp_dir);

            if (!Directory.Exists(Application_Paths._private_files_SCNCORE_ORION))
                Directory.CreateDirectory(Application_Paths._private_files_SCNCORE_ORION);

            if (!Directory.Exists(Application_Paths._private_files_SCNCORE_ORION_temp))
                Directory.CreateDirectory(Application_Paths._private_files_SCNCORE_ORION_temp);

            if (!Directory.Exists(Application_Paths.lettuceencrypt_persistent_data_dir))
                Directory.CreateDirectory(Application_Paths.lettuceencrypt_persistent_data_dir);

            if (!Directory.Exists(Application_Paths._public_uploads_user))
                Directory.CreateDirectory(Application_Paths._public_uploads_user);

            if (!Directory.Exists(Application_Paths._public_downloads_user))
                Directory.CreateDirectory(Application_Paths._public_downloads_user);
        }
    }
}