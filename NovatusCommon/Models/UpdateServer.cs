using NovatusCommon.Communication;

namespace NovatusCommon.Models
{
    public class UpdateServer
    {
        public string ServerName { get; set; }
        public string Port { get; set; }
        public ComType ComType { get; set; }
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public string Url { get; set; }
    }
}