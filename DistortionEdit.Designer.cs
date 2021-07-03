namespace KitaraPresetsCreator
{
    partial class DistortionEdit
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
            this.LType = new System.Windows.Forms.Label();
            this.numType = new System.Windows.Forms.NumericUpDown();
            this.LLevel = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.LDrive = new System.Windows.Forms.Label();
            this.numDrive = new System.Windows.Forms.NumericUpDown();
            this.LTone = new System.Windows.Forms.Label();
            this.numTone = new System.Windows.Forms.NumericUpDown();
            this.LBooster = new System.Windows.Forms.Label();
            this.numBooster = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBooster)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(19, 217);
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
            this.chOn.Location = new System.Drawing.Point(28, 49);
            this.chOn.Name = "chOn";
            this.chOn.Size = new System.Drawing.Size(41, 17);
            this.chOn.TabIndex = 17;
            this.chOn.Text = "on:";
            this.chOn.UseVisualStyleBackColor = true;
            // 
            // numFxblock
            // 
            this.numFxblock.Location = new System.Drawing.Point(90, 19);
            this.numFxblock.Maximum = new decimal(new int[] {
            1,
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
            this.LFxblock.Location = new System.Drawing.Point(25, 21);
            this.LFxblock.Name = "LFxblock";
            this.LFxblock.Size = new System.Drawing.Size(44, 13);
            this.LFxblock.TabIndex = 19;
            this.LFxblock.Text = "fxblock:";
            // 
            // LType
            // 
            this.LType.AutoSize = true;
            this.LType.Location = new System.Drawing.Point(25, 77);
            this.LType.Name = "LType";
            this.LType.Size = new System.Drawing.Size(30, 13);
            this.LType.TabIndex = 21;
            this.LType.Text = "type:";
            // 
            // numType
            // 
            this.numType.Location = new System.Drawing.Point(90, 75);
            this.numType.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numType.Name = "numType";
            this.numType.Size = new System.Drawing.Size(120, 20);
            this.numType.TabIndex = 20;
            // 
            // LLevel
            // 
            this.LLevel.AutoSize = true;
            this.LLevel.Location = new System.Drawing.Point(25, 103);
            this.LLevel.Name = "LLevel";
            this.LLevel.Size = new System.Drawing.Size(32, 13);
            this.LLevel.TabIndex = 23;
            this.LLevel.Text = "level:";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(90, 101);
            this.numLevel.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(120, 20);
            this.numLevel.TabIndex = 22;
            // 
            // LDrive
            // 
            this.LDrive.AutoSize = true;
            this.LDrive.Location = new System.Drawing.Point(25, 129);
            this.LDrive.Name = "LDrive";
            this.LDrive.Size = new System.Drawing.Size(33, 13);
            this.LDrive.TabIndex = 25;
            this.LDrive.Text = "drive:";
            // 
            // numDrive
            // 
            this.numDrive.Location = new System.Drawing.Point(90, 127);
            this.numDrive.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numDrive.Name = "numDrive";
            this.numDrive.Size = new System.Drawing.Size(120, 20);
            this.numDrive.TabIndex = 24;
            // 
            // LTone
            // 
            this.LTone.AutoSize = true;
            this.LTone.Location = new System.Drawing.Point(25, 155);
            this.LTone.Name = "LTone";
            this.LTone.Size = new System.Drawing.Size(31, 13);
            this.LTone.TabIndex = 27;
            this.LTone.Text = "tone:";
            // 
            // numTone
            // 
            this.numTone.Location = new System.Drawing.Point(90, 153);
            this.numTone.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numTone.Name = "numTone";
            this.numTone.Size = new System.Drawing.Size(120, 20);
            this.numTone.TabIndex = 26;
            // 
            // LBooster
            // 
            this.LBooster.AutoSize = true;
            this.LBooster.Location = new System.Drawing.Point(25, 181);
            this.LBooster.Name = "LBooster";
            this.LBooster.Size = new System.Drawing.Size(45, 13);
            this.LBooster.TabIndex = 29;
            this.LBooster.Text = "booster:";
            // 
            // numBooster
            // 
            this.numBooster.Location = new System.Drawing.Point(90, 179);
            this.numBooster.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numBooster.Name = "numBooster";
            this.numBooster.Size = new System.Drawing.Size(120, 20);
            this.numBooster.TabIndex = 28;
            // 
            // DistortionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 258);
            this.Controls.Add(this.LBooster);
            this.Controls.Add(this.numBooster);
            this.Controls.Add(this.LTone);
            this.Controls.Add(this.numTone);
            this.Controls.Add(this.LDrive);
            this.Controls.Add(this.numDrive);
            this.Controls.Add(this.LLevel);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.LType);
            this.Controls.Add(this.numType);
            this.Controls.Add(this.LFxblock);
            this.Controls.Add(this.numFxblock);
            this.Controls.Add(this.chOn);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DistortionEdit";
            this.Text = "Distortion Edit...";
            this.Load += new System.EventHandler(this.DistortionEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBooster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.CheckBox chOn;
        private System.Windows.Forms.NumericUpDown numFxblock;
        private System.Windows.Forms.Label LFxblock;
        private System.Windows.Forms.Label LType;
        private System.Windows.Forms.NumericUpDown numType;
        private System.Windows.Forms.Label LLevel;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Label LDrive;
        private System.Windows.Forms.NumericUpDown numDrive;
        private System.Windows.Forms.Label LTone;
        private System.Windows.Forms.NumericUpDown numTone;
        private System.Windows.Forms.Label LBooster;
        private System.Windows.Forms.NumericUpDown numBooster;
    }
}