
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.settings = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.freezeLoop = new System.Windows.Forms.Button();
            this.closeTab = new System.Windows.Forms.Button();
            this.winBtn = new System.Windows.Forms.Button();
            this.openNewTab = new System.Windows.Forms.Button();
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
            this.startButton.Location = new System.Drawing.Point(206, 68);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // freezeLoop
            // 
            this.freezeLoop.Location = new System.Drawing.Point(56, 130);
            this.freezeLoop.Name = "freezeLoop";
            this.freezeLoop.Size = new System.Drawing.Size(107, 23);
            this.freezeLoop.TabIndex = 2;
            this.freezeLoop.Text = "Запустить фриз";
            this.freezeLoop.UseVisualStyleBackColor = true;
            this.freezeLoop.Click += new System.EventHandler(this.freezeLoop_Click);
            // 
            // closeTab
            // 
            this.closeTab.Location = new System.Drawing.Point(324, 130);
            this.closeTab.Name = "closeTab";
            this.closeTab.Size = new System.Drawing.Size(123, 23);
            this.closeTab.TabIndex = 3;
            this.closeTab.Text = "Закрыть вкладку";
            this.closeTab.UseVisualStyleBackColor = true;
            this.closeTab.Click += new System.EventHandler(this.stopFreeze_Click);
            // 
            // winBtn
            // 
            this.winBtn.Location = new System.Drawing.Point(197, 130);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(95, 23);
            this.winBtn.TabIndex = 4;
            this.winBtn.Text = "Выигрыш";
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.winBtn_Click);
            // 
            // openNewTab
            // 
            this.openNewTab.Location = new System.Drawing.Point(152, 188);
            this.openNewTab.Name = "openNewTab";
            this.openNewTab.Size = new System.Drawing.Size(177, 23);
            this.openNewTab.TabIndex = 5;
            this.openNewTab.Text = "Открыть новую вкладку";
            this.openNewTab.UseVisualStyleBackColor = true;
            this.openNewTab.Click += new System.EventHandler(this.openNewTab_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 249);
            this.Controls.Add(this.openNewTab);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.closeTab);
            this.Controls.Add(this.freezeLoop);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.settings);
            this.Name = "MainMenuForm";
            this.Text = "OperaWebFreezer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button freezeLoop;
        private System.Windows.Forms.Button closeTab;
        private System.Windows.Forms.Button winBtn;
        private System.Windows.Forms.Button openNewTab;
    }
}