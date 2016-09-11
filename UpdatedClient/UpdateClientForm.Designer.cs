namespace UpdatedClient
{
	partial class UpdateClientForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClientForm));
			this.MinimizenotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStripMinMaxClose = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStripMinMaxClose.SuspendLayout();
			this.SuspendLayout();
			// 
			// MinimizenotifyIcon
			// 
			this.MinimizenotifyIcon.BalloonTipText = "Novatus is minimized to systemtry";
			this.MinimizenotifyIcon.BalloonTipTitle = "Info";
			this.MinimizenotifyIcon.ContextMenuStrip = this.contextMenuStripMinMaxClose;
			this.MinimizenotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizenotifyIcon.Icon")));
			this.MinimizenotifyIcon.Text = "Novatus Update Client";
			this.MinimizenotifyIcon.Visible = true;
			this.MinimizenotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinimizenotifyIcon_MouseDoubleClick);
			// 
			// contextMenuStripMinMaxClose
			// 
			this.contextMenuStripMinMaxClose.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.contextMenuStripMinMaxClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.contextMenuStripMinMaxClose.Name = "contextMenuStripMinMaxClose";
			this.contextMenuStripMinMaxClose.Size = new System.Drawing.Size(115, 52);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UpdateClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 415);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UpdateClientForm";
			this.Text = "Novatus Update Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateClientForm_FormClosing);
			this.Load += new System.EventHandler(this.UpdateClientForm_Load);
			this.Resize += new System.EventHandler(this.UpdateClientForm_Resize);
			this.contextMenuStripMinMaxClose.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon MinimizenotifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripMinMaxClose;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Button button1;
	}
}

