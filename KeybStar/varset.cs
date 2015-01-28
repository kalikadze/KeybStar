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
    static public class varset
    {
        // check if was KeybStar alreadu started 
        static public bool wasstarted = false;
        // set of special keydata values which will be used as flags which indicate
        // that a special key is down
        static public bool LShiftKeyDn = false;
        static public bool RShiftKeyDn = false;
        static public bool RControlKeyDn = false;
        static public bool LControlKeyDn = false;
        static public bool RMenuDn = false;
        static public bool LMenuDn = false;
        static public bool LWinDn = false;
        static public bool AppsDn = false;           
    }
}
