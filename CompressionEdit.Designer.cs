namespace KitaraPresetsCreator
{
    partial class CompressionEdit
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
            this.lfxblock = new System.Windows.Forms.Label();
            this.numFxblock = new System.Windows.Forms.NumericUpDown();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.lAttack = new System.Windows.Forms.Label();
            this.chOn = new System.Windows.Forms.CheckBox();
            this.numRelease = new System.Windows.Forms.NumericUpDown();
            this.lRelease = new System.Windows.Forms.Label();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.lThreshold = new System.Windows.Forms.Label();
            this.numRatio = new System.Windows.Forms.NumericUpDown();
            this.lRatio = new System.Windows.Forms.Label();
            this.numBoost = new System.Windows.Forms.NumericUpDown();
            this.lBoost = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.LKnee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(43, 263);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(221, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            // 
            // lfxblock
            // 
            this.lfxblock.AutoSize = true;
            this.lfxblock.Location = new System.Drawing.Point(40, 46);
            this.lfxblock.Name = "lfxblock";
            this.lfxblock.Size = new System.Drawing.Size(44, 13);
            this.lfxblock.TabIndex = 17;
            this.lfxblock.Text = "fxblock:";
            // 
            // numFxblock
            // 
            this.numFxblock.Location = new System.Drawing.Point(144, 46);
            this.numFxblock.Name = "numFxblock";
            this.numFxblock.Size = new System.Drawing.Size(120, 20);
            this.numFxblock.TabIndex = 18;
            // 
            // numAttack
            // 
            this.numAttack.Location = new System.Drawing.Point(144, 72);
            this.numAttack.Name = "numAttack";
            this.numAttack.Size = new System.Drawing.Size(120, 20);
            this.numAttack.TabIndex = 19;
            // 
            // lAttack
            // 
            this.lAttack.AutoSize = true;
            this.lAttack.Location = new System.Drawing.Point(40, 72);
            this.lAttack.Name = "lAttack";
            this.lAttack.Size = new System.Drawing.Size(40, 13);
            this.lAttack.TabIndex = 20;
            this.lAttack.Text = "attack:";
            // 
            // chOn
            // 
            this.chOn.AutoSize = true;
            this.chOn.Location = new System.Drawing.Point(43, 90);
            this.chOn.Name = "chOn";
            this.chOn.Size = new System.Drawing.Size(38, 17);
            this.chOn.TabIndex = 21;
            this.chOn.Text = "on";
            this.chOn.UseVisualStyleBackColor = true;
            // 
            // numRelease
            // 
            this.numRelease.Location = new System.Drawing.Point(144, 117);
            this.numRelease.Name = "numRelease";
            this.numRelease.Size = new System.Drawing.Size(120, 20);
            this.numRelease.TabIndex = 22;
            // 
            // lRelease
            // 
            this.lRelease.AutoSize = true;
            this.lRelease.Location = new System.Drawing.Point(40, 119);
            this.lRelease.Name = "lRelease";
            this.lRelease.Size = new System.Drawing.Size(44, 13);
            this.lRelease.TabIndex = 23;
            this.lRelease.Text = "release:";
            // 
            // numThreshold
            // 
            this.numThreshold.Location = new System.Drawing.Point(144, 143);
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(120, 20);
            this.numThreshold.TabIndex = 24;
            // 
            // lThreshold
            // 
            this.lThreshold.AutoSize = true;
            this.lThreshold.Location = new System.Drawing.Point(40, 145);
            this.lThreshold.Name = "lThreshold";
            this.lThreshold.Size = new System.Drawing.Size(53, 13);
            this.lThreshold.TabIndex = 25;
            this.lThreshold.Text = "threshold:";
            // 
            // numRatio
            // 
            this.numRatio.Location = new System.Drawing.Point(144, 169);
            this.numRatio.Name = "numRatio";
            this.numRatio.Size = new System.Drawing.Size(120, 20);
            this.numRatio.TabIndex = 26;
            this.numRatio.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // lRatio
            // 
            this.lRatio.AutoSize = true;
            this.lRatio.Location = new System.Drawing.Point(40, 171);
            this.lRatio.Name = "lRatio";
            this.lRatio.Size = new System.Drawing.Size(30, 13);
            this.lRatio.TabIndex = 27;
            this.lRatio.Text = "ratio:";
            // 
            // numBoost
            // 
            this.numBoost.Location = new System.Drawing.Point(144, 195);
            this.numBoost.Name = "numBoost";
            this.numBoost.Size = new System.Drawing.Size(120, 20);
            this.numBoost.TabIndex = 28;
            // 
            // lBoost
            // 
            this.lBoost.AutoSize = true;
            this.lBoost.Location = new System.Drawing.Point(40, 197);
            this.lBoost.Name = "lBoost";
            this.lBoost.Size = new System.Drawing.Size(36, 13);
            this.lBoost.TabIndex = 29;
            this.lBoost.Text = "boost:";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(144, 221);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown7.TabIndex = 30;
            // 
            // LKnee
            // 
            this.LKnee.AutoSize = true;
            this.LKnee.Location = new System.Drawing.Point(40, 223);
            this.LKnee.Name = "LKnee";
            this.LKnee.Size = new System.Drawing.Size(34, 13);
            this.LKnee.TabIndex = 31;
            this.LKnee.Text = "knee:";
            // 
            // CompressionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 326);
            this.Controls.Add(this.LKnee);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.lBoost);
            this.Controls.Add(this.numBoost);
            this.Controls.Add(this.lRatio);
            this.Controls.Add(this.numRatio);
            this.Controls.Add(this.lThreshold);
            this.Controls.Add(this.numThreshold);
            this.Controls.Add(this.lRelease);
            this.Controls.Add(this.numRelease);
            this.Controls.Add(this.chOn);
            this.Controls.Add(this.lAttack);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.numFxblock);
            this.Controls.Add(this.lfxblock);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompressionEdit";
            this.Text = "Compression Edit...";
            ((System.ComponentModel.ISupportInitialize)(this.numFxblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Label lfxblock;
        private System.Windows.Forms.NumericUpDown numFxblock;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.Label lAttack;
        private System.Windows.Forms.CheckBox chOn;
        private System.Windows.Forms.NumericUpDown numRelease;
        private System.Windows.Forms.Label lRelease;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label lThreshold;
        private System.Windows.Forms.NumericUpDown numRatio;
        private System.Windows.Forms.Label lRatio;
        private System.Windows.Forms.NumericUpDown numBoost;
        private System.Windows.Forms.Label lBoost;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label LKnee;
    }
}