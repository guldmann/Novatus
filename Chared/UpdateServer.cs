using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{
    public class UpdateServer
    {
        public string ServerName { get; set; }
        public string Port { get; set; }
        public string Ip { get; set; }
        public string CertDomain { get; set; }
        private CommunicationProtocol Protocol { get; set; }
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;         
    }
}
