using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace objectItems
{
    [Serializable()]
    public class launchItemClass : ISerializable
    {

        public string filepath;
        public string keydata;
        public bool handled;
        public bool isShift;
        public bool isCtrl;
        public bool isAlt;
        //public bool LWin;
        //public bool Apps;        

        public launchItemClass()
        {
            this.filepath = null;
            this.keydata = null;
            this.handled = false;
            this.isShift = false;
            this.isCtrl = false;
            this.isAlt = false;
        }

        public launchItemClass(string keydata, string filepath, bool handled, bool isShift, bool isCtrl, bool isAlt)
        {
            this.filepath = filepath;
            this.keydata = keydata;
            this.handled = handled;
            this.isShift = isShift;
            this.isCtrl = isCtrl;
            this.isAlt = isAlt;
        }


        public launchItemClass(SerializationInfo info, StreamingContext ctxt)
        {
            this.filepath = (string)info.GetValue("PathToFile", typeof(string));
            this.keydata = (string)info.GetValue("DataOfKey", typeof(string));
            this.handled = (bool)info.GetValue("WasHandled", typeof(bool));
            this.isShift = (bool)info.GetValue("ShiftPressed", typeof(bool));
            this.isCtrl = (bool)info.GetValue("CtrlPressed", typeof(bool));
            this.isAlt = (bool)info.GetValue("AltPressed", typeof(bool));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("PathToFile", this.filepath);
            info.AddValue("DataOfKey", this.keydata);
            info.AddValue("WasHandled", this.handled);
            info.AddValue("ShiftPressed", this.isShift);
            info.AddValue("CtrlPressed", this.isCtrl);
            info.AddValue("AltPressed", this.isAlt);
        } 
    }
}
