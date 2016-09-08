using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chared
{
	class Action
	{
		public string Name { get; set; }
		public string FilePath { get; set; }
		public string FileName { get; set;  }
		public ActionWhen When { get; set; }
		public string Args { get; set; }
		public string WorkingDir { get; set; }
		public ActionStartStop StartStop { get; set; }
        public bool WaiteForExit { get; set; }
        public int TimeToWaitForExit { get; set; } = 0; 
	}
}
