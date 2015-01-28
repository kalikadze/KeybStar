namespace KeybStar
{
    partial class KSmainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KSmainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "KeybStar 1.0";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayStrip
            // 
            this.trayStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLauncherToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.trayStrip.Name = "trayStrip";
            this.trayStrip.Size = new System.Drawing.Size(167, 48);
            // 
            // manageLauncherToolStripMenuItem
            // 
            this.manageLauncherToolStripMenuItem.Name = "manageLauncherToolStripMenuItem";
            this.manageLauncherToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.manageLauncherToolStripMenuItem.Text = "Manage launcher";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // KSmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 226);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KSmainForm";
            this.Text = "KeybStar 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trayStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayStrip;
        private System.Windows.Forms.ToolStripMenuItem manageLauncherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

