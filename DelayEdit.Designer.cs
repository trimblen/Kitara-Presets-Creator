namespace KitaraPresetsCreator
{
    partial class DelayEdit
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
            this.numFxblock = new System.Windows.Forms.NumericUpDown();
            this.LFxblock = new System.Windows.Forms.Label();
            this.LMode = new System.Windows.Forms.Label();
            this.numMode = new System.Windows.Forms.NumericUpDown();
            this.LPreLp = new System.Windows.Forms.Label();
            this.numPreLp = new System.Windows.Forms.NumericUpDown();
            this.LLevel = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.LTime = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.LFeedback = new System.Windows.Forms.Label();
            this.numFeedback = new System.Windows.Forms.NumericUpDown();
            this.LFeedbackFilter = new System.Windows.Forms.Label();
            this.numFeedbackFilter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreLp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeedbackFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(35, 272);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(204, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // chOn
            // 
            this.chOn.AutoSize = true;
            this.chOn.Location = new System.Drawing.Point(35, 54);
            this.chOn.Name = "chOn";
            this.chOn.Size = new System.Drawing.Size(41, 17);
            this.chOn.TabIndex = 17;
            this.chOn.Text = "on:";
            this.chOn.UseVisualStyleBackColor = true;
            // 
            // numFxblock
            // 
            this.numFxblock.Location = new System.Drawing.Point(119, 25);
            this.numFxblock.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numFxblock.Name = "numFxblock";
            this.numFxblock.Size = new System.Drawing.Size(120, 20);
            this.numFxblock.TabIndex = 18;
            // 
            // LFxblock
            // 
            this.LFxblock.AutoSize = true;
            this.LFxblock.Location = new System.Drawing.Point(32, 27);
            this.LFxblock.Name = "LFxblock";
            this.LFxblock.Size = new System.Drawing.Size(44, 13);
            this.LFxblock.TabIndex = 19;
            this.LFxblock.Text = "fxblock:";
            // 
            // LMode
            // 
            this.LMode.AutoSize = true;
            this.LMode.Location = new System.Drawing.Point(32, 83);
            this.LMode.Name = "LMode";
            this.LMode.Size = new System.Drawing.Size(36, 13);
            this.LMode.TabIndex = 21;
            this.LMode.Text = "mode:";
            // 
            // numMode
            // 
            this.numMode.Location = new System.Drawing.Point(119, 81);
            this.numMode.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numMode.Name = "numMode";
            this.numMode.Size = new System.Drawing.Size(120, 20);
            this.numMode.TabIndex = 20;
            // 
            // LPreLp
            // 
            this.LPreLp.AutoSize = true;
            this.LPreLp.Location = new System.Drawing.Point(32, 109);
            this.LPreLp.Name = "LPreLp";
            this.LPreLp.Size = new System.Drawing.Size(39, 13);
            this.LPreLp.TabIndex = 23;
            this.LPreLp.Text = "pre_lp:";
            // 
            // numPreLp
            // 
            this.numPreLp.Location = new System.Drawing.Point(119, 107);
            this.numPreLp.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numPreLp.Name = "numPreLp";
            this.numPreLp.Size = new System.Drawing.Size(120, 20);
            this.numPreLp.TabIndex = 22;
            // 
            // LLevel
            // 
            this.LLevel.AutoSize = true;
            this.LLevel.Location = new System.Drawing.Point(33, 135);
            this.LLevel.Name = "LLevel";
            this.LLevel.Size = new System.Drawing.Size(32, 13);
            this.LLevel.TabIndex = 25;
            this.LLevel.Text = "level:";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(119, 133);
            this.numLevel.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(120, 20);
            this.numLevel.TabIndex = 24;
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Location = new System.Drawing.Point(33, 161);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(29, 13);
            this.LTime.TabIndex = 27;
            this.LTime.Text = "time:";
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(119, 159);
            this.numTime.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(120, 20);
            this.numTime.TabIndex = 26;
            // 
            // LFeedback
            // 
            this.LFeedback.AutoSize = true;
            this.LFeedback.Location = new System.Drawing.Point(32, 187);
            this.LFeedback.Name = "LFeedback";
            this.LFeedback.Size = new System.Drawing.Size(55, 13);
            this.LFeedback.TabIndex = 29;
            this.LFeedback.Text = "feedback:";
            // 
            // numFeedback
            // 
            this.numFeedback.Location = new System.Drawing.Point(119, 185);
            this.numFeedback.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numFeedback.Name = "numFeedback";
            this.numFeedback.Size = new System.Drawing.Size(120, 20);
            this.numFeedback.TabIndex = 28;
            // 
            // LFeedbackFilter
            // 
            this.LFeedbackFilter.AutoSize = true;
            this.LFeedbackFilter.Location = new System.Drawing.Point(32, 213);
            this.LFeedbackFilter.Name = "LFeedbackFilter";
            this.LFeedbackFilter.Size = new System.Drawing.Size(80, 13);
            this.LFeedbackFilter.TabIndex = 31;
            this.LFeedbackFilter.Text = "feedback_filter:";
            // 
            // numFeedbackFilter
            // 
            this.numFeedbackFilter.Location = new System.Drawing.Point(119, 211);
            this.numFeedbackFilter.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numFeedbackFilter.Name = "numFeedbackFilter";
            this.numFeedbackFilter.Size = new System.Drawing.Size(120, 20);
            this.numFeedbackFilter.TabIndex = 30;
            // 
            // DelayEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 320);
            this.Controls.Add(this.LFeedbackFilter);
            this.Controls.Add(this.numFeedbackFilter);
            this.Controls.Add(this.LFeedback);
            this.Controls.Add(this.numFeedback);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.numTime);
            this.Controls.Add(this.LLevel);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.LPreLp);
            this.Controls.Add(this.numPreLp);
            this.Controls.Add(this.LMode);
            this.Controls.Add(this.numMode);
            this.Controls.Add(this.LFxblock);
            this.Controls.Add(this.numFxblock);
            this.Controls.Add(this.chOn);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DelayEdit";
            this.Text = "Delay Edit...";
            this.Load += new System.EventHandler(this.DelayEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreLp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeedbackFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.CheckBox chOn;
        private System.Windows.Forms.NumericUpDown numFxblock;
        private System.Windows.Forms.Label LFxblock;
        private System.Windows.Forms.Label LMode;
        private System.Windows.Forms.NumericUpDown numMode;
        private System.Windows.Forms.Label LPreLp;
        private System.Windows.Forms.NumericUpDown numPreLp;
        private System.Windows.Forms.Label LLevel;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Label LFeedback;
        private System.Windows.Forms.NumericUpDown numFeedback;
        private System.Windows.Forms.Label LFeedbackFilter;
        private System.Windows.Forms.NumericUpDown numFeedbackFilter;
    }
}