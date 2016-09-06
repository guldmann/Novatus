using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{

    /// <summary>
    /// TODO This is a DRAFT 
    /// Get this from update server and if update sucsess
    /// update localfile with data from server 
    /// </summary>
    public class UpdateAppInfo
    {
        public string ApplicationName { get; set; }
       List<UpdateServer> ServerList { get; set; } 
        public string ApllicationVersion { get; set; }
        public string UpdateMSG { get; set; }
        public string RootDir { get; set; }
        public string TempDir { get; set; }
        List<RegKeys> RegKeyList { get; set; } 
        List<Actions> ActionList { get; set; }
        public string ContentFileName { get; set;}
    }
}
