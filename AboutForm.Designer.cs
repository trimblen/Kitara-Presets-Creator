namespace KitaraPresetsCreator
{
    partial class AboutForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.aboutPict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPict)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(100, 144);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "   O&k...";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Location = new System.Drawing.Point(27, 72);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAbout.Size = new System.Drawing.Size(229, 68);
            this.labelAbout.TabIndex = 1;
            this.labelAbout.Text = "Copyright (c) 2021. Kitara Presets Creator is a free open-source software license" +
    "d by MIT license.";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutPict
            // 
            this.aboutPict.BackgroundImage = global::KitaraPresetsCreator.Properties.Resources.logo;
            this.aboutPict.Location = new System.Drawing.Point(90, 16);
            this.aboutPict.Name = "aboutPict";
            this.aboutPict.Size = new System.Drawing.Size(100, 50);
            this.aboutPict.TabIndex = 2;
            this.aboutPict.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 179);
            this.Controls.Add(this.aboutPict);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.aboutPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.PictureBox aboutPict;
    }
}