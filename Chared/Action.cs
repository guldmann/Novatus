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
		public string When { get; set; }//TODO make this enum
		public string Args { get; set; }
		public string WorkingDir { get; set; }
		public string StartStop { get; set; } //TODO enum or bool ? 
        public bool WaiteForExit { get; set; }
        public int TimeToWaitForExit { get; set; } = 0; 
	}
}
