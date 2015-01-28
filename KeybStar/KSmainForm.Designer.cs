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
            this.shortsTextBox = new System.Windows.Forms.TextBox();
            this.shortsListBox = new System.Windows.Forms.ListBox();
            this.pathListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.remButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.shortsLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.browsetoAppDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxShift = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
            this.checkBoxAlt = new System.Windows.Forms.CheckBox();
            this.checkBoxSuppress = new System.Windows.Forms.CheckBox();
            this.trayStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            // shortsTextBox
            // 
            this.shortsTextBox.Location = new System.Drawing.Point(12, 206);
            this.shortsTextBox.Name = "shortsTextBox";
            this.shortsTextBox.Size = new System.Drawing.Size(116, 20);
            this.shortsTextBox.TabIndex = 1;
            // 
            // shortsListBox
            // 
            this.shortsListBox.FormattingEnabled = true;
            this.shortsListBox.HorizontalScrollbar = true;
            this.shortsListBox.Location = new System.Drawing.Point(12, 27);
            this.shortsListBox.Name = "shortsListBox";
            this.shortsListBox.Size = new System.Drawing.Size(116, 173);
            this.shortsListBox.TabIndex = 2;
            this.shortsListBox.SelectedIndexChanged += new System.EventHandler(this.shortsListBox_SelectedIndexChanged);
            // 
            // pathListBox
            // 
            this.pathListBox.FormattingEnabled = true;
            this.pathListBox.HorizontalScrollbar = true;
            this.pathListBox.Location = new System.Drawing.Point(134, 27);
            this.pathListBox.Name = "pathListBox";
            this.pathListBox.Size = new System.Drawing.Size(133, 173);
            this.pathListBox.TabIndex = 2;
            this.pathListBox.SelectedIndexChanged += new System.EventHandler(this.pathListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 232);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(134, 206);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(86, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // remButton
            // 
            this.remButton.Location = new System.Drawing.Point(134, 232);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(133, 23);
            this.remButton.TabIndex = 3;
            this.remButton.Text = "Remove";
            this.remButton.UseVisualStyleBackColor = true;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("MingLiU", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(226, 206);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(41, 20);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // shortsLabel
            // 
            this.shortsLabel.AutoSize = true;
            this.shortsLabel.Location = new System.Drawing.Point(12, 8);
            this.shortsLabel.Name = "shortsLabel";
            this.shortsLabel.Size = new System.Drawing.Size(84, 13);
            this.shortsLabel.TabIndex = 4;
            this.shortsLabel.Text = "Stored shortcuts";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(131, 8);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(67, 13);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Stored paths";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(276, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatus.Text = "toolStripStatusLabel1";
            // 
            // browsetoAppDialog
            // 
            this.browsetoAppDialog.FileName = "openFileDialog1";
            // 
            // checkBoxShift
            // 
            this.checkBoxShift.AutoSize = true;
            this.checkBoxShift.Location = new System.Drawing.Point(12, 293);
            this.checkBoxShift.Name = "checkBoxShift";
            this.checkBoxShift.Size = new System.Drawing.Size(90, 17);
            this.checkBoxShift.TabIndex = 6;
            this.checkBoxShift.Text = "pressed Shift ";
            this.checkBoxShift.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.AutoSize = true;
            this.checkBoxCtrl.Location = new System.Drawing.Point(12, 316);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCtrl.TabIndex = 7;
            this.checkBoxCtrl.Text = "pressed Ctrl";
            this.checkBoxCtrl.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlt
            // 
            this.checkBoxAlt.AutoSize = true;
            this.checkBoxAlt.Location = new System.Drawing.Point(12, 339);
            this.checkBoxAlt.Name = "checkBoxAlt";
            this.checkBoxAlt.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAlt.TabIndex = 7;
            this.checkBoxAlt.Text = "pressed Alt";
            this.checkBoxAlt.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuppress
            // 
            this.checkBoxSuppress.AutoSize = true;
            this.checkBoxSuppress.Location = new System.Drawing.Point(12, 261);
            this.checkBoxSuppress.Name = "checkBoxSuppress";
            this.checkBoxSuppress.Size = new System.Drawing.Size(142, 17);
            this.checkBoxSuppress.TabIndex = 6;
            this.checkBoxSuppress.Text = "suppress original actgion";
            this.checkBoxSuppress.UseVisualStyleBackColor = true;
            // 
            // KSmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 384);
            this.Controls.Add(this.checkBoxAlt);
            this.Controls.Add(this.checkBoxCtrl);
            this.Controls.Add(this.checkBoxSuppress);
            this.Controls.Add(this.checkBoxShift);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.shortsLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.remButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pathListBox);
            this.Controls.Add(this.shortsListBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.shortsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KSmainForm";
            this.Text = "KeybStar 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trayStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayStrip;
        private System.Windows.Forms.ToolStripMenuItem manageLauncherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox shortsTextBox;
        private System.Windows.Forms.ListBox shortsListBox;
        private System.Windows.Forms.ListBox pathListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label shortsLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.OpenFileDialog browsetoAppDialog;
        private System.Windows.Forms.CheckBox checkBoxShift;
        private System.Windows.Forms.CheckBox checkBoxCtrl;
        private System.Windows.Forms.CheckBox checkBoxAlt;
        private System.Windows.Forms.CheckBox checkBoxSuppress;
    }
}

