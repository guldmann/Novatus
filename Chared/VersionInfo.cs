using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{
    public class VersionInfo
    {
		public string ApplicationName { get; set; }
        string ApplicationVersion { get; set; }
        string VersionInfoMSG { get; set; }
		List<RegKey> RegKeyList { get; set; }
		public string ContentFileName { get; set; }
		public string TempDir { get; set; }
		List<UpdateServer> ServerList { get; set; }
		
	}
}
