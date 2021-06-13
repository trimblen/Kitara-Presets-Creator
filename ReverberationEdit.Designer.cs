namespace KitaraPresetsCreator
{
    partial class ReverberationEdit
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
            this.rType = new System.Windows.Forms.Label();
            this.pPre_lpf = new System.Windows.Forms.Label();
            this.rPrelpf = new System.Windows.Forms.NumericUpDown();
            this.rLev = new System.Windows.Forms.NumericUpDown();
            this.rLevel = new System.Windows.Forms.Label();
            this.rTypeNumber = new System.Windows.Forms.NumericUpDown();
            this.rTime = new System.Windows.Forms.NumericUpDown();
            this.rTimeLabel = new System.Windows.Forms.Label();
            this.rDelayFeedback = new System.Windows.Forms.NumericUpDown();
            this.rDelFeed = new System.Windows.Forms.Label();
            this.preDelTime = new System.Windows.Forms.Label();
            this.rDelTime = new System.Windows.Forms.NumericUpDown();
            this.buttSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rPrelpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTypeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDelayFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDelTime)).BeginInit();
            this.SuspendLayout();
            // 
            // rType
            // 
            this.rType.AutoSize = true;
            this.rType.Location = new System.Drawing.Point(12, 22);
            this.rType.Name = "rType";
            this.rType.Size = new System.Drawing.Size(68, 13);
            this.rType.TabIndex = 1;
            this.rType.Text = "Reverb type:";
            // 
            // pPre_lpf
            // 
            this.pPre_lpf.AutoSize = true;
            this.pPre_lpf.Location = new System.Drawing.Point(12, 49);
            this.pPre_lpf.Name = "pPre_lpf";
            this.pPre_lpf.Size = new System.Drawing.Size(43, 13);
            this.pPre_lpf.TabIndex = 2;
            this.pPre_lpf.Text = "Pre_lpf:";
            // 
            // rPrelpf
            // 
            this.rPrelpf.Location = new System.Drawing.Point(87, 47);
            this.rPrelpf.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rPrelpf.Name = "rPrelpf";
            this.rPrelpf.Size = new System.Drawing.Size(120, 20);
            this.rPrelpf.TabIndex = 5;
            // 
            // rLev
            // 
            this.rLev.Location = new System.Drawing.Point(87, 74);
            this.rLev.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rLev.Name = "rLev";
            this.rLev.Size = new System.Drawing.Size(120, 20);
            this.rLev.TabIndex = 6;
            // 
            // rLevel
            // 
            this.rLevel.AutoSize = true;
            this.rLevel.Location = new System.Drawing.Point(12, 76);
            this.rLevel.Name = "rLevel";
            this.rLevel.Size = new System.Drawing.Size(36, 13);
            this.rLevel.TabIndex = 7;
            this.rLevel.Text = "Level:";
            // 
            // rTypeNumber
            // 
            this.rTypeNumber.Location = new System.Drawing.Point(87, 20);
            this.rTypeNumber.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rTypeNumber.Name = "rTypeNumber";
            this.rTypeNumber.Size = new System.Drawing.Size(120, 20);
            this.rTypeNumber.TabIndex = 8;
            // 
            // rTime
            // 
            this.rTime.Location = new System.Drawing.Point(87, 101);
            this.rTime.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rTime.Name = "rTime";
            this.rTime.Size = new System.Drawing.Size(120, 20);
            this.rTime.TabIndex = 9;
            // 
            // rTimeLabel
            // 
            this.rTimeLabel.AutoSize = true;
            this.rTimeLabel.Location = new System.Drawing.Point(12, 103);
            this.rTimeLabel.Name = "rTimeLabel";
            this.rTimeLabel.Size = new System.Drawing.Size(33, 13);
            this.rTimeLabel.TabIndex = 10;
            this.rTimeLabel.Text = "Time:";
            // 
            // rDelayFeedback
            // 
            this.rDelayFeedback.Location = new System.Drawing.Point(87, 128);
            this.rDelayFeedback.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rDelayFeedback.Name = "rDelayFeedback";
            this.rDelayFeedback.Size = new System.Drawing.Size(120, 20);
            this.rDelayFeedback.TabIndex = 11;
            // 
            // rDelFeed
            // 
            this.rDelFeed.AutoSize = true;
            this.rDelFeed.Location = new System.Drawing.Point(13, 131);
            this.rDelFeed.Name = "rDelFeed";
            this.rDelFeed.Size = new System.Drawing.Size(67, 13);
            this.rDelFeed.TabIndex = 12;
            this.rDelFeed.Text = "Delay fback:";
            // 
            // preDelTime
            // 
            this.preDelTime.AutoSize = true;
            this.preDelTime.Location = new System.Drawing.Point(13, 159);
            this.preDelTime.Name = "preDelTime";
            this.preDelTime.Size = new System.Drawing.Size(59, 13);
            this.preDelTime.TabIndex = 13;
            this.preDelTime.Text = "Delay time:";
            // 
            // rDelTime
            // 
            this.rDelTime.Location = new System.Drawing.Point(87, 155);
            this.rDelTime.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.rDelTime.Name = "rDelTime";
            this.rDelTime.Size = new System.Drawing.Size(120, 20);
            this.rDelTime.TabIndex = 14;
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(16, 181);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(191, 23);
            this.buttSave.TabIndex = 15;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // ReverberationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 223);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.rDelTime);
            this.Controls.Add(this.preDelTime);
            this.Controls.Add(this.rDelFeed);
            this.Controls.Add(this.rDelayFeedback);
            this.Controls.Add(this.rTimeLabel);
            this.Controls.Add(this.rTime);
            this.Controls.Add(this.rTypeNumber);
            this.Controls.Add(this.rLevel);
            this.Controls.Add(this.rLev);
            this.Controls.Add(this.rPrelpf);
            this.Controls.Add(this.pPre_lpf);
            this.Controls.Add(this.rType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReverberationEdit";
            this.Text = "Reverberation...";
            this.Load += new System.EventHandler(this.ReverberationEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPrelpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTypeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDelayFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDelTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rType;
        private System.Windows.Forms.Label pPre_lpf;
        private System.Windows.Forms.NumericUpDown rPrelpf;
        private System.Windows.Forms.NumericUpDown rLev;
        private System.Windows.Forms.Label rLevel;
        private System.Windows.Forms.NumericUpDown rTypeNumber;
        private System.Windows.Forms.NumericUpDown rTime;
        private System.Windows.Forms.Label rTimeLabel;
        private System.Windows.Forms.NumericUpDown rDelayFeedback;
        private System.Windows.Forms.Label rDelFeed;
        private System.Windows.Forms.Label preDelTime;
        private System.Windows.Forms.NumericUpDown rDelTime;
        private System.Windows.Forms.Button buttSave;
    }
}