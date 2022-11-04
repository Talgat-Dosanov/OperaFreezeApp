using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaFreezeApp
{
    public partial class MainMenuForm : Form
    {
        Form1 SettingsWindow;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsWindow = new Form1();
            SettingsWindow.Show();
        }
    }
}
