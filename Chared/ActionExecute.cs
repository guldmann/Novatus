using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Chared
{    
    class ActionExecute
    {        
        /// <summary>
        /// Executs the specified actions in  list.
        /// 
        /// NOTE if execute fail do we whant to stop update  by returning false  ?  
        /// </summary>
        /// <param name="actionList">The action list.</param>
        /// <param name="when">The when. to execute </param>
        /// <returns>bool true or false</returns>
        public bool Execut(List<Action> actionList, string when)
        {
            if (actionList != null && actionList.Count > 0)
            {
                foreach (var action in actionList)
                {
                    if (action.When == when)
                    {
                        if (action.StartStop == "start")
                        {
                            if (!ActionStart(action)) return false; 
                        }
                        else
                        {
                            if (!ActionStop(action)) return false; 
                        }
                    }
                    return false; 
                }
            }
            return false; 
        }


        /// <summary>
        /// Start Action and it set wait for it exit 
        /// NOTE:  
        ///  Do we need properties in action for 
        ///  * ProcessWindowsStyle
        ///  * CreateNoWindow  true / false
        ///  * USE shell execute 
        /// 
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>Bool true or false </returns>
        private bool ActionStart(Action action)
        {           
            ProcessStartInfo start = new ProcessStartInfo();
            start.WorkingDirectory = @action.WorkingDir;
            start.Arguments = action.Args;
            start.FileName = @action.FilePath;
            try
            {
                var proc = Process.Start(start);
                if(action.WaiteForExit)
                {
                    proc.WaitForExit(action.TimeToWaitForExit);
                }
                return true; 
            }
            catch(Exception e)
            {
                return false; 
            }     
        }

        /// <summary>
        /// Actions stop program.
        /// First try to close program gracefully wait 5 sec for it to exit 
        /// If program is running try to kill it 
        /// If kill doesn't work we cant stop the program return false
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>If program is stoped return true else return false</returns>
        private bool ActionStop(Action action)
        {           
            Process[] workers = Process.GetProcessesByName(action.FileName.Replace(".exe","").Replace(".EXE", ""));  
            foreach(var worker in workers)
            {
                try
                {                    
                    worker.CloseMainWindow();
                    worker.WaitForExit(5000);                    
                    if (!worker.HasExited)
                    {                        
                        worker.Kill();
                        worker.WaitForExit(5000); 
                        if(!worker.HasExited)
                        {                            
                            return false; 
                        }
                    }
                }
                catch(Exception ex)
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
