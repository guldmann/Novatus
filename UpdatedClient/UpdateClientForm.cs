using System;
using System.Windows.Forms;

namespace UpdatedClient
{
    public partial class UpdateClientForm : Form
    {
        private string[] args = Environment.GetCommandLineArgs();

        public UpdateClientForm()
        {
            InitializeComponent();
        }

        #region Form minimize close and resize stuff

        private void UpdateClientForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                MinimizenotifyIcon.Visible = true;
                MinimizenotifyIcon.ShowBalloonTip(500);
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                MinimizenotifyIcon.Visible = false;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizenotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void UpdateClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var deialog = MessageBox.Show("YES to close Novatus, NO to minimize", "Exit or Minimize", MessageBoxButtons.YesNo);

            e.Cancel = deialog == DialogResult.No;
            WindowState = FormWindowState.Minimized;
        }

        #endregion Form minimize close and resize stuff

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // test code
            string somString = "";
            foreach (var arg in args)
            {
                somString += arg;
            }
            MessageBox.Show(somString);
        }
    }
}