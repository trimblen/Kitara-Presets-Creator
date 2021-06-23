namespace KitaraPresetsCreator
{
    partial class MasterVolumeEdit
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
            this.numericMasterVolume = new System.Windows.Forms.NumericUpDown();
            this.labelMasterVolume = new System.Windows.Forms.Label();
            this.buttOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMasterVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMasterVolume
            // 
            this.numericMasterVolume.Location = new System.Drawing.Point(146, 28);
            this.numericMasterVolume.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericMasterVolume.Name = "numericMasterVolume";
            this.numericMasterVolume.Size = new System.Drawing.Size(120, 20);
            this.numericMasterVolume.TabIndex = 0;
            // 
            // labelMasterVolume
            // 
            this.labelMasterVolume.AutoSize = true;
            this.labelMasterVolume.Location = new System.Drawing.Point(38, 30);
            this.labelMasterVolume.Name = "labelMasterVolume";
            this.labelMasterVolume.Size = new System.Drawing.Size(80, 13);
            this.labelMasterVolume.TabIndex = 1;
            this.labelMasterVolume.Text = "Master Volume:";
            // 
            // buttOk
            // 
            this.buttOk.Location = new System.Drawing.Point(109, 68);
            this.buttOk.Name = "buttOk";
            this.buttOk.Size = new System.Drawing.Size(89, 23);
            this.buttOk.TabIndex = 2;
            this.buttOk.Text = "Save d&ata...";
            this.buttOk.UseVisualStyleBackColor = true;
            this.buttOk.Click += new System.EventHandler(this.buttOk_Click);
            // 
            // MasterVolumeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 114);
            this.Controls.Add(this.buttOk);
            this.Controls.Add(this.labelMasterVolume);
            this.Controls.Add(this.numericMasterVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MasterVolumeEdit";
            this.Text = "Master Volume";
            this.Load += new System.EventHandler(this.MasterVolumeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMasterVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericMasterVolume;
        private System.Windows.Forms.Label labelMasterVolume;
        private System.Windows.Forms.Button buttOk;
    }
}