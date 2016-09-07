using System.IO;
using Chared; 
using Newtonsoft.Json;

namespace NovatusDistributionClient
{
    public class Main
    {
        public bool GetUpdate(string applicationInfoFile)
        {
            if (File.Exists(applicationInfoFile))
            {
                var updateInfo = ReadFile(applicationInfoFile);
                CheckForUpdate(updateInfo);
            }
            return false; 
        }

        private UpdateAppInfo ReadFile(string applicationInfoFile)
        {
            string jsonText = File.ReadAllText(applicationInfoFile);
            return JsonConvert.DeserializeObject<UpdateAppInfo>(jsonText);
        }

        private void CheckForUpdate(UpdateAppInfo updateInfo)
        {
            
        }
    }
}
