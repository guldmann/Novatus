using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{
    //TODO DRAFT 
    class ActionExecute
    {
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
                            //TODO call a function to start here 
                        }
                        else
                        {
                            //TODO call a function to stop here 
                        }
                    }
                    return false; 
                }
            }
            return false; 
        }

        private bool ActionStart(Action action)
        {
            // TODO add code to start action 
            return false;
        }

        private bool ActionStop(Action action)
        {
            //TODO add code to stop action 
            return false; 
        }
    }


    
}
