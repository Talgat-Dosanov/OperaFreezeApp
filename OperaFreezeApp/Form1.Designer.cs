
namespace OperaFreezeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.openPathTab = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pathBtn = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.operaDriverText = new System.Windows.Forms.TextBox();
            this.operaDriverBtn = new System.Windows.Forms.Button();
            this.folderOperaDriver = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(162, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите путь до opera.exe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openPathTab
            // 
            this.openPathTab.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 1;
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(313, 107);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(36, 24);
            this.pathBtn.TabIndex = 2;
            this.pathBtn.Text = "...";
            this.pathBtn.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(210, 268);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите путь к operadriver";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // operaDriverText
            // 
            this.operaDriverText.Location = new System.Drawing.Point(162, 182);
            this.operaDriverText.Name = "operaDriverText";
            this.operaDriverText.Size = new System.Drawing.Size(152, 23);
            this.operaDriverText.TabIndex = 5;
            // 
            // operaDriverBtn
            // 
            this.operaDriverBtn.Location = new System.Drawing.Point(313, 181);
            this.operaDriverBtn.Name = "operaDriverBtn";
            this.operaDriverBtn.Size = new System.Drawing.Size(36, 23);
            this.operaDriverBtn.TabIndex = 6;
            this.operaDriverBtn.Text = "...";
            this.operaDriverBtn.UseVisualStyleBackColor = true;
            this.operaDriverBtn.Click += new System.EventHandler(this.operaDriverBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.operaDriverBtn);
            this.Controls.Add(this.operaDriverText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openPathTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operaDriverText;
        private System.Windows.Forms.Button operaDriverBtn;
        private System.Windows.Forms.FolderBrowserDialog folderOperaDriver;
    }
}

