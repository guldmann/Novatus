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
        private string _protocol { get; set; }

        public CommunicationProtocol Protocol
        {
            get { return (CommunicationProtocol) Enum.Parse(typeof (CommunicationProtocol), _protocol); }
        }
    }
}
