using Newtonsoft.Json;
using NovatusCommon.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NovatusCommon.ComTypes
{
    public class CommunicationHttp : ICommunication
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ServerUpdateAppInfo> GetServerUpdateAppInfo(UpdateServer server)
        {
            var response = await client.GetAsync(UrlBuilder(server));
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ServerUpdateAppInfo>(responseBody);
        }

        private Uri UrlBuilder(UpdateServer server)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = server.Host;
            builder.Fragment = server.UpdateFileName;
            builder.Port = server.Port;
            builder.UserName = server.UserName;
            builder.Password = server.Password;
            return builder.Uri;
        }

        public Task DownloadFile(UpdateServer server, string fileUrl, string localPath)
        {
            throw new NotImplementedException();
        }

        public Task DownloadFiles(UpdateServer server, List<string> fileUrls, string localPath)
        {
            throw new NotImplementedException();
        }
    }
}