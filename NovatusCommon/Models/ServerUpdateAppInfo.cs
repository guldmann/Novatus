using System;
using System.Collections.Generic;
using System.Text;

namespace NovatusCommon.Models
{
    public class ServerUpdateAppInfo
    {
        /// <summary>
        /// Application name, Gives the ability to change the application name from a client perspective.
        /// </summary>
        public string AppName { get; set; }
       
        //public string FileName { get; set; }

        /// <summary>
        /// Information of Update Server,
        /// Adds the ability to change to new server for client to get updates from for next update.
        /// </summary>
        public UpdateServer UpdateServer { get; set; }

        /// <summary>
        /// The update (new) version of application. 
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Information text to client / user what is new or changed in this version. 
        /// </summary>
        public string UpdateInformation { get; set; }

        ///// <summary>
        ///// Reg keys to apply when updating
        ///// </summary>
        //public List<RegKey> RegKeyList { get; set; }

        ///// <summary>
        ///// Actions to perform at the time of update.
        ///// This can be used to trigger CMD commands before or after update,
        ///// Like killing a process or run a program to update database. 
        ///// 
        ///// </summary>
        //public List<Action> ActionList { get; set; }

        /// <summary>
        /// Name of the content file for this version. 
        /// </summary>
        public string ContentFile { get; set; }
    }
}
