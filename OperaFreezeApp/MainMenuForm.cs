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
        //List<Timer> timerList = new List<Timer>();
        //List<Label> labelList = new List<Label>();
        AppController Controller;
        public MainMenuForm()
        {
            InitializeComponent();
            TopLevel = true;
            timer1.Interval = 1000;
            //timer2.Interval = 1000;
            //timerList.Add(timer1);
            //timerList.Add(timer2);
            //labelList.Add(timer_label);
            //labelList.Add(timer_label2);
            
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer_label.Text = (Convert.ToInt32(timer_label.Text) + 1).ToString();

                if (timer_label.Text == "10")
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                    Controller.WinTab(Index);
                    Index = Controller.driver.WindowHandles.IndexOf(Controller.driver.CurrentWindowHandle);
                    timer_label.Text = "0";
                    Controller.ClickOkBtn();
                    freezeLoop.PerformClick();
                }
            }
            catch (Exception)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer_label.Text = "0";
            }
          
           
        }
        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    timer_label2.Text = (Convert.ToInt32(timer_label2.Text) + 1).ToString();
        //    if (timer_label2.Text == "9")
        //    {
        //        timerList[1].Enabled = false;
        //        timerList[1].Stop();
        //        Controller.WinTab(Index);
        //        Index = Controller.driver.WindowHandles.IndexOf(Controller.driver.CurrentWindowHandle);
        //        timer_label2.Text = "0";
        //        Controller.ClickOkBtn();
        //        freezeLoop.PerformClick();
        //    }
        //}
        private void freezeLoop_Click(object sender, EventArgs e)
        {
           
            Controller.PageFreeze(Index);
            Index = Controller.SetIndex();
            timer1.Enabled = true;
            timer1.Start();
           
        }

        private void stopFreeze_Click(object sender, EventArgs e)
        {
            Controller.CloseLastTab();
        }

        private void winBtn_Click(object sender, EventArgs e)
        {
            Controller.WinTab(Index);
            Index = Controller.driver.WindowHandles.IndexOf(Controller.driver.CurrentWindowHandle);
            timer_label.Text = "0";
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void openNewTab_Click(object sender, EventArgs e)
        {
            ///
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            ///
        }

        private void cloneTab_btn_Click(object sender, EventArgs e)
        {
            Controller.OpenNewTab();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            timer_label.Text = "0";
        }
    }
}
