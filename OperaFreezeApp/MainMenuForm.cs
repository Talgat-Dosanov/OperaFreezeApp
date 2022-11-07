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
        AppController Controller = new AppController();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            var settingsWindow = new Form1();
            settingsWindow.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Controller.StartApp();
            Controller.Authorization(Controller.Settings.Email, Controller.Settings.Password);
        }

        private void freezeLoop_Click(object sender, EventArgs e)
        {
            try
            {
                for()
                Controller.PageFreeze();
            }
            catch( Exception)
            {
                MessageBox.Show("Сделайте ставку!");
            }
           
            
        }

        private void stopFreeze_Click(object sender, EventArgs e)
        {
            Controller.CloseLastTab();
        }

        private void winBtn_Click(object sender, EventArgs e)
        {
            Controller.WinTab();
        }

        private void openNewTab_Click(object sender, EventArgs e)
        {
            Controller.OpenNewTab();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Controller.Test();
        }
    }
}
