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
        public List<T> Load<T>()
        {
            var formatter = new BinaryFormatter();
            var filename = "settings_config";
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                if(fs.Length > 0 && formatter.Deserialize(fs) is List<T> items)
                {
                    return items;
                }
                else
                {
                    return new List<T>();
                }
            }

        }
        public void Save<T>(List<T> item)
        {
            var formatter = new BinaryFormatter();
            var filename = "settings_config";
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
    }
}
