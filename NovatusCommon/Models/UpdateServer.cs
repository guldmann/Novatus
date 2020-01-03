using NovatusCommon.ComTypes;

namespace NovatusCommon.Models
{
    public class UpdateServer
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public ComType ComType { get; set; }
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public string Url { get; set; }
        public string Host { get; set; }
        public string UpdateFileName { get; set; } = "ServerUpdateAppInfo.json";

    }
}