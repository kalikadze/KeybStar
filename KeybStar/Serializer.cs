using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using objectItems;
using System.IO;

namespace KeybStar
{
    class Serializer
    {
        public void serializeObj(string filename, List<launchItemClass> objs2file)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objs2file);
            stream.Close();
        }

        public List<launchItemClass> deseriazileobjs( string filename)
        {
            List<launchItemClass> launchItem;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            launchItem = (List<launchItemClass>)bFormatter.Deserialize(stream);
            stream.Close();
            return launchItem;
        }

        public Serializer()
        {
        }
    }
}
