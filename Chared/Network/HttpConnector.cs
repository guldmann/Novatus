using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Chared.Network
{
    class HttpConnector
    {
        public bool GetUpdateExist(UpdateAppInfo localAppVersion, int ServerListNumber)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(localAppVersion.ServerList[ServerListNumber].Url, localAppVersion.TempDir + localAppVersion.FileName);
                wc.Dispose();
                var ServerAppVersion = GetObjectFromFile(Path.Combine(localAppVersion.TempDir, localAppVersion.FileName));
                if(ServerAppVersion.ApllicationVersion > localAppVersion.ApllicationVersion)

            }
            catch (Exception ex)
            {
               // TODO loging in here 
                return null; 
            }
        }

        private UpdateAppInfo GetObjectFromFile(string file)
        {
            string jsonText = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<UpdateAppInfo>(jsonText);
        }
    }
}
