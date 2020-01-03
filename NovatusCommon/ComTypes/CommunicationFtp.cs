using NovatusCommon.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovatusCommon.ComTypes
{
    public class CommunicationFtp : ICommunication
    {
        public Task DownloadFile(UpdateServer server, string fileUrl, string localPath)
        {
            throw new NotImplementedException();
        }

        public Task DownloadFiles(UpdateServer server, List<string> fileUrls, string localPath)
        {
            throw new NotImplementedException();
        }

        public Task<ServerUpdateAppInfo> GetServerUpdateAppInfo(UpdateServer server)
        {
            throw new NotImplementedException();
        }
    }
}