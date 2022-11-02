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
        public string operaBinary { get; private set; }
        public string operaDriverBinary { get; private set; }
        AppController controller;

        public Form1()
        {
            InitializeComponent();
            
            pathBtn.Click += label1_Click;
        
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
            if (openPathTab.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            operaBinary = openPathTab.FileName;
            textBox1.Text = operaBinary;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            controller = new AppController(operaBinary, operaDriverBinary);
            controller.StartApp();
            controller.Navigate("https://1xbit6.com/ru/line/esports");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void operaDriverBtn_Click(object sender, EventArgs e)
        {
            if(folderOperaDriver.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            operaDriverBinary = folderOperaDriver.SelectedPath;
            operaDriverText.Text = operaDriverBinary;
        }
    }
}
