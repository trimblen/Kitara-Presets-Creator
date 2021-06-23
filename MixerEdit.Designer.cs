namespace KitaraPresetsCreator
{
    partial class MixerEdit
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
            this.numfxblock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.llowCutFilterFrequency = new System.Windows.Forms.Label();
            this.numLowCutFilterLrequency = new System.Windows.Forms.NumericUpDown();
            this.numHighCutFilterFrequency = new System.Windows.Forms.NumericUpDown();
            this.High_cut_filter_frequency = new System.Windows.Forms.Label();
            this.numInputGain = new System.Windows.Forms.NumericUpDown();
            this.LInput_gain = new System.Windows.Forms.Label();
            this.numOutputLevel = new System.Windows.Forms.NumericUpDown();
            this.numPan = new System.Windows.Forms.NumericUpDown();
            this.numReverbSend = new System.Windows.Forms.NumericUpDown();
            this.Loutput_level = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LReverb_send = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numfxblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowCutFilterLrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighCutFilterFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReverbSend)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(45, 221);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(265, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            // 
            // numfxblock
            // 
            this.numfxblock.Location = new System.Drawing.Point(190, 24);
            this.numfxblock.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numfxblock.Name = "numfxblock";
            this.numfxblock.Size = new System.Drawing.Size(120, 20);
            this.numfxblock.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "fxblock:";
            // 
            // llowCutFilterFrequency
            // 
            this.llowCutFilterFrequency.AutoSize = true;
            this.llowCutFilterFrequency.Location = new System.Drawing.Point(42, 52);
            this.llowCutFilterFrequency.Name = "llowCutFilterFrequency";
            this.llowCutFilterFrequency.Size = new System.Drawing.Size(125, 13);
            this.llowCutFilterFrequency.TabIndex = 19;
            this.llowCutFilterFrequency.Text = "low_cut_filter_frequency:";
            // 
            // numLowCutFilterLrequency
            // 
            this.numLowCutFilterLrequency.Location = new System.Drawing.Point(190, 50);
            this.numLowCutFilterLrequency.Name = "numLowCutFilterLrequency";
            this.numLowCutFilterLrequency.Size = new System.Drawing.Size(120, 20);
            this.numLowCutFilterLrequency.TabIndex = 20;
            // 
            // numHighCutFilterFrequency
            // 
            this.numHighCutFilterFrequency.Location = new System.Drawing.Point(190, 76);
            this.numHighCutFilterFrequency.Name = "numHighCutFilterFrequency";
            this.numHighCutFilterFrequency.Size = new System.Drawing.Size(120, 20);
            this.numHighCutFilterFrequency.TabIndex = 21;
            // 
            // High_cut_filter_frequency
            // 
            this.High_cut_filter_frequency.AutoSize = true;
            this.High_cut_filter_frequency.Location = new System.Drawing.Point(42, 78);
            this.High_cut_filter_frequency.Name = "High_cut_filter_frequency";
            this.High_cut_filter_frequency.Size = new System.Drawing.Size(129, 13);
            this.High_cut_filter_frequency.TabIndex = 22;
            this.High_cut_filter_frequency.Text = "high_cut_filter_frequency:";
            // 
            // numInputGain
            // 
            this.numInputGain.Location = new System.Drawing.Point(190, 102);
            this.numInputGain.Name = "numInputGain";
            this.numInputGain.Size = new System.Drawing.Size(120, 20);
            this.numInputGain.TabIndex = 23;
            // 
            // LInput_gain
            // 
            this.LInput_gain.AutoSize = true;
            this.LInput_gain.Location = new System.Drawing.Point(42, 104);
            this.LInput_gain.Name = "LInput_gain";
            this.LInput_gain.Size = new System.Drawing.Size(59, 13);
            this.LInput_gain.TabIndex = 24;
            this.LInput_gain.Text = "input_gain:";
            // 
            // numOutputLevel
            // 
            this.numOutputLevel.Location = new System.Drawing.Point(190, 128);
            this.numOutputLevel.Name = "numOutputLevel";
            this.numOutputLevel.Size = new System.Drawing.Size(120, 20);
            this.numOutputLevel.TabIndex = 25;
            // 
            // numPan
            // 
            this.numPan.Location = new System.Drawing.Point(190, 154);
            this.numPan.Name = "numPan";
            this.numPan.Size = new System.Drawing.Size(120, 20);
            this.numPan.TabIndex = 26;
            // 
            // numReverbSend
            // 
            this.numReverbSend.Location = new System.Drawing.Point(190, 180);
            this.numReverbSend.Name = "numReverbSend";
            this.numReverbSend.Size = new System.Drawing.Size(120, 20);
            this.numReverbSend.TabIndex = 27;
            // 
            // Loutput_level
            // 
            this.Loutput_level.AutoSize = true;
            this.Loutput_level.Location = new System.Drawing.Point(42, 130);
            this.Loutput_level.Name = "Loutput_level";
            this.Loutput_level.Size = new System.Drawing.Size(68, 13);
            this.Loutput_level.TabIndex = 28;
            this.Loutput_level.Text = "output_level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "pan:";
            // 
            // LReverb_send
            // 
            this.LReverb_send.AutoSize = true;
            this.LReverb_send.Location = new System.Drawing.Point(42, 182);
            this.LReverb_send.Name = "LReverb_send";
            this.LReverb_send.Size = new System.Drawing.Size(69, 13);
            this.LReverb_send.TabIndex = 30;
            this.LReverb_send.Text = "reverb_send:";
            // 
            // MixerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 269);
            this.Controls.Add(this.LReverb_send);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Loutput_level);
            this.Controls.Add(this.numReverbSend);
            this.Controls.Add(this.numPan);
            this.Controls.Add(this.numOutputLevel);
            this.Controls.Add(this.LInput_gain);
            this.Controls.Add(this.numInputGain);
            this.Controls.Add(this.High_cut_filter_frequency);
            this.Controls.Add(this.numHighCutFilterFrequency);
            this.Controls.Add(this.numLowCutFilterLrequency);
            this.Controls.Add(this.llowCutFilterFrequency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numfxblock);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MixerEdit";
            this.Text = "Mixer Edit...";
            ((System.ComponentModel.ISupportInitialize)(this.numfxblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLowCutFilterLrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighCutFilterFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReverbSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.NumericUpDown numfxblock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llowCutFilterFrequency;
        private System.Windows.Forms.NumericUpDown numLowCutFilterLrequency;
        private System.Windows.Forms.NumericUpDown numHighCutFilterFrequency;
        private System.Windows.Forms.Label High_cut_filter_frequency;
        private System.Windows.Forms.NumericUpDown numInputGain;
        private System.Windows.Forms.Label LInput_gain;
        private System.Windows.Forms.NumericUpDown numOutputLevel;
        private System.Windows.Forms.NumericUpDown numPan;
        private System.Windows.Forms.NumericUpDown numReverbSend;
        private System.Windows.Forms.Label Loutput_level;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LReverb_send;
    }
}