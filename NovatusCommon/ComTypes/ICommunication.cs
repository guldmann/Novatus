using NovatusCommon.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovatusCommon.ComTypes
{
    public interface ICommunication
    {
        Task<ServerUpdateAppInfo> GetServerUpdateAppInfo(UpdateServer server);

        Task DownloadFile(UpdateServer server, string fileUrl, string localPath);

        Task DownloadFiles(UpdateServer server, List<string> fileUrls, string localPath);
    }
}