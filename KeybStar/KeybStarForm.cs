using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeybStar
{
    public partial class KSmainForm : Form
    {
        public KSmainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.ShowInTaskbar = false;
            trayIcon.ContextMenuStrip = trayStrip;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            this.Close();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
                this.Activate();
            }
            else
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) 
                return;
            e.Cancel = true;
            if (e.CloseReason == CloseReason.ApplicationExitCall) 
                e.Cancel = false;
        }

    }
}
