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
        int Index { get; set; } = 1;
        AppController Controller;
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
            Controller = new AppController();
            Controller.StartApp();
            Controller.Authorization(Controller.Settings.Email, Controller.Settings.Password);
        }

       
        private void freezeLoop_Click(object sender, EventArgs e)
        {

            Controller.PageFreeze(Index);
            Index = Controller.SetIndex();
        }

        private void stopFreeze_Click(object sender, EventArgs e)
        {
            Controller.CloseLastTab();
        }

        private void winBtn_Click(object sender, EventArgs e)
        {
            Controller.WinTab(Index);
            Index = Controller.driver.WindowHandles.IndexOf(Controller.driver.CurrentWindowHandle);
        }

        private void openNewTab_Click(object sender, EventArgs e)
        {
            Controller.OpenNewTab();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
       
        }
    }
}
