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
            string fileName = openPathTab.FileName;
            textBox1.Text = fileName;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var controller = new AppController("C:\\Users\\talga\\AppData\\Local\\Programs\\Opera\\68.0.3618.104_0\\opera.exe",
              "C:\\Users\\talga\\source\\repos\\OperaWebDriver\\operadriver_win64");
            controller.Navigate("https://www.google.com/");
        }
    }
}
