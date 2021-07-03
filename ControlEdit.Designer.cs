namespace KitaraPresetsCreator
{
    partial class ControlEdit
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
            this.numType = new System.Windows.Forms.NumericUpDown();
            this.lType = new System.Windows.Forms.Label();
            this.numName = new System.Windows.Forms.NumericUpDown();
            this.LName = new System.Windows.Forms.Label();
            this.numString = new System.Windows.Forms.NumericUpDown();
            this.LString = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.LIndex = new System.Windows.Forms.Label();
            this.numOutput = new System.Windows.Forms.NumericUpDown();
            this.LOutput = new System.Windows.Forms.Label();
            this.numChannel = new System.Windows.Forms.NumericUpDown();
            this.LChannel = new System.Windows.Forms.Label();
            this.LCc = new System.Windows.Forms.Label();
            this.numCc = new System.Windows.Forms.NumericUpDown();
            this.LInverse = new System.Windows.Forms.Label();
            this.numInverse = new System.Windows.Forms.NumericUpDown();
            this.LVariationStart = new System.Windows.Forms.Label();
            this.numVariation_start = new System.Windows.Forms.NumericUpDown();
            this.LVariationEnd = new System.Windows.Forms.Label();
            this.numVariation_end = new System.Windows.Forms.NumericUpDown();
            this.LFxb = new System.Windows.Forms.Label();
            this.numFxb = new System.Windows.Forms.NumericUpDown();
            this.LDrag_center = new System.Windows.Forms.Label();
            this.numDrag_center = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariation_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariation_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrag_center)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(191, 220);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(191, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // numType
            // 
            this.numType.Location = new System.Drawing.Point(130, 35);
            this.numType.Name = "numType";
            this.numType.Size = new System.Drawing.Size(120, 20);
            this.numType.TabIndex = 17;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(48, 37);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(30, 13);
            this.lType.TabIndex = 18;
            this.lType.Text = "type:";
            // 
            // numName
            // 
            this.numName.Location = new System.Drawing.Point(130, 61);
            this.numName.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numName.Name = "numName";
            this.numName.Size = new System.Drawing.Size(120, 20);
            this.numName.TabIndex = 19;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(48, 63);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(36, 13);
            this.LName.TabIndex = 20;
            this.LName.Text = "name:";
            // 
            // numString
            // 
            this.numString.Location = new System.Drawing.Point(130, 87);
            this.numString.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numString.Name = "numString";
            this.numString.Size = new System.Drawing.Size(120, 20);
            this.numString.TabIndex = 21;
            // 
            // LString
            // 
            this.LString.AutoSize = true;
            this.LString.Location = new System.Drawing.Point(47, 89);
            this.LString.Name = "LString";
            this.LString.Size = new System.Drawing.Size(35, 13);
            this.LString.TabIndex = 22;
            this.LString.Text = "string:";
            // 
            // numIndex
            // 
            this.numIndex.Location = new System.Drawing.Point(130, 113);
            this.numIndex.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(120, 20);
            this.numIndex.TabIndex = 23;
            // 
            // LIndex
            // 
            this.LIndex.AutoSize = true;
            this.LIndex.Location = new System.Drawing.Point(48, 116);
            this.LIndex.Name = "LIndex";
            this.LIndex.Size = new System.Drawing.Size(35, 13);
            this.LIndex.TabIndex = 24;
            this.LIndex.Text = "index:";
            // 
            // numOutput
            // 
            this.numOutput.Location = new System.Drawing.Point(130, 139);
            this.numOutput.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numOutput.Name = "numOutput";
            this.numOutput.Size = new System.Drawing.Size(120, 20);
            this.numOutput.TabIndex = 25;
            // 
            // LOutput
            // 
            this.LOutput.AutoSize = true;
            this.LOutput.Location = new System.Drawing.Point(48, 141);
            this.LOutput.Name = "LOutput";
            this.LOutput.Size = new System.Drawing.Size(40, 13);
            this.LOutput.TabIndex = 26;
            this.LOutput.Text = "output:";
            // 
            // numChannel
            // 
            this.numChannel.Location = new System.Drawing.Point(130, 165);
            this.numChannel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numChannel.Name = "numChannel";
            this.numChannel.Size = new System.Drawing.Size(120, 20);
            this.numChannel.TabIndex = 27;
            // 
            // LChannel
            // 
            this.LChannel.AutoSize = true;
            this.LChannel.Location = new System.Drawing.Point(48, 167);
            this.LChannel.Name = "LChannel";
            this.LChannel.Size = new System.Drawing.Size(48, 13);
            this.LChannel.TabIndex = 28;
            this.LChannel.Text = "channel:";
            // 
            // LCc
            // 
            this.LCc.AutoSize = true;
            this.LCc.Location = new System.Drawing.Point(306, 39);
            this.LCc.Name = "LCc";
            this.LCc.Size = new System.Drawing.Size(22, 13);
            this.LCc.TabIndex = 30;
            this.LCc.Text = "cc:";
            // 
            // numCc
            // 
            this.numCc.Location = new System.Drawing.Point(388, 37);
            this.numCc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numCc.Name = "numCc";
            this.numCc.Size = new System.Drawing.Size(120, 20);
            this.numCc.TabIndex = 29;
            // 
            // LInverse
            // 
            this.LInverse.AutoSize = true;
            this.LInverse.Location = new System.Drawing.Point(306, 65);
            this.LInverse.Name = "LInverse";
            this.LInverse.Size = new System.Drawing.Size(44, 13);
            this.LInverse.TabIndex = 32;
            this.LInverse.Text = "inverse:";
            // 
            // numInverse
            // 
            this.numInverse.Location = new System.Drawing.Point(388, 63);
            this.numInverse.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numInverse.Name = "numInverse";
            this.numInverse.Size = new System.Drawing.Size(120, 20);
            this.numInverse.TabIndex = 31;
            // 
            // LVariationStart
            // 
            this.LVariationStart.AutoSize = true;
            this.LVariationStart.Location = new System.Drawing.Point(306, 91);
            this.LVariationStart.Name = "LVariationStart";
            this.LVariationStart.Size = new System.Drawing.Size(76, 13);
            this.LVariationStart.TabIndex = 34;
            this.LVariationStart.Text = "variation_start:";
            // 
            // numVariation_start
            // 
            this.numVariation_start.Location = new System.Drawing.Point(388, 89);
            this.numVariation_start.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numVariation_start.Name = "numVariation_start";
            this.numVariation_start.Size = new System.Drawing.Size(120, 20);
            this.numVariation_start.TabIndex = 33;
            // 
            // LVariationEnd
            // 
            this.LVariationEnd.AutoSize = true;
            this.LVariationEnd.Location = new System.Drawing.Point(308, 118);
            this.LVariationEnd.Name = "LVariationEnd";
            this.LVariationEnd.Size = new System.Drawing.Size(74, 13);
            this.LVariationEnd.TabIndex = 36;
            this.LVariationEnd.Text = "variation_end:";
            // 
            // numVariation_end
            // 
            this.numVariation_end.Location = new System.Drawing.Point(388, 116);
            this.numVariation_end.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numVariation_end.Name = "numVariation_end";
            this.numVariation_end.Size = new System.Drawing.Size(120, 20);
            this.numVariation_end.TabIndex = 35;
            // 
            // LFxb
            // 
            this.LFxb.AutoSize = true;
            this.LFxb.Location = new System.Drawing.Point(308, 144);
            this.LFxb.Name = "LFxb";
            this.LFxb.Size = new System.Drawing.Size(24, 13);
            this.LFxb.TabIndex = 38;
            this.LFxb.Text = "fxb:";
            // 
            // numFxb
            // 
            this.numFxb.Location = new System.Drawing.Point(388, 142);
            this.numFxb.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numFxb.Name = "numFxb";
            this.numFxb.Size = new System.Drawing.Size(120, 20);
            this.numFxb.TabIndex = 37;
            // 
            // LDrag_center
            // 
            this.LDrag_center.AutoSize = true;
            this.LDrag_center.Location = new System.Drawing.Point(306, 172);
            this.LDrag_center.Name = "LDrag_center";
            this.LDrag_center.Size = new System.Drawing.Size(67, 13);
            this.LDrag_center.TabIndex = 40;
            this.LDrag_center.Text = "drag_center:";
            // 
            // numDrag_center
            // 
            this.numDrag_center.Location = new System.Drawing.Point(388, 168);
            this.numDrag_center.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numDrag_center.Name = "numDrag_center";
            this.numDrag_center.Size = new System.Drawing.Size(120, 20);
            this.numDrag_center.TabIndex = 39;
            // 
            // ControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 271);
            this.Controls.Add(this.LDrag_center);
            this.Controls.Add(this.numDrag_center);
            this.Controls.Add(this.LFxb);
            this.Controls.Add(this.numFxb);
            this.Controls.Add(this.LVariationEnd);
            this.Controls.Add(this.numVariation_end);
            this.Controls.Add(this.LVariationStart);
            this.Controls.Add(this.numVariation_start);
            this.Controls.Add(this.LInverse);
            this.Controls.Add(this.numInverse);
            this.Controls.Add(this.LCc);
            this.Controls.Add(this.numCc);
            this.Controls.Add(this.LChannel);
            this.Controls.Add(this.numChannel);
            this.Controls.Add(this.LOutput);
            this.Controls.Add(this.numOutput);
            this.Controls.Add(this.LIndex);
            this.Controls.Add(this.numIndex);
            this.Controls.Add(this.LString);
            this.Controls.Add(this.numString);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.numName);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.numType);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ControlEdit";
            this.Text = "Control Edit...";
            this.Load += new System.EventHandler(this.ControlEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariation_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariation_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrag_center)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.NumericUpDown numType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.NumericUpDown numName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.NumericUpDown numString;
        private System.Windows.Forms.Label LString;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.Label LIndex;
        private System.Windows.Forms.NumericUpDown numOutput;
        private System.Windows.Forms.Label LOutput;
        private System.Windows.Forms.NumericUpDown numChannel;
        private System.Windows.Forms.Label LChannel;
        private System.Windows.Forms.Label LCc;
        private System.Windows.Forms.NumericUpDown numCc;
        private System.Windows.Forms.Label LInverse;
        private System.Windows.Forms.NumericUpDown numInverse;
        private System.Windows.Forms.Label LVariationStart;
        private System.Windows.Forms.NumericUpDown numVariation_start;
        private System.Windows.Forms.Label LVariationEnd;
        private System.Windows.Forms.NumericUpDown numVariation_end;
        private System.Windows.Forms.Label LFxb;
        private System.Windows.Forms.NumericUpDown numFxb;
        private System.Windows.Forms.Label LDrag_center;
        private System.Windows.Forms.NumericUpDown numDrag_center;
    }
}