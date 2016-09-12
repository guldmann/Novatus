using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{
    internal class InstallerInfo
    {
        public string ApplicationName { get; set; }
        public List<UpdateServer> ServerList { get; set; }
        public string ApllicationVersion { get; set; }
        public string UpdateMSG { get; set; }
        public string RootDir { get; set; }
        public string TempDir { get; set; }
        public List<RegKey> RegKeyList { get; set; }
        public List<Action> ActionList { get; set; }
        public string ContentFileName { get; set; }
        public bool UseLicense { get; set; }
        public string LicenseFile { get; set; }

    }

}
