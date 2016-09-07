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

        public UpdateAppInfo GetServer(UpdateAppInfo localAppVersion)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(localAppVersion., localPath + filename);
                wc.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                logger.Error("Fail download file: " + fileUrl, ex);
                return false;
            }







            string jsonText = File.ReadAllText(applicationInfoFile);
            return JsonConvert.DeserializeObject<UpdateAppInfo>(jsonText);



        }
    }
}
