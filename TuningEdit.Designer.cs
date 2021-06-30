namespace KitaraPresetsCreator
{
    partial class TuningEdit
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
            this.LValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(54, 63);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(159, 23);
            this.buttSave.TabIndex = 16;
            this.buttSave.Text = "Save d&ata...";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // LValue
            // 
            this.LValue.AutoSize = true;
            this.LValue.Location = new System.Drawing.Point(51, 25);
            this.LValue.Name = "LValue";
            this.LValue.Size = new System.Drawing.Size(36, 13);
            this.LValue.TabIndex = 17;
            this.LValue.Text = "value:";
            // 
            // numValue
            // 
            this.numValue.Location = new System.Drawing.Point(93, 23);
            this.numValue.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(120, 20);
            this.numValue.TabIndex = 18;
            // 
            // TuningEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 109);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.LValue);
            this.Controls.Add(this.buttSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TuningEdit";
            this.Text = "Tuning Edit...";
            this.Load += new System.EventHandler(this.TuningEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Label LValue;
        private System.Windows.Forms.NumericUpDown numValue;
    }
}