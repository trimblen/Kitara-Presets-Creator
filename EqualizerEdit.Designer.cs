namespace KitaraPresetsCreator
{
    partial class EqualizerEdit
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
            this.buttSave = new System.Windows.Forms.Button();
            this.numGain = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LFrequency = new System.Windows.Forms.Label();
            this.numFrequency = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(37, 87);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(215, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // numGain
            // 
            this.numGain.Location = new System.Drawing.Point(132, 35);
            this.numGain.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numGain.Name = "numGain";
            this.numGain.Size = new System.Drawing.Size(120, 20);
            this.numGain.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "gain:";
            // 
            // LFrequency
            // 
            this.LFrequency.AutoSize = true;
            this.LFrequency.Location = new System.Drawing.Point(34, 63);
            this.LFrequency.Name = "LFrequency";
            this.LFrequency.Size = new System.Drawing.Size(57, 13);
            this.LFrequency.TabIndex = 20;
            this.LFrequency.Text = "frequency:";
            // 
            // numFrequency
            // 
            this.numFrequency.Location = new System.Drawing.Point(132, 61);
            this.numFrequency.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numFrequency.Name = "numFrequency";
            this.numFrequency.Size = new System.Drawing.Size(120, 20);
            this.numFrequency.TabIndex = 19;
            // 
            // EqualizerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 143);
            this.Controls.Add(this.LFrequency);
            this.Controls.Add(this.numFrequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGain);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EqualizerEdit";
            this.Text = "Equalizer Edit...";
            this.Load += new System.EventHandler(this.EqualizerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.NumericUpDown numGain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LFrequency;
        private System.Windows.Forms.NumericUpDown numFrequency;
    }
}