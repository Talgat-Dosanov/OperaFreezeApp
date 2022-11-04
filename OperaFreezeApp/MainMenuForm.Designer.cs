
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 249);
            this.Controls.Add(this.settings);
            this.Name = "MainMenuForm";
            this.Text = "OperaWebFreezer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
    }
}