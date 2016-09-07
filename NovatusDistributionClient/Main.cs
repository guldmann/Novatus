using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
