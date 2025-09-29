using System.Threading.Tasks;

namespace SCNCORE_ORION_RMM_Server.Members_Portal
{
    public static class Handler
    {
        public static async Task Set_Api_Key(string apiKey)
        {
            await Task.CompletedTask;
        }

        public static async Task<bool> Check_Connection()
        {
            return await Task.FromResult(true);
        }

        public static async Task Request_License_Info_Json(string apiKey)
        {
            await Task.CompletedTask;
        }

        public static async Task<bool> Check_License_Limit_Reached()
        {
            return await Task.FromResult(false);
        }
        
        public static async Task<dynamic> Get_License_Info()
        {
            return await Task.FromResult(new { licensesMax = 100 }); // licensesMax property ile
        }

    }
}