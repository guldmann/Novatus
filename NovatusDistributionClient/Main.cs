using System.IO;
using Chared; 
using Newtonsoft.Json;

namespace NovatusDistributionClient
{
    public class Main
    {
        public bool GetUpdate(string updateinfoFile)
        {
            if (File.Exists(updateinfoFile))
            {
                var updateInfo = ReadFile(updateinfoFile);
                CheckForUpdate(updateInfo);
            }
            return false; 
        }

        private UpdateAppInfo ReadFile(string updatefile)
        {
            string jsonText = File.ReadAllText(updatefile);
            return JsonConvert.DeserializeObject<UpdateAppInfo>(jsonText);
        }

        private void CheckForUpdate(UpdateAppInfo updateInfo)
        {
            
        }
    }
}
