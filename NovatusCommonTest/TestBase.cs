using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NovatusCommon.Models;

namespace NovatusCommonTest
{
    public abstract class TestBase
    {
        private TcpListener listener;
        private int port;

        protected TestBase()
        {
        }

        protected string GetLocalhostAddress()
        {
            listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();

            return $"http://localhost:{port}/";
        }


        protected string GetServerUpdateAppInfo()
        {
            var serverAppInfo = new ServerUpdateAppInfo
            {
                AppName = "Test App",
                AppVersion = "1.0",
                ContentFile = "content.json",
                UpdateInformation = "This is a  test ",
                UpdateServer = new UpdateServer
                {
                    ComType = NovatusCommon.ComTypes.ComType.Http,
                    Host = "localhost",
                    Password = "",
                    Port = 0,
                    ServerName = "test server",
                    UpdateFileName = "fileName",
                    Url = "url",
                    UserName = "Name"

                }
            };
            return JsonConvert.SerializeObject(serverAppInfo);

        }


        protected int GetPort()
        {
            return port;
        }

        public static Task BasicHttpServer(string url, string outputHtml)
        {
            return Task.Run(() =>
            {
                HttpListener listener = new HttpListener();
                listener.Prefixes.Add(url);
                listener.Start();

                HttpListenerContext context = listener.GetContext();
                HttpListenerResponse response = context.Response;

                Stream stream = response.OutputStream;
                var writer = new StreamWriter(stream);
                writer.Write(outputHtml);
                writer.Close();
            });
        }

        protected void CleanTestFolder()
        {
            Directory.Delete("TestFolders");
        }

        protected void CreateFiles()
        {
            int folders = 5;
            int subfolders = 5;
            int files = 5;
            int StartSize = 1000;
            string root = "TestFolders";
            Directory.CreateDirectory(root);

            for (int i = 0; i < folders; i++)
            {
                Directory.CreateDirectory($"{root}//{i}");
                for (int j = 0; j < subfolders; j++)
                {
                    Directory.CreateDirectory($"{root}//{i}//{j}");
                    for (int k = 0; k < files; k++)
                    {
                        File.WriteAllText($"{root}//{i}//{j}//{k}.txt", RandomString((StartSize + j) * (i) * (k)));
                    }
                }
            }
        }

        private static readonly Random random = new Random();

        protected static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}