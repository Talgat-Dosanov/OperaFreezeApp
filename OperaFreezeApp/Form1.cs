using OperaFreezeApp.Model;
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
    public partial class Form1 : Form
    {
        public AppController Controller;

        public Form1()
        {
            InitializeComponent();
            Controller = new AppController();
            operaPathText.Text = Controller.Settings.OperaPath;
            operaDriverText.Text = Controller.Settings.OperaDriverPath;
            emailTextBox.Text = Controller.Settings.Email;
            passwordTextBox.Text = Controller.Settings.Password;
            proxy_check.Checked = Controller.Settings.Proxy;
            server_textbox.Text = Controller.Settings.ProxyServer;
            port_textbox.Text = Controller.Settings.ProxyPort;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
           
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            var operaBinary = operaPathText.Text;
            var operaDriverBinary = operaDriverText.Text;
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;

          

            Controller = new AppController();

            if (proxy_check.Checked == true)
            {
                Controller.Settings.Proxy = true;
                Controller.Settings.ProxyServer = server_textbox.Text;
                Controller.Settings.ProxyPort = port_textbox.Text;
            }
            else
            {
                Controller.Settings.Proxy = false;
                Controller.Settings.ProxyServer = "";
                Controller.Settings.ProxyPort = "";
            }

            Controller.Settings.OperaPath = operaBinary;
            Controller.Settings.OperaDriverPath = operaDriverBinary;
            Controller.Settings.Email = email;
            Controller.Settings.Password = password;
            Controller.Save(Controller.Settings);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void operaDriverBtn_Click(object sender, EventArgs e)
        {
            if(folderOperaDriver.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            operaDriverText.Text = folderOperaDriver.SelectedPath;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //
        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            if (openPathTab.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            operaPathText.Text = openPathTab.FileName;
        }
    }
}
