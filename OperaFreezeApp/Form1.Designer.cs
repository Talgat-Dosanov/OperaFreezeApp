
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(29, 62);
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
            this.textBox1.Location = new System.Drawing.Point(26, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 1;
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(179, 78);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(36, 25);
            this.pathBtn.TabIndex = 2;
            this.pathBtn.Text = "...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(239, 269);
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
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите путь к operadriver";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // operaDriverText
            // 
            this.operaDriverText.Location = new System.Drawing.Point(26, 150);
            this.operaDriverText.Name = "operaDriverText";
            this.operaDriverText.Size = new System.Drawing.Size(152, 23);
            this.operaDriverText.TabIndex = 5;
            // 
            // operaDriverBtn
            // 
            this.operaDriverBtn.Location = new System.Drawing.Point(179, 149);
            this.operaDriverBtn.Name = "operaDriverBtn";
            this.operaDriverBtn.Size = new System.Drawing.Size(36, 25);
            this.operaDriverBtn.TabIndex = 6;
            this.operaDriverBtn.Text = "...";
            this.operaDriverBtn.UseVisualStyleBackColor = true;
            this.operaDriverBtn.Click += new System.EventHandler(this.operaDriverBtn_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(340, 60);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(336, 78);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Введите email...";
            this.emailTextBox.Size = new System.Drawing.Size(160, 23);
            this.emailTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Location = new System.Drawing.Point(339, 133);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(336, 150);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Введите пароль...";
            this.passwordTextBox.Size = new System.Drawing.Size(160, 23);
            this.passwordTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.operaDriverBtn);
            this.Controls.Add(this.operaDriverText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Настройки ";
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
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

