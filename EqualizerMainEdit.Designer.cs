namespace KitaraPresetsCreator
{
    partial class EqualizerMainEdit
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
            this.chOn = new System.Windows.Forms.CheckBox();
            this.LLowMidQ = new System.Windows.Forms.Label();
            this.numLowMidQ = new System.Windows.Forms.NumericUpDown();
            this.numHighMidQ = new System.Windows.Forms.NumericUpDown();
            this.LHighMidQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLowMidQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighMidQ)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(48, 105);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(191, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // chOn
            // 
            this.chOn.AutoSize = true;
            this.chOn.Location = new System.Drawing.Point(52, 33);
            this.chOn.Name = "chOn";
            this.chOn.Size = new System.Drawing.Size(41, 17);
            this.chOn.TabIndex = 17;
            this.chOn.Text = "on:";
            this.chOn.UseVisualStyleBackColor = true;
            // 
            // LLowMidQ
            // 
            this.LLowMidQ.AutoSize = true;
            this.LLowMidQ.Location = new System.Drawing.Point(49, 53);
            this.LLowMidQ.Name = "LLowMidQ";
            this.LLowMidQ.Size = new System.Drawing.Size(60, 13);
            this.LLowMidQ.TabIndex = 18;
            this.LLowMidQ.Text = "low_mid_q:";
            // 
            // numLowMidQ
            // 
            this.numLowMidQ.Location = new System.Drawing.Point(119, 53);
            this.numLowMidQ.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numLowMidQ.Name = "numLowMidQ";
            this.numLowMidQ.Size = new System.Drawing.Size(120, 20);
            this.numLowMidQ.TabIndex = 19;
            // 
            // numHighMidQ
            // 
            this.numHighMidQ.Location = new System.Drawing.Point(119, 79);
            this.numHighMidQ.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numHighMidQ.Name = "numHighMidQ";
            this.numHighMidQ.Size = new System.Drawing.Size(120, 20);
            this.numHighMidQ.TabIndex = 21;
            // 
            // LHighMidQ
            // 
            this.LHighMidQ.AutoSize = true;
            this.LHighMidQ.Location = new System.Drawing.Point(49, 81);
            this.LHighMidQ.Name = "LHighMidQ";
            this.LHighMidQ.Size = new System.Drawing.Size(64, 13);
            this.LHighMidQ.TabIndex = 20;
            this.LHighMidQ.Text = "high_mid_q:";
            // 
            // EqualizerMainEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 159);
            this.Controls.Add(this.numHighMidQ);
            this.Controls.Add(this.LHighMidQ);
            this.Controls.Add(this.numLowMidQ);
            this.Controls.Add(this.LLowMidQ);
            this.Controls.Add(this.chOn);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EqualizerMainEdit";
            this.Text = "Equalizer Main Edit...";
            this.Load += new System.EventHandler(this.EqualizerMainEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLowMidQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighMidQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.CheckBox chOn;
        private System.Windows.Forms.Label LLowMidQ;
        private System.Windows.Forms.NumericUpDown numLowMidQ;
        private System.Windows.Forms.NumericUpDown numHighMidQ;
        private System.Windows.Forms.Label LHighMidQ;
    }
}