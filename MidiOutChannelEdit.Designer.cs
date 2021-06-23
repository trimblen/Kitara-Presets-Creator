namespace KitaraPresetsCreator
{
    partial class MidiOutChannelEdit
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
            this.lMidiOut = new System.Windows.Forms.NumericUpDown();
            this.lValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lMidiOut)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(82, 48);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(226, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            // 
            // lMidiOut
            // 
            this.lMidiOut.Location = new System.Drawing.Point(188, 12);
            this.lMidiOut.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.lMidiOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.lMidiOut.Name = "lMidiOut";
            this.lMidiOut.Size = new System.Drawing.Size(120, 20);
            this.lMidiOut.TabIndex = 17;
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(79, 14);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(37, 13);
            this.lValue.TabIndex = 18;
            this.lValue.Text = "Value:";
            // 
            // MidiOutChannelEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 87);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lMidiOut);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MidiOutChannelEdit";
            this.Text = "MidiOutChannel Edit...";
            ((System.ComponentModel.ISupportInitialize)(this.lMidiOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.NumericUpDown lMidiOut;
        private System.Windows.Forms.Label lValue;
    }
}