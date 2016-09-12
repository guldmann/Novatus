using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		    LoadInstallerFile(); 
		}

	    private void LoadInstallerFile()
	    {
	        
	    }

	    private void button1_Click(object sender, EventArgs e)
        {
            wizardPages1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wizardPages1.SelectedIndex = 0;
        }
    }
    class WizardPages : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
}
