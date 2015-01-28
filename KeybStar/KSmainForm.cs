using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using objectItems;

namespace KeybStar
{    
    public partial class KSmainForm : Form
    { 
        // initialize keyhook listener
        private KeyboardHookListener keyHook;
        // initialize of launchitemlist which will contain objects with all basic params
        List<launchItemClass> launchItemlist = new List<launchItemClass>();
        Serializer s = new Serializer();
        // location of settings file
        static public string settFile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\kssettings.ks";
        //   
        
        public KSmainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {            
            this.Visible = false;
            this.ShowInTaskbar = false;
            trayIcon.ContextMenuStrip = trayStrip;
            
            keyHook = new KeyboardHookListener(new GlobalHooker());
            keyHook.Enabled = true;
            keyHook.KeyDown += keyHook_keyDown;
            keyHook.KeyUp += keyHook_keyUP;

            settFile = settFile.Replace("file:\\", "");
            launchItemlist = s.deseriazileobjs(settFile);

            for (int i = 0; i < launchItemlist.Count; i++)
            {
                shortsListBox.Items.Add(launchItemlist[i].keydata);
                pathListBox.Items.Add(launchItemlist[i].filepath);
            }
        }      

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keyHook.Dispose();
            Application.Exit();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible || !varset.wasstarted)
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
                varset.wasstarted = true;
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
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
        }

        
        /// <summary>
        /// list of special keydata :
        ///    
        ///    LShiftKey
        ///    RShiftKey
        ///    RControlKey
        ///    LControlKey
        ///    RMenu
        ///    LMenu
        ///    LWin
        ///    Apps
        ///    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyHook_keyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxSuppress.Checked)
                e.Handled = true;
            else
                e.Handled = false;

            // set up flag-down to true for special key (shift, ctrl, alt)
            string receivedKeyCode = e.KeyData.ToString();
            switch(receivedKeyCode)
            {
                case "LShiftKey":
                    varset.LShiftKeyDn = true;
                    break;                
                case "RShiftKey":
                    varset.RShiftKeyDn = true;
                    break;
                case "RControlKey":
                    varset.RControlKeyDn = true;
                    break;
                case "LControlKey":
                    varset.LControlKeyDn = true;
                    break;
                case "RMenu":
                    varset.RMenuDn = true;
                    break;
                case "LMenu":
                    varset.LMenuDn = true;
                    break;
                case "LWin":
                    varset.LWinDn = true;
                    break;
                case "Apps":
                    varset.AppsDn = true;
                    break;            
            }

            // if still pressed shift key
            if (varset.LShiftKeyDn || varset.RShiftKeyDn)
                checkBoxShift.Checked = true;
            else
                checkBoxShift.Checked = false;

            // if still pressed ctrl key
            if (varset.RControlKeyDn || varset.LControlKeyDn)
                checkBoxCtrl.Checked = true;
            else
                checkBoxCtrl.Checked = false;
            
            // if still pressed alt key
            if (varset.LMenuDn || varset.RMenuDn)
                checkBoxAlt.Checked = true;
            else
                checkBoxAlt.Checked = false;

            //
            if (launchItemlist.Count == 0 && shortsTextBox.Focused)
            {
                switch (receivedKeyCode)
                {
                    case "LShiftKey":
                        break;
                    case "RShiftKey":
                        break;
                    case "RControlKey":
                        break;
                    case "LControlKey":
                        break;
                    case "RMenu":
                        break;
                    case "LMenu":
                        break;
                    case "LWin":
                        break;
                    case "Apps":
                        break;
                    default:
                        shortsTextBox.Text = e.KeyData.ToString();
                        break;
                }
            }


            for (int i = 0; i < launchItemlist.Count; i++)
            {
                if (launchItemlist[i].keydata == e.KeyData.ToString())
                {
                    // this KeyData is also stored in List, 
                    // and therefore i must processed id according to settings in object
                    // keydata id just first identificator to lunch external application,
                    // i must here verefify also Shift, Ctrl, Alt keys combination too

                    if ((launchItemlist[i].isShift == varset.LShiftKeyDn || launchItemlist[i].isShift == varset.RShiftKeyDn) &&
                        (launchItemlist[i].isCtrl == varset.LControlKeyDn || launchItemlist[i].isCtrl == varset.RControlKeyDn) &&
                        (launchItemlist[i].isAlt == varset.LMenuDn || launchItemlist[i].isAlt == varset.RMenuDn)
                       )
                    {
                        e.Handled = launchItemlist[i].handled;
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = launchItemlist[i].filepath;
                        psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                        Process.Start(psi);
                    }                    
                }
                else
                {
                    if (shortsTextBox.Focus())
                    {
                        switch (receivedKeyCode)
                        {
                            case "LShiftKey":
                                break;
                            case "RShiftKey":
                                break;
                            case "RControlKey":
                                break;
                            case "LControlKey":
                                break;
                            case "RMenu":
                                break;
                            case "LMenu":
                                break;
                            case "LWin":
                                break;
                            case "Apps":
                                break;
                            default:
                                shortsTextBox.Text = e.KeyData.ToString();
                                break;
                        }
                    }                        
                }
            }
        }

        private void keyHook_keyUP(object sender, KeyEventArgs e)
       {
           switch (e.KeyData.ToString())
           {
               case "LShiftKey":
                   varset.LShiftKeyDn = false;
                   break;
               case "RShiftKey":
                   varset.RShiftKeyDn = false;
                   break;
               case "RControlKey":
                   varset.RControlKeyDn = false;
                   break;
               case "LControlKey":
                   varset.LControlKeyDn = false;
                   break;
               case "RMenu":
                   varset.RMenuDn = false;
                   break;
               case "LMenu":
                   varset.LMenuDn = false;
                   break;
               case "LWin":
                   varset.LWinDn = false;
                   break;
               case "Apps":
                   varset.AppsDn = false;
                   break;
           }

           // if still pressed shift key
           if (varset.LShiftKeyDn || varset.RShiftKeyDn)
               checkBoxShift.Checked = true;
           else
               checkBoxShift.Checked = false;
           // if still pressed ctrl key
           if (varset.RControlKeyDn || varset.LControlKeyDn)
               checkBoxCtrl.Checked = true;
           else
               checkBoxCtrl.Checked = false;
           // if still pressed alt key
           if (varset.LMenuDn || varset.RMenuDn)
               checkBoxAlt.Checked = true;
           else
               checkBoxAlt.Checked = false;
       }

       private void addButton_Click(object sender, EventArgs e)
       {
            if (shortsTextBox.Text != "" && pathTextBox.Text != "")
            {
                pathTextBox.Text = pathTextBox.Text.Trim('"', ' ');
                launchItemClass launchitem = new launchItemClass(shortsTextBox.Text, pathTextBox.Text, true, checkBoxShift.Checked, checkBoxCtrl.Checked, checkBoxAlt.Checked);
                launchItemlist.Add(launchitem);

                shortsListBox.Items.Add(shortsTextBox.Text);
                pathListBox.Items.Add(pathTextBox.Text);

                shortsTextBox.Clear();
                pathTextBox.Clear();
                serializetoFile();
                toolStripStatus.Text = "OK";
            }
            else
                toolStripStatus.Text = "There was invalid path name or keys combination";
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            toolStripStatus.Text = "Select desired application";
            DialogResult result = browsetoAppDialog.ShowDialog();
            if (result == DialogResult.OK)
                pathTextBox.Text = browsetoAppDialog.FileName;
        }

        private void serializetoFile()
        {
            settFile = settFile.Replace("file:\\", "");
            s.serializeObj(settFile, launchItemlist);                      
        }

        private void shortsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathListBox.SelectedIndex = shortsListBox.SelectedIndex;
            if (pathListBox.SelectedIndex > -1 && shortsListBox.SelectedIndex > -1)
            {
                checkBoxShift.Checked = launchItemlist[shortsListBox.SelectedIndex].isShift;
                checkBoxCtrl.Checked = launchItemlist[shortsListBox.SelectedIndex].isCtrl;
                checkBoxAlt.Checked = launchItemlist[shortsListBox.SelectedIndex].isAlt;
            }
        }

        private void pathListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shortsListBox.SelectedIndex = pathListBox.SelectedIndex;
            if (pathListBox.SelectedIndex > -1 && shortsListBox.SelectedIndex > -1)
            {
                checkBoxShift.Checked = launchItemlist[shortsListBox.SelectedIndex].isShift;
                checkBoxCtrl.Checked = launchItemlist[shortsListBox.SelectedIndex].isCtrl;
                checkBoxAlt.Checked = launchItemlist[shortsListBox.SelectedIndex].isAlt;
            }
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            if (shortsListBox.SelectedIndex > -1 && pathListBox.SelectedIndex > -1)
            {
                int tempy = shortsListBox.SelectedIndex;
                shortsListBox.Items.RemoveAt(tempy);
                pathListBox.Items.RemoveAt(tempy);
                launchItemlist.RemoveAt(tempy);
                // write actual settings to a file            
                serializetoFile();
            }
            
        }
    }
}