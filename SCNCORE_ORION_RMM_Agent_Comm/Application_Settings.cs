using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCNCORE_ORION_RMM_Agent_Comm
{
    internal class Application_Settings
    {
        public static string version = "2.5.2.6";
        public static string SCNCORE_ORION_Data_Database_String = @"Data Source=" + Application_Paths.program_data_SCNCORE_ORION_policy_database + ";";
        public static string SCNCORE_ORION_Events_Database_String = @"Data Source=" + Application_Paths.program_data_SCNCORE_ORION_events_database + ";";
        public static string SCNCORE_ORION_Local_Encryption_Key = "()TZ%/N)NZTG$/()4i59du4)";
    }
} 