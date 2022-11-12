
namespace OperaFreezeApp
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.settings = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.freezeLoop = new System.Windows.Forms.Button();
            this.winBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.Control;
            this.settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings.ForeColor = System.Drawing.SystemColors.Control;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(427, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(32, 23);
            this.settings.TabIndex = 0;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(206, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // freezeLoop
            // 
            this.freezeLoop.Location = new System.Drawing.Point(125, 130);
            this.freezeLoop.Name = "freezeLoop";
            this.freezeLoop.Size = new System.Drawing.Size(107, 23);
            this.freezeLoop.TabIndex = 2;
            this.freezeLoop.Text = "Запустить фриз";
            this.freezeLoop.UseVisualStyleBackColor = true;
            this.freezeLoop.Click += new System.EventHandler(this.freezeLoop_Click);
            // 
            // winBtn
            // 
            this.winBtn.Location = new System.Drawing.Point(264, 130);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(95, 23);
            this.winBtn.TabIndex = 4;
            this.winBtn.Text = "Выигрыш";
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.winBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(167, 96);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(13, 15);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "0";
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(206, 184);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 7;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 249);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.freezeLoop);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.settings);
            this.Name = "MainMenuForm";
            this.Text = "OperaWebFreezer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button freezeLoop;
        private System.Windows.Forms.Button winBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button stop_button;
    }
}