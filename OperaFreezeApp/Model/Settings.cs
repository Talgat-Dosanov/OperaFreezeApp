using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaFreezeApp.Model
{
    [Serializable]
    public class Settings
    {
        public string OperaPath { get; set; }
        public string OperaDriverPath { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Proxy { get; set; } = false;
        public string ProxyServer { get; set; }
        public string ProxyPort { get; set; }
        public bool is1xBit { get; set; } = true;
        public bool isLineBetMirror { get; set; } = false;
    }
}
