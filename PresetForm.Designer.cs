namespace KitaraPresetsCreator
{
    partial class PresetForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Volume");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Master", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("String #0");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("String #1");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("String #2");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("String #3");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("String #4");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("String #5");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Tuning", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Channel #0");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Channel #1");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Channel #2");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Channel #3");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Channel #4");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Channel #5");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("MidiOutChannel", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Equalizer");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Reverberation");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Distortion");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Modulation");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Compression");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Delay");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Mixer");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Voice");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Control");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Preset", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode35,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetForm));
            this.contextMenuPresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditCurrentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReverb = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDistiortion = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDelay = new System.Windows.Forms.ToolStripMenuItem();
            this.AddControl = new System.Windows.Forms.ToolStripMenuItem();
            this.AddModulation = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMixer = new System.Windows.Forms.ToolStripMenuItem();
            this.addControlToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCurrentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSetPresets = new System.Data.DataSet();
            this.tEqualizer = new System.Data.DataTable();
            this.tReverberation = new System.Data.DataTable();
            this.rType = new System.Data.DataColumn();
            this.rPre_lpf = new System.Data.DataColumn();
            this.rLevel = new System.Data.DataColumn();
            this.rTime = new System.Data.DataColumn();
            this.rDelayFeedback = new System.Data.DataColumn();
            this.tag = new System.Data.DataColumn();
            this.pRreDelayTime = new System.Data.DataColumn();
            this.tMixer = new System.Data.DataTable();
            this.tDelay = new System.Data.DataTable();
            this.tDistortion = new System.Data.DataTable();
            this.tTuning = new System.Data.DataTable();
            this.tMidiOutChannel = new System.Data.DataTable();
            this.tModulation = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.tVoice = new System.Data.DataTable();
            this.tControl = new System.Data.DataTable();
            this.tabPresetPage = new System.Windows.Forms.TabPage();
            this.XMLTextBox = new System.Windows.Forms.RichTextBox();
            this.treeViewXML = new System.Windows.Forms.TreeView();
            this.tabPreset = new System.Windows.Forms.TabControl();
            this.contextMenuPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPresets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEqualizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tReverberation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMixer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDistortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTuning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMidiOutChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tControl)).BeginInit();
            this.tabPresetPage.SuspendLayout();
            this.tabPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuPresets
            // 
            this.contextMenuPresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCurrentProperty,
            this.addToolStripMenuItem,
            this.RemoveCurrentProperty});
            this.contextMenuPresets.Name = "contextMenuPresets";
            this.contextMenuPresets.Size = new System.Drawing.Size(215, 70);
            // 
            // EditCurrentProperty
            // 
            this.EditCurrentProperty.Name = "EditCurrentProperty";
            this.EditCurrentProperty.Size = new System.Drawing.Size(214, 22);
            this.EditCurrentProperty.Text = "Edit Current Property...";
            this.EditCurrentProperty.Click += new System.EventHandler(this.EditCurrentProperty_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddReverb,
            this.AddCompression,
            this.AddDistiortion,
            this.AddDelay,
            this.AddControl,
            this.AddModulation,
            this.AddMixer,
            this.addControlToolStripMenuItem2});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addToolStripMenuItem.Text = "Add..";
            // 
            // AddReverb
            // 
            this.AddReverb.Name = "AddReverb";
            this.AddReverb.Size = new System.Drawing.Size(181, 22);
            this.AddReverb.Text = "Add Reverberation...";
            this.AddReverb.Click += new System.EventHandler(this.AddReverb_Click);
            // 
            // AddCompression
            // 
            this.AddCompression.Name = "AddCompression";
            this.AddCompression.Size = new System.Drawing.Size(181, 22);
            this.AddCompression.Text = "Add Compression...";
            this.AddCompression.Click += new System.EventHandler(this.addCompressionToolStripMenuItem1_Click);
            // 
            // AddDistiortion
            // 
            this.AddDistiortion.Name = "AddDistiortion";
            this.AddDistiortion.Size = new System.Drawing.Size(181, 22);
            this.AddDistiortion.Text = "Add Distortion...";
            // 
            // AddDelay
            // 
            this.AddDelay.Name = "AddDelay";
            this.AddDelay.Size = new System.Drawing.Size(181, 22);
            this.AddDelay.Text = "Add Delay...";
            // 
            // AddControl
            // 
            this.AddControl.Name = "AddControl";
            this.AddControl.Size = new System.Drawing.Size(181, 22);
            this.AddControl.Text = "Add Control...";
            // 
            // AddModulation
            // 
            this.AddModulation.Name = "AddModulation";
            this.AddModulation.Size = new System.Drawing.Size(181, 22);
            this.AddModulation.Text = "Add Modulation...";
            // 
            // AddMixer
            // 
            this.AddMixer.Name = "AddMixer";
            this.AddMixer.Size = new System.Drawing.Size(181, 22);
            this.AddMixer.Text = "Add Mixer...";
            // 
            // addControlToolStripMenuItem2
            // 
            this.addControlToolStripMenuItem2.Name = "addControlToolStripMenuItem2";
            this.addControlToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.addControlToolStripMenuItem2.Text = "Add Control...";
            // 
            // RemoveCurrentProperty
            // 
            this.RemoveCurrentProperty.Name = "RemoveCurrentProperty";
            this.RemoveCurrentProperty.Size = new System.Drawing.Size(214, 22);
            this.RemoveCurrentProperty.Text = "Remove Current Property..";
            this.RemoveCurrentProperty.Click += new System.EventHandler(this.RemoveCurrentProperty_Click);
            // 
            // dataSetPresets
            // 
            this.dataSetPresets.CaseSensitive = true;
            this.dataSetPresets.DataSetName = "PresetsDataSet";
            this.dataSetPresets.Locale = new System.Globalization.CultureInfo("en");
            this.dataSetPresets.Tables.AddRange(new System.Data.DataTable[] {
            this.tEqualizer,
            this.tReverberation,
            this.tMixer,
            this.tDelay,
            this.tDistortion,
            this.tTuning,
            this.tMidiOutChannel,
            this.tModulation,
            this.tVoice,
            this.tControl});
            // 
            // tEqualizer
            // 
            this.tEqualizer.TableName = "tEqualizer";
            // 
            // tReverberation
            // 
            this.tReverberation.Columns.AddRange(new System.Data.DataColumn[] {
            this.rType,
            this.rPre_lpf,
            this.rLevel,
            this.rTime,
            this.rDelayFeedback,
            this.tag,
            this.pRreDelayTime});
            this.tReverberation.TableName = "tReverberation";
            // 
            // rType
            // 
            this.rType.AllowDBNull = false;
            this.rType.Caption = "rType";
            this.rType.ColumnName = "rType";
            this.rType.DataType = typeof(decimal);
            this.rType.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // rPre_lpf
            // 
            this.rPre_lpf.AllowDBNull = false;
            this.rPre_lpf.Caption = "rPre_lpf";
            this.rPre_lpf.ColumnName = "rPre_lpf";
            this.rPre_lpf.DataType = typeof(decimal);
            this.rPre_lpf.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // rLevel
            // 
            this.rLevel.AllowDBNull = false;
            this.rLevel.Caption = "rLevel";
            this.rLevel.ColumnName = "rLevel";
            this.rLevel.DataType = typeof(decimal);
            this.rLevel.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // rTime
            // 
            this.rTime.AllowDBNull = false;
            this.rTime.Caption = "rTime";
            this.rTime.ColumnName = "rTime";
            this.rTime.DataType = typeof(decimal);
            this.rTime.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // rDelayFeedback
            // 
            this.rDelayFeedback.AllowDBNull = false;
            this.rDelayFeedback.Caption = "rDelayFeedback";
            this.rDelayFeedback.ColumnName = "rDelayFeedback";
            this.rDelayFeedback.DataType = typeof(decimal);
            this.rDelayFeedback.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tag
            // 
            this.tag.Caption = "tag";
            this.tag.ColumnName = "tag";
            // 
            // pRreDelayTime
            // 
            this.pRreDelayTime.AllowDBNull = false;
            this.pRreDelayTime.Caption = "pRreDelayTime";
            this.pRreDelayTime.ColumnName = "pRreDelayTime";
            this.pRreDelayTime.DataType = typeof(decimal);
            this.pRreDelayTime.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tMixer
            // 
            this.tMixer.TableName = "tMixer";
            // 
            // tDelay
            // 
            this.tDelay.TableName = "tDelay";
            // 
            // tDistortion
            // 
            this.tDistortion.TableName = "tDistortion";
            // 
            // tTuning
            // 
            this.tTuning.TableName = "tTuning";
            // 
            // tMidiOutChannel
            // 
            this.tMidiOutChannel.TableName = "tMidiOutChannel";
            // 
            // tModulation
            // 
            this.tModulation.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.tModulation.TableName = "tModulation";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "rType";
            this.dataColumn1.DataType = typeof(sbyte);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "rPre_lpf";
            this.dataColumn2.DataType = typeof(sbyte);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "rLevel";
            this.dataColumn3.DataType = typeof(sbyte);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "rTime";
            this.dataColumn4.ColumnName = "rTime";
            this.dataColumn4.DataType = typeof(sbyte);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "rDelayFeedback";
            this.dataColumn5.DataType = typeof(sbyte);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "rPreDelayTime";
            this.dataColumn6.DataType = typeof(sbyte);
            // 
            // tVoice
            // 
            this.tVoice.TableName = "tVoice";
            // 
            // tControl
            // 
            this.tControl.TableName = "tControl";
            // 
            // tabPresetPage
            // 
            this.tabPresetPage.Controls.Add(this.XMLTextBox);
            this.tabPresetPage.Controls.Add(this.treeViewXML);
            this.tabPresetPage.Location = new System.Drawing.Point(4, 22);
            this.tabPresetPage.Name = "tabPresetPage";
            this.tabPresetPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPresetPage.Size = new System.Drawing.Size(797, 425);
            this.tabPresetPage.TabIndex = 0;
            this.tabPresetPage.Text = "Preset";
            this.tabPresetPage.UseVisualStyleBackColor = true;
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.AcceptsTab = true;
            this.XMLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XMLTextBox.Enabled = false;
            this.XMLTextBox.Location = new System.Drawing.Point(245, 0);
            this.XMLTextBox.Name = "XMLTextBox";
            this.XMLTextBox.Size = new System.Drawing.Size(549, 425);
            this.XMLTextBox.TabIndex = 1;
            this.XMLTextBox.Text = "";
            // 
            // treeViewXML
            // 
            this.treeViewXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewXML.ContextMenuStrip = this.contextMenuPresets;
            this.treeViewXML.FullRowSelect = true;
            this.treeViewXML.LabelEdit = true;
            this.treeViewXML.Location = new System.Drawing.Point(3, 0);
            this.treeViewXML.Name = "treeViewXML";
            treeNode27.Name = "nodeMasterVolume";
            treeNode27.Tag = "Volume";
            treeNode27.Text = "Volume";
            treeNode28.Name = "nodeMaster";
            treeNode28.Tag = "Master";
            treeNode28.Text = "Master";
            treeNode29.Name = "nodeString0";
            treeNode29.Tag = "t1";
            treeNode29.Text = "String #0";
            treeNode30.Name = "nodeString1";
            treeNode30.Tag = "t2";
            treeNode30.Text = "String #1";
            treeNode31.Name = "nodeString2";
            treeNode31.Tag = "t3";
            treeNode31.Text = "String #2";
            treeNode32.Name = "nodeString3";
            treeNode32.Tag = "t4";
            treeNode32.Text = "String #3";
            treeNode33.Name = "nodeString4";
            treeNode33.Tag = "t5";
            treeNode33.Text = "String #4";
            treeNode34.Name = "nodeString5";
            treeNode34.Tag = "6";
            treeNode34.Text = "String #5";
            treeNode35.Name = "nodeTuning";
            treeNode35.Tag = "Tuning";
            treeNode35.Text = "Tuning";
            treeNode36.Name = "nodeChannel0";
            treeNode36.Tag = "ch1";
            treeNode36.Text = "Channel #0";
            treeNode37.Name = "nodeChannel1";
            treeNode37.Tag = "ch2";
            treeNode37.Text = "Channel #1";
            treeNode38.Name = "nodeChannel2";
            treeNode38.Tag = "ch3";
            treeNode38.Text = "Channel #2";
            treeNode39.Name = "nodeChannel3";
            treeNode39.Tag = "ch4";
            treeNode39.Text = "Channel #3";
            treeNode40.Name = "nodeChannel4";
            treeNode40.Tag = "ch5";
            treeNode40.Text = "Channel #4";
            treeNode41.Name = "nodeChannel5";
            treeNode41.Tag = "ch6";
            treeNode41.Text = "Channel #5";
            treeNode42.Name = "nodeMidiOutChannel";
            treeNode42.Tag = "MidiOutChannel";
            treeNode42.Text = "MidiOutChannel";
            treeNode43.Name = "nodeEqualizer";
            treeNode43.Tag = "Equalizer";
            treeNode43.Text = "Equalizer";
            treeNode44.Name = "nodeReverb";
            treeNode44.Tag = "Reverberation";
            treeNode44.Text = "Reverberation";
            treeNode45.Name = "nodeDistortion";
            treeNode45.Tag = "Distortion";
            treeNode45.Text = "Distortion";
            treeNode46.Name = "nodeModulation";
            treeNode46.Tag = "Modulation";
            treeNode46.Text = "Modulation";
            treeNode47.Name = "nodeCompression";
            treeNode47.Tag = "Compression";
            treeNode47.Text = "Compression";
            treeNode48.Name = "nodeDelay";
            treeNode48.Tag = "Delay";
            treeNode48.Text = "Delay";
            treeNode49.Name = "nodeMixer";
            treeNode49.Tag = "Mixer";
            treeNode49.Text = "Mixer";
            treeNode50.Name = "nodeVoice";
            treeNode50.Tag = "Voice";
            treeNode50.Text = "Voice";
            treeNode51.Name = "nodeControl";
            treeNode51.Tag = "Control";
            treeNode51.Text = "Control";
            treeNode52.Name = "rootPreset";
            treeNode52.Tag = "Preset";
            treeNode52.Text = "Preset";
            this.treeViewXML.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52});
            this.treeViewXML.ShowNodeToolTips = true;
            this.treeViewXML.Size = new System.Drawing.Size(236, 425);
            this.treeViewXML.TabIndex = 0;
            this.treeViewXML.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewXML_BeforeLabelEdit);
            // 
            // tabPreset
            // 
            this.tabPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPreset.Controls.Add(this.tabPresetPage);
            this.tabPreset.Location = new System.Drawing.Point(-5, 0);
            this.tabPreset.Name = "tabPreset";
            this.tabPreset.SelectedIndex = 0;
            this.tabPreset.Size = new System.Drawing.Size(805, 451);
            this.tabPreset.TabIndex = 0;
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPreset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PresetForm";
            this.Text = "New Preset...";
            this.Load += new System.EventHandler(this.PresetForm_Load);
            this.contextMenuPresets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPresets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEqualizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tReverberation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMixer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDistortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTuning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMidiOutChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tControl)).EndInit();
            this.tabPresetPage.ResumeLayout(false);
            this.tabPreset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuPresets;
        private System.Windows.Forms.ToolStripMenuItem EditCurrentProperty;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddReverb;
        private System.Windows.Forms.ToolStripMenuItem AddCompression;
        private System.Windows.Forms.ToolStripMenuItem AddDistiortion;
        private System.Windows.Forms.ToolStripMenuItem AddDelay;
        private System.Windows.Forms.ToolStripMenuItem AddControl;
        private System.Windows.Forms.ToolStripMenuItem AddModulation;
        private System.Windows.Forms.ToolStripMenuItem AddMixer;
        private System.Windows.Forms.ToolStripMenuItem addControlToolStripMenuItem2;
        private System.Data.DataSet dataSetPresets;
        private System.Data.DataTable tEqualizer;
        private System.Windows.Forms.ToolStripMenuItem RemoveCurrentProperty;
        private System.Data.DataTable tReverberation;
        private System.Windows.Forms.TabPage tabPresetPage;
        private System.Windows.Forms.RichTextBox XMLTextBox;
        private System.Windows.Forms.TreeView treeViewXML;
        private System.Windows.Forms.TabControl tabPreset;
        private System.Data.DataTable tMixer;
        private System.Data.DataTable tDelay;
        private System.Data.DataTable tDistortion;
        private System.Data.DataTable tTuning;
        private System.Data.DataTable tMidiOutChannel;
        private System.Data.DataTable tModulation;
        private System.Data.DataTable tVoice;
        private System.Data.DataTable tControl;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn rType;
        private System.Data.DataColumn rPre_lpf;
        private System.Data.DataColumn rLevel;
        private System.Data.DataColumn rTime;
        private System.Data.DataColumn rDelayFeedback;
        private System.Data.DataColumn tag;
        private System.Data.DataColumn pRreDelayTime;
    }
}