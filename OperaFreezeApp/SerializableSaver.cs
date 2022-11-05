using OperaFreezeApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OperaFreezeApp
{
    public class SerializableSaver
    {
        public Settings Load ()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("settings_config.dat", FileMode.OpenOrCreate))
            {
                if(fs.Length > 0 && formatter.Deserialize(fs) is Settings item)
                {
                    return item;
                }
                else
                {
                    return  new Settings();
                }
            }

        }
        public void Save(Settings item)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("settings_config.dat", FileMode.Create))
            {
                formatter.Serialize(fs, item);
            }
        }
    }
}
