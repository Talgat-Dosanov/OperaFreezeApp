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
    }
}
