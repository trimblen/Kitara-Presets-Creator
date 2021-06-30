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
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Volume");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Master", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("String #0");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("String #1");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("String #2");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("String #3");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("String #4");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("String #5");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Tuning", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Channel #0");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Channel #1");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Channel #2");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Channel #3");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Channel #4");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Channel #5");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("MidiOutChannel", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Lowest");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Lower");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Higher");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Highest");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Equalizer", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Reverberation");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Distortion");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Modulation");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Compression");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Delay");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Mixer");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Voice");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Control");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Preset", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode39,
            treeNode46,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59});
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
            this.addVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCurrentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSetPresets = new System.Data.DataSet();
            this.tEqualizer = new System.Data.DataTable();
            this.eqTag = new System.Data.DataColumn();
            this.gain = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.tReverberation = new System.Data.DataTable();
            this.rType = new System.Data.DataColumn();
            this.rPre_lpf = new System.Data.DataColumn();
            this.rLevel = new System.Data.DataColumn();
            this.rTime = new System.Data.DataColumn();
            this.rDelayFeedback = new System.Data.DataColumn();
            this.tag = new System.Data.DataColumn();
            this.pRreDelayTime = new System.Data.DataColumn();
            this.tMixer = new System.Data.DataTable();
            this.tagc = new System.Data.DataColumn();
            this.fxblockm = new System.Data.DataColumn();
            this.ow_cut_filter_frequency = new System.Data.DataColumn();
            this.high_cut_filter_frequencym = new System.Data.DataColumn();
            this.input_gainm = new System.Data.DataColumn();
            this.output_levelm = new System.Data.DataColumn();
            this.pan = new System.Data.DataColumn();
            this.reverb_sendm = new System.Data.DataColumn();
            this.tDelay = new System.Data.DataTable();
            this.tagd = new System.Data.DataColumn();
            this.fxblockd = new System.Data.DataColumn();
            this.ond = new System.Data.DataColumn();
            this.moden = new System.Data.DataColumn();
            this.pre_lp = new System.Data.DataColumn();
            this.levelc = new System.Data.DataColumn();
            this.timen = new System.Data.DataColumn();
            this.feedbackd = new System.Data.DataColumn();
            this.feedback_filter = new System.Data.DataColumn();
            this.tDistortion = new System.Data.DataTable();
            this.dataColumn11 = new System.Data.DataColumn();
            this.fxblock = new System.Data.DataColumn();
            this.on = new System.Data.DataColumn();
            this.dType = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.tone = new System.Data.DataColumn();
            this.booster = new System.Data.DataColumn();
            this.tTuning = new System.Data.DataTable();
            this.tagt = new System.Data.DataColumn();
            this.valued = new System.Data.DataColumn();
            this.tMidiOutChannel = new System.Data.DataTable();
            this.tagmidi = new System.Data.DataColumn();
            this.valuem = new System.Data.DataColumn();
            this.tModulation = new System.Data.DataTable();
            this.tagm = new System.Data.DataColumn();
            this.fxblockmd = new System.Data.DataColumn();
            this.onde = new System.Data.DataColumn();
            this.typem = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.chorus_delay_timede = new System.Data.DataColumn();
            this.chorus_feedbackd = new System.Data.DataColumn();
            this.chorus_hpf = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.rate = new System.Data.DataColumn();
            this.depth = new System.Data.DataColumn();
            this.tremolo = new System.Data.DataColumn();
            this.tVoice = new System.Data.DataTable();
            this.tagcont = new System.Data.DataColumn();
            this.wave_id = new System.Data.DataColumn();
            this.amplitude_attack = new System.Data.DataColumn();
            this.amplitude_decayd = new System.Data.DataColumn();
            this.amplitude_released = new System.Data.DataColumn();
            this.detune_coursec = new System.Data.DataColumn();
            this.detune_fined = new System.Data.DataColumn();
            this.vibrate_rated = new System.Data.DataColumn();
            this.vibrate_depthc = new System.Data.DataColumn();
            this.vibrate_delayc = new System.Data.DataColumn();
            this.channel_volumec = new System.Data.DataColumn();
            this.portamento_timec = new System.Data.DataColumn();
            this.panc = new System.Data.DataColumn();
            this.pitch_bend_semitones = new System.Data.DataColumn();
            this.pitch_wheel = new System.Data.DataColumn();
            this.velocity = new System.Data.DataColumn();
            this.fxb0_on = new System.Data.DataColumn();
            this.fxb1_on = new System.Data.DataColumn();
            this.reverb_send = new System.Data.DataColumn();
            this.filter_frequency = new System.Data.DataColumn();
            this.filter_resonance = new System.Data.DataColumn();
            this.filter_type = new System.Data.DataColumn();
            this.filter_attack = new System.Data.DataColumn();
            this.filter_decay = new System.Data.DataColumn();
            this.filter_release = new System.Data.DataColumn();
            this.stringv = new System.Data.DataColumn();
            this.tControl = new System.Data.DataTable();
            this.tagcon = new System.Data.DataColumn();
            this.typec = new System.Data.DataColumn();
            this.namecs = new System.Data.DataColumn();
            this.stringc = new System.Data.DataColumn();
            this.indexc = new System.Data.DataColumn();
            this.output = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.cc = new System.Data.DataColumn();
            this.inverse = new System.Data.DataColumn();
            this.variation_start = new System.Data.DataColumn();
            this.variation_end = new System.Data.DataColumn();
            this.fxb = new System.Data.DataColumn();
            this.drag_center = new System.Data.DataColumn();
            this.tMaster = new System.Data.DataTable();
            this.rTag = new System.Data.DataColumn();
            this.mVolume = new System.Data.DataColumn();
            this.tEqualizerMain = new System.Data.DataTable();
            this.mvTag = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.tCompression = new System.Data.DataTable();
            this.cthreshold = new System.Data.DataColumn();
            this.cfxblock = new System.Data.DataColumn();
            this.con = new System.Data.DataColumn();
            this.cattack = new System.Data.DataColumn();
            this.crelease = new System.Data.DataColumn();
            this.thresholdc = new System.Data.DataColumn();
            this.cratio = new System.Data.DataColumn();
            this.aboost = new System.Data.DataColumn();
            this.kneec = new System.Data.DataColumn();
            this.tabPresetPage = new System.Windows.Forms.TabPage();
            this.XMLTextBox = new System.Windows.Forms.RichTextBox();
            this.treeViewXML = new System.Windows.Forms.TreeView();
            this.tabPreset = new System.Windows.Forms.TabControl();
            this.sfd_SaveFile = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.tMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEqualizerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompression)).BeginInit();
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
            this.EditCurrentProperty.Text = "Edit Cu&rrent Property...";
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
            this.addVoiceToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addToolStripMenuItem.Text = "Ad&d..";
            // 
            // AddReverb
            // 
            this.AddReverb.Name = "AddReverb";
            this.AddReverb.Size = new System.Drawing.Size(181, 22);
            this.AddReverb.Text = "Add Rev&erberation...";
            this.AddReverb.Click += new System.EventHandler(this.AddReverb_Click);
            // 
            // AddCompression
            // 
            this.AddCompression.Name = "AddCompression";
            this.AddCompression.Size = new System.Drawing.Size(181, 22);
            this.AddCompression.Text = "Add Com&pression...";
            this.AddCompression.Click += new System.EventHandler(this.addCompressionToolStripMenuItem1_Click);
            // 
            // AddDistiortion
            // 
            this.AddDistiortion.Name = "AddDistiortion";
            this.AddDistiortion.Size = new System.Drawing.Size(181, 22);
            this.AddDistiortion.Text = "Add Disto&rtion...";
            this.AddDistiortion.Click += new System.EventHandler(this.AddDistiortion_Click);
            // 
            // AddDelay
            // 
            this.AddDelay.Name = "AddDelay";
            this.AddDelay.Size = new System.Drawing.Size(181, 22);
            this.AddDelay.Text = "Add De&lay...";
            this.AddDelay.Click += new System.EventHandler(this.AddDelay_Click);
            // 
            // AddControl
            // 
            this.AddControl.Name = "AddControl";
            this.AddControl.Size = new System.Drawing.Size(181, 22);
            this.AddControl.Text = "Add Co&ntrol...";
            this.AddControl.Click += new System.EventHandler(this.AddControl_Click);
            // 
            // AddModulation
            // 
            this.AddModulation.Name = "AddModulation";
            this.AddModulation.Size = new System.Drawing.Size(181, 22);
            this.AddModulation.Text = "Add Mo&dulation...";
            this.AddModulation.Click += new System.EventHandler(this.AddModulation_Click);
            // 
            // AddMixer
            // 
            this.AddMixer.Name = "AddMixer";
            this.AddMixer.Size = new System.Drawing.Size(181, 22);
            this.AddMixer.Text = "Add M&ixer...";
            this.AddMixer.Click += new System.EventHandler(this.AddMixer_Click);
            // 
            // addVoiceToolStripMenuItem
            // 
            this.addVoiceToolStripMenuItem.Name = "addVoiceToolStripMenuItem";
            this.addVoiceToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addVoiceToolStripMenuItem.Text = "Add V&oice...";
            this.addVoiceToolStripMenuItem.Click += new System.EventHandler(this.addVoiceToolStripMenuItem_Click);
            // 
            // RemoveCurrentProperty
            // 
            this.RemoveCurrentProperty.Name = "RemoveCurrentProperty";
            this.RemoveCurrentProperty.Size = new System.Drawing.Size(214, 22);
            this.RemoveCurrentProperty.Text = "Remove Curre&nt Property..";
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
            this.tControl,
            this.tMaster,
            this.tEqualizerMain,
            this.tCompression});
            // 
            // tEqualizer
            // 
            this.tEqualizer.Columns.AddRange(new System.Data.DataColumn[] {
            this.eqTag,
            this.gain,
            this.dataColumn10});
            this.tEqualizer.TableName = "tEqualizer";
            // 
            // eqTag
            // 
            this.eqTag.AllowDBNull = false;
            this.eqTag.Caption = "tag";
            this.eqTag.ColumnName = "tag";
            this.eqTag.DefaultValue = "";
            // 
            // gain
            // 
            this.gain.AllowDBNull = false;
            this.gain.Caption = "gain";
            this.gain.ColumnName = "gain";
            this.gain.DataType = typeof(decimal);
            this.gain.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn10
            // 
            this.dataColumn10.AllowDBNull = false;
            this.dataColumn10.Caption = "frequency";
            this.dataColumn10.ColumnName = "frequency";
            this.dataColumn10.DataType = typeof(decimal);
            this.dataColumn10.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.tMixer.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagc,
            this.fxblockm,
            this.ow_cut_filter_frequency,
            this.high_cut_filter_frequencym,
            this.input_gainm,
            this.output_levelm,
            this.pan,
            this.reverb_sendm});
            this.tMixer.TableName = "tMixer";
            // 
            // tagc
            // 
            this.tagc.AllowDBNull = false;
            this.tagc.Caption = "tag";
            this.tagc.ColumnName = "tag";
            this.tagc.DefaultValue = "";
            // 
            // fxblockm
            // 
            this.fxblockm.AllowDBNull = false;
            this.fxblockm.Caption = "fxblock";
            this.fxblockm.ColumnName = "fxblock";
            this.fxblockm.DataType = typeof(decimal);
            this.fxblockm.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ow_cut_filter_frequency
            // 
            this.ow_cut_filter_frequency.AllowDBNull = false;
            this.ow_cut_filter_frequency.Caption = "ow_cut_filter_frequency";
            this.ow_cut_filter_frequency.ColumnName = "ow_cut_filter_frequency";
            this.ow_cut_filter_frequency.DataType = typeof(decimal);
            this.ow_cut_filter_frequency.DefaultValue = "0";
            // 
            // high_cut_filter_frequencym
            // 
            this.high_cut_filter_frequencym.AllowDBNull = false;
            this.high_cut_filter_frequencym.Caption = "high_cut_filter_frequency";
            this.high_cut_filter_frequencym.ColumnName = "high_cut_filter_frequency";
            this.high_cut_filter_frequencym.DataType = typeof(decimal);
            this.high_cut_filter_frequencym.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // input_gainm
            // 
            this.input_gainm.AllowDBNull = false;
            this.input_gainm.Caption = "input_gain";
            this.input_gainm.ColumnName = "input_gain";
            this.input_gainm.DataType = typeof(decimal);
            this.input_gainm.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // output_levelm
            // 
            this.output_levelm.AllowDBNull = false;
            this.output_levelm.Caption = "output_level";
            this.output_levelm.ColumnName = "output_level";
            this.output_levelm.DataType = typeof(decimal);
            this.output_levelm.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pan
            // 
            this.pan.AllowDBNull = false;
            this.pan.Caption = "pan";
            this.pan.ColumnName = "pan";
            this.pan.DataType = typeof(decimal);
            this.pan.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // reverb_sendm
            // 
            this.reverb_sendm.AllowDBNull = false;
            this.reverb_sendm.Caption = "reverb_send";
            this.reverb_sendm.ColumnName = "reverb_send";
            this.reverb_sendm.DataType = typeof(decimal);
            this.reverb_sendm.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tDelay
            // 
            this.tDelay.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagd,
            this.fxblockd,
            this.ond,
            this.moden,
            this.pre_lp,
            this.levelc,
            this.timen,
            this.feedbackd,
            this.feedback_filter});
            this.tDelay.TableName = "tDelay";
            // 
            // tagd
            // 
            this.tagd.AllowDBNull = false;
            this.tagd.Caption = "tag";
            this.tagd.ColumnName = "tag";
            this.tagd.DefaultValue = "0";
            // 
            // fxblockd
            // 
            this.fxblockd.AllowDBNull = false;
            this.fxblockd.Caption = "fxblock";
            this.fxblockd.ColumnName = "fxblock";
            this.fxblockd.DataType = typeof(decimal);
            this.fxblockd.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ond
            // 
            this.ond.AllowDBNull = false;
            this.ond.Caption = "on";
            this.ond.ColumnName = "on";
            this.ond.DataType = typeof(bool);
            this.ond.DefaultValue = false;
            // 
            // moden
            // 
            this.moden.AllowDBNull = false;
            this.moden.Caption = "mode";
            this.moden.ColumnName = "mode";
            this.moden.DataType = typeof(decimal);
            this.moden.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pre_lp
            // 
            this.pre_lp.AllowDBNull = false;
            this.pre_lp.Caption = "pre_lp";
            this.pre_lp.ColumnName = "pre_lp";
            this.pre_lp.DataType = typeof(decimal);
            this.pre_lp.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // levelc
            // 
            this.levelc.AllowDBNull = false;
            this.levelc.Caption = "level";
            this.levelc.ColumnName = "level";
            this.levelc.DataType = typeof(decimal);
            this.levelc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // timen
            // 
            this.timen.AllowDBNull = false;
            this.timen.Caption = "time";
            this.timen.ColumnName = "time";
            this.timen.DataType = typeof(decimal);
            this.timen.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // feedbackd
            // 
            this.feedbackd.AllowDBNull = false;
            this.feedbackd.Caption = "feedback";
            this.feedbackd.ColumnName = "feedback";
            this.feedbackd.DataType = typeof(decimal);
            this.feedbackd.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // feedback_filter
            // 
            this.feedback_filter.AllowDBNull = false;
            this.feedback_filter.Caption = "feedback_filter";
            this.feedback_filter.ColumnName = "feedback_filter";
            this.feedback_filter.DataType = typeof(decimal);
            this.feedback_filter.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tDistortion
            // 
            this.tDistortion.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn11,
            this.fxblock,
            this.on,
            this.dType,
            this.dataColumn12,
            this.dataColumn13,
            this.tone,
            this.booster});
            this.tDistortion.TableName = "tDistortion";
            // 
            // dataColumn11
            // 
            this.dataColumn11.AllowDBNull = false;
            this.dataColumn11.Caption = "tag";
            this.dataColumn11.ColumnName = "tag";
            this.dataColumn11.DefaultValue = "";
            // 
            // fxblock
            // 
            this.fxblock.AllowDBNull = false;
            this.fxblock.Caption = "fxblock";
            this.fxblock.ColumnName = "fxblock";
            this.fxblock.DataType = typeof(decimal);
            this.fxblock.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // on
            // 
            this.on.AllowDBNull = false;
            this.on.Caption = "on";
            this.on.ColumnName = "on";
            this.on.DataType = typeof(bool);
            this.on.DefaultValue = true;
            // 
            // dType
            // 
            this.dType.AllowDBNull = false;
            this.dType.Caption = "type";
            this.dType.ColumnName = "type";
            this.dType.DataType = typeof(decimal);
            this.dType.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn12
            // 
            this.dataColumn12.AllowDBNull = false;
            this.dataColumn12.Caption = "level";
            this.dataColumn12.ColumnName = "level";
            this.dataColumn12.DataType = typeof(decimal);
            this.dataColumn12.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn13
            // 
            this.dataColumn13.AllowDBNull = false;
            this.dataColumn13.Caption = "drive";
            this.dataColumn13.ColumnName = "drive";
            this.dataColumn13.DataType = typeof(decimal);
            this.dataColumn13.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tone
            // 
            this.tone.AllowDBNull = false;
            this.tone.Caption = "tone";
            this.tone.ColumnName = "tone";
            this.tone.DataType = typeof(decimal);
            this.tone.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // booster
            // 
            this.booster.AllowDBNull = false;
            this.booster.Caption = "booster";
            this.booster.ColumnName = "booster";
            this.booster.DataType = typeof(decimal);
            this.booster.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tTuning
            // 
            this.tTuning.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagt,
            this.valued});
            this.tTuning.TableName = "tTuning";
            // 
            // tagt
            // 
            this.tagt.AllowDBNull = false;
            this.tagt.Caption = "tag";
            this.tagt.ColumnName = "tag";
            this.tagt.DataType = typeof(decimal);
            this.tagt.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // valued
            // 
            this.valued.AllowDBNull = false;
            this.valued.Caption = "value";
            this.valued.ColumnName = "value";
            this.valued.DataType = typeof(decimal);
            this.valued.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tMidiOutChannel
            // 
            this.tMidiOutChannel.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagmidi,
            this.valuem});
            this.tMidiOutChannel.TableName = "tMidiOutChannel";
            // 
            // tagmidi
            // 
            this.tagmidi.AllowDBNull = false;
            this.tagmidi.Caption = "tag";
            this.tagmidi.ColumnName = "tag";
            this.tagmidi.DefaultValue = "";
            // 
            // valuem
            // 
            this.valuem.AllowDBNull = false;
            this.valuem.Caption = "value";
            this.valuem.ColumnName = "value";
            this.valuem.DataType = typeof(decimal);
            this.valuem.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tModulation
            // 
            this.tModulation.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagm,
            this.fxblockmd,
            this.onde,
            this.typem,
            this.dataColumn1,
            this.chorus_delay_timede,
            this.chorus_feedbackd,
            this.chorus_hpf,
            this.dataColumn2,
            this.rate,
            this.depth,
            this.tremolo});
            this.tModulation.TableName = "tModulation";
            // 
            // tagm
            // 
            this.tagm.AllowDBNull = false;
            this.tagm.Caption = "tag";
            this.tagm.ColumnName = "tag";
            this.tagm.DefaultValue = "0";
            // 
            // fxblockmd
            // 
            this.fxblockmd.AllowDBNull = false;
            this.fxblockmd.Caption = "fxblock";
            this.fxblockmd.ColumnName = "fxblock";
            this.fxblockmd.DataType = typeof(decimal);
            this.fxblockmd.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // onde
            // 
            this.onde.AllowDBNull = false;
            this.onde.Caption = "on";
            this.onde.ColumnName = "on";
            this.onde.DataType = typeof(bool);
            this.onde.DefaultValue = false;
            // 
            // typem
            // 
            this.typem.AllowDBNull = false;
            this.typem.Caption = "type";
            this.typem.ColumnName = "type";
            this.typem.DataType = typeof(decimal);
            this.typem.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "level";
            this.dataColumn1.ColumnName = "level";
            this.dataColumn1.DataType = typeof(decimal);
            this.dataColumn1.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // chorus_delay_timede
            // 
            this.chorus_delay_timede.AllowDBNull = false;
            this.chorus_delay_timede.Caption = "chorus_delay_time";
            this.chorus_delay_timede.ColumnName = "chorus_delay_time";
            this.chorus_delay_timede.DataType = typeof(decimal);
            // 
            // chorus_feedbackd
            // 
            this.chorus_feedbackd.AllowDBNull = false;
            this.chorus_feedbackd.Caption = "chorus_feedback";
            this.chorus_feedbackd.ColumnName = "chorus_feedback";
            this.chorus_feedbackd.DataType = typeof(decimal);
            this.chorus_feedbackd.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // chorus_hpf
            // 
            this.chorus_hpf.AllowDBNull = false;
            this.chorus_hpf.Caption = "chorus_hpf";
            this.chorus_hpf.ColumnName = "chorus_hpf";
            this.chorus_hpf.DataType = typeof(decimal);
            this.chorus_hpf.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.Caption = "delay_feedback_filter";
            this.dataColumn2.ColumnName = "delay_feedback_filter";
            this.dataColumn2.DataType = typeof(decimal);
            this.dataColumn2.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // rate
            // 
            this.rate.AllowDBNull = false;
            this.rate.Caption = "rate";
            this.rate.ColumnName = "rate";
            this.rate.DataType = typeof(decimal);
            this.rate.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // depth
            // 
            this.depth.AllowDBNull = false;
            this.depth.Caption = "depth";
            this.depth.ColumnName = "depth";
            this.depth.DataType = typeof(decimal);
            this.depth.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tremolo
            // 
            this.tremolo.AllowDBNull = false;
            this.tremolo.Caption = "tremolo";
            this.tremolo.ColumnName = "tremolo";
            this.tremolo.DataType = typeof(decimal);
            this.tremolo.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tVoice
            // 
            this.tVoice.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagcont,
            this.wave_id,
            this.amplitude_attack,
            this.amplitude_decayd,
            this.amplitude_released,
            this.detune_coursec,
            this.detune_fined,
            this.vibrate_rated,
            this.vibrate_depthc,
            this.vibrate_delayc,
            this.channel_volumec,
            this.portamento_timec,
            this.panc,
            this.pitch_bend_semitones,
            this.pitch_wheel,
            this.velocity,
            this.fxb0_on,
            this.fxb1_on,
            this.reverb_send,
            this.filter_frequency,
            this.filter_resonance,
            this.filter_type,
            this.filter_attack,
            this.filter_decay,
            this.filter_release,
            this.stringv});
            this.tVoice.TableName = "tVoice";
            // 
            // tagcont
            // 
            this.tagcont.AllowDBNull = false;
            this.tagcont.Caption = "tag";
            this.tagcont.ColumnName = "tag";
            this.tagcont.DefaultValue = "";
            // 
            // wave_id
            // 
            this.wave_id.AllowDBNull = false;
            this.wave_id.ColumnName = "wave_id";
            this.wave_id.DefaultValue = "";
            // 
            // amplitude_attack
            // 
            this.amplitude_attack.AllowDBNull = false;
            this.amplitude_attack.Caption = "amplitude_attack";
            this.amplitude_attack.ColumnName = "amplitude_attack";
            this.amplitude_attack.DataType = typeof(decimal);
            this.amplitude_attack.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // amplitude_decayd
            // 
            this.amplitude_decayd.AllowDBNull = false;
            this.amplitude_decayd.Caption = "amplitude_decay";
            this.amplitude_decayd.ColumnName = "amplitude_decay";
            this.amplitude_decayd.DataType = typeof(decimal);
            this.amplitude_decayd.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // amplitude_released
            // 
            this.amplitude_released.AllowDBNull = false;
            this.amplitude_released.Caption = "amplitude_release";
            this.amplitude_released.ColumnName = "amplitude_release";
            this.amplitude_released.DataType = typeof(decimal);
            this.amplitude_released.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // detune_coursec
            // 
            this.detune_coursec.AllowDBNull = false;
            this.detune_coursec.Caption = "detune_course";
            this.detune_coursec.ColumnName = "detune_course";
            this.detune_coursec.DataType = typeof(decimal);
            this.detune_coursec.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // detune_fined
            // 
            this.detune_fined.AllowDBNull = false;
            this.detune_fined.Caption = "detune_fine";
            this.detune_fined.ColumnName = "detune_fine";
            this.detune_fined.DataType = typeof(decimal);
            this.detune_fined.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // vibrate_rated
            // 
            this.vibrate_rated.AllowDBNull = false;
            this.vibrate_rated.Caption = "vibrate_rate";
            this.vibrate_rated.ColumnName = "vibrate_rate";
            this.vibrate_rated.DataType = typeof(decimal);
            this.vibrate_rated.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // vibrate_depthc
            // 
            this.vibrate_depthc.AllowDBNull = false;
            this.vibrate_depthc.Caption = "vibrate_depth";
            this.vibrate_depthc.ColumnName = "vibrate_depth";
            this.vibrate_depthc.DataType = typeof(decimal);
            this.vibrate_depthc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // vibrate_delayc
            // 
            this.vibrate_delayc.AllowDBNull = false;
            this.vibrate_delayc.Caption = "vibrate_delay";
            this.vibrate_delayc.ColumnName = "vibrate_delay";
            this.vibrate_delayc.DataType = typeof(decimal);
            this.vibrate_delayc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // channel_volumec
            // 
            this.channel_volumec.AllowDBNull = false;
            this.channel_volumec.Caption = "channel_volume";
            this.channel_volumec.ColumnName = "channel_volume";
            this.channel_volumec.DataType = typeof(decimal);
            this.channel_volumec.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // portamento_timec
            // 
            this.portamento_timec.AllowDBNull = false;
            this.portamento_timec.Caption = "portamento_time";
            this.portamento_timec.ColumnName = "portamento_time";
            this.portamento_timec.DataType = typeof(decimal);
            this.portamento_timec.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // panc
            // 
            this.panc.AllowDBNull = false;
            this.panc.Caption = "pan";
            this.panc.ColumnName = "pan";
            this.panc.DataType = typeof(decimal);
            this.panc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pitch_bend_semitones
            // 
            this.pitch_bend_semitones.AllowDBNull = false;
            this.pitch_bend_semitones.Caption = "pitch_bend_semitones";
            this.pitch_bend_semitones.ColumnName = "pitch_bend_semitones";
            this.pitch_bend_semitones.DataType = typeof(decimal);
            this.pitch_bend_semitones.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pitch_wheel
            // 
            this.pitch_wheel.AllowDBNull = false;
            this.pitch_wheel.Caption = "pitch_wheel";
            this.pitch_wheel.ColumnName = "pitch_wheel";
            this.pitch_wheel.DataType = typeof(decimal);
            this.pitch_wheel.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // velocity
            // 
            this.velocity.AllowDBNull = false;
            this.velocity.Caption = "velocity";
            this.velocity.ColumnName = "velocity";
            this.velocity.DataType = typeof(decimal);
            this.velocity.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // fxb0_on
            // 
            this.fxb0_on.AllowDBNull = false;
            this.fxb0_on.Caption = "fxb0_on";
            this.fxb0_on.ColumnName = "fxb0_on";
            this.fxb0_on.DataType = typeof(bool);
            this.fxb0_on.DefaultValue = false;
            // 
            // fxb1_on
            // 
            this.fxb1_on.AllowDBNull = false;
            this.fxb1_on.Caption = "fxb1_on";
            this.fxb1_on.ColumnName = "fxb1_on";
            this.fxb1_on.DataType = typeof(bool);
            this.fxb1_on.DefaultValue = false;
            // 
            // reverb_send
            // 
            this.reverb_send.AllowDBNull = false;
            this.reverb_send.Caption = "reverb_send";
            this.reverb_send.ColumnName = "reverb_send";
            this.reverb_send.DataType = typeof(decimal);
            this.reverb_send.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_frequency
            // 
            this.filter_frequency.AllowDBNull = false;
            this.filter_frequency.Caption = "filter_frequency";
            this.filter_frequency.ColumnName = "filter_frequency";
            this.filter_frequency.DataType = typeof(decimal);
            this.filter_frequency.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_resonance
            // 
            this.filter_resonance.AllowDBNull = false;
            this.filter_resonance.Caption = "filter_resonance";
            this.filter_resonance.ColumnName = "filter_resonance";
            this.filter_resonance.DataType = typeof(decimal);
            this.filter_resonance.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_type
            // 
            this.filter_type.AllowDBNull = false;
            this.filter_type.Caption = "filter_type";
            this.filter_type.ColumnName = "filter_type";
            this.filter_type.DataType = typeof(decimal);
            this.filter_type.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_attack
            // 
            this.filter_attack.AllowDBNull = false;
            this.filter_attack.Caption = "filter_attack";
            this.filter_attack.ColumnName = "filter_attack";
            this.filter_attack.DataType = typeof(decimal);
            this.filter_attack.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_decay
            // 
            this.filter_decay.AllowDBNull = false;
            this.filter_decay.Caption = "filter_decay";
            this.filter_decay.ColumnName = "filter_decay";
            this.filter_decay.DataType = typeof(decimal);
            this.filter_decay.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // filter_release
            // 
            this.filter_release.AllowDBNull = false;
            this.filter_release.Caption = "filter_release";
            this.filter_release.ColumnName = "filter_release";
            this.filter_release.DataType = typeof(decimal);
            this.filter_release.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // stringv
            // 
            this.stringv.AllowDBNull = false;
            this.stringv.Caption = "string";
            this.stringv.ColumnName = "string";
            this.stringv.DataType = typeof(decimal);
            this.stringv.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tControl
            // 
            this.tControl.Columns.AddRange(new System.Data.DataColumn[] {
            this.tagcon,
            this.typec,
            this.namecs,
            this.stringc,
            this.indexc,
            this.output,
            this.dataColumn3,
            this.cc,
            this.inverse,
            this.variation_start,
            this.variation_end,
            this.fxb,
            this.drag_center});
            this.tControl.TableName = "tControl";
            // 
            // tagcon
            // 
            this.tagcon.AllowDBNull = false;
            this.tagcon.Caption = "tag";
            this.tagcon.ColumnName = "tag";
            this.tagcon.DefaultValue = "";
            // 
            // typec
            // 
            this.typec.AllowDBNull = false;
            this.typec.Caption = "type";
            this.typec.ColumnName = "type";
            this.typec.DataType = typeof(decimal);
            this.typec.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // namecs
            // 
            this.namecs.AllowDBNull = false;
            this.namecs.Caption = "name";
            this.namecs.ColumnName = "name";
            this.namecs.DataType = typeof(decimal);
            this.namecs.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // stringc
            // 
            this.stringc.AllowDBNull = false;
            this.stringc.Caption = "string";
            this.stringc.ColumnName = "string";
            this.stringc.DataType = typeof(decimal);
            this.stringc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // indexc
            // 
            this.indexc.AllowDBNull = false;
            this.indexc.Caption = "index";
            this.indexc.ColumnName = "index";
            this.indexc.DataType = typeof(decimal);
            this.indexc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // output
            // 
            this.output.AllowDBNull = false;
            this.output.Caption = "output";
            this.output.ColumnName = "output";
            this.output.DataType = typeof(decimal);
            this.output.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.Caption = "channel";
            this.dataColumn3.ColumnName = "channel";
            this.dataColumn3.DataType = typeof(decimal);
            this.dataColumn3.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cc
            // 
            this.cc.AllowDBNull = false;
            this.cc.Caption = "cc";
            this.cc.ColumnName = "cc";
            this.cc.DataType = typeof(decimal);
            this.cc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inverse
            // 
            this.inverse.AllowDBNull = false;
            this.inverse.Caption = "inverse";
            this.inverse.ColumnName = "inverse";
            this.inverse.DataType = typeof(decimal);
            this.inverse.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // variation_start
            // 
            this.variation_start.AllowDBNull = false;
            this.variation_start.Caption = "variation_start";
            this.variation_start.ColumnName = "variation_start";
            this.variation_start.DataType = typeof(decimal);
            this.variation_start.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // variation_end
            // 
            this.variation_end.AllowDBNull = false;
            this.variation_end.Caption = "variation_end";
            this.variation_end.ColumnName = "variation_end";
            this.variation_end.DataType = typeof(decimal);
            this.variation_end.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // fxb
            // 
            this.fxb.AllowDBNull = false;
            this.fxb.Caption = "fxb";
            this.fxb.ColumnName = "fxb";
            this.fxb.DataType = typeof(decimal);
            this.fxb.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // drag_center
            // 
            this.drag_center.AllowDBNull = false;
            this.drag_center.Caption = "drag_center";
            this.drag_center.ColumnName = "drag_center";
            this.drag_center.DataType = typeof(decimal);
            this.drag_center.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tMaster
            // 
            this.tMaster.Columns.AddRange(new System.Data.DataColumn[] {
            this.rTag,
            this.mVolume});
            this.tMaster.TableName = "tMaster";
            // 
            // rTag
            // 
            this.rTag.AllowDBNull = false;
            this.rTag.ColumnName = "tag";
            this.rTag.DefaultValue = "";
            // 
            // mVolume
            // 
            this.mVolume.AllowDBNull = false;
            this.mVolume.Caption = "MasterVolume";
            this.mVolume.ColumnName = "MasterVolume";
            this.mVolume.DataType = typeof(decimal);
            this.mVolume.DefaultValue = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // tEqualizerMain
            // 
            this.tEqualizerMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.mvTag,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.tEqualizerMain.TableName = "tEqualizerMain";
            // 
            // mvTag
            // 
            this.mvTag.AllowDBNull = false;
            this.mvTag.ColumnName = "tag";
            this.mvTag.DefaultValue = "";
            // 
            // dataColumn7
            // 
            this.dataColumn7.AllowDBNull = false;
            this.dataColumn7.Caption = "low_mid_q";
            this.dataColumn7.ColumnName = "low_mid_q";
            this.dataColumn7.DataType = typeof(decimal);
            this.dataColumn7.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn8
            // 
            this.dataColumn8.AllowDBNull = false;
            this.dataColumn8.Caption = "high_mid_q";
            this.dataColumn8.ColumnName = "high_mid_q";
            this.dataColumn8.DataType = typeof(decimal);
            this.dataColumn8.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn9
            // 
            this.dataColumn9.AllowDBNull = false;
            this.dataColumn9.Caption = "on";
            this.dataColumn9.ColumnName = "on";
            this.dataColumn9.DataType = typeof(bool);
            this.dataColumn9.DefaultValue = false;
            // 
            // tCompression
            // 
            this.tCompression.Columns.AddRange(new System.Data.DataColumn[] {
            this.cthreshold,
            this.cfxblock,
            this.con,
            this.cattack,
            this.crelease,
            this.thresholdc,
            this.cratio,
            this.aboost,
            this.kneec});
            this.tCompression.TableName = "tCompression";
            // 
            // cthreshold
            // 
            this.cthreshold.AllowDBNull = false;
            this.cthreshold.Caption = "tag";
            this.cthreshold.ColumnName = "tag";
            this.cthreshold.DefaultValue = "0";
            // 
            // cfxblock
            // 
            this.cfxblock.AllowDBNull = false;
            this.cfxblock.Caption = "fxblock";
            this.cfxblock.ColumnName = "fxblock";
            this.cfxblock.DataType = typeof(decimal);
            this.cfxblock.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // con
            // 
            this.con.AllowDBNull = false;
            this.con.Caption = "on";
            this.con.ColumnName = "on";
            this.con.DataType = typeof(bool);
            this.con.DefaultValue = false;
            // 
            // cattack
            // 
            this.cattack.AllowDBNull = false;
            this.cattack.Caption = "attack";
            this.cattack.ColumnName = "attack";
            this.cattack.DataType = typeof(decimal);
            this.cattack.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // crelease
            // 
            this.crelease.AllowDBNull = false;
            this.crelease.Caption = "release";
            this.crelease.ColumnName = "release";
            this.crelease.DataType = typeof(decimal);
            this.crelease.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // thresholdc
            // 
            this.thresholdc.AllowDBNull = false;
            this.thresholdc.Caption = "threshold";
            this.thresholdc.ColumnName = "threshold";
            this.thresholdc.DataType = typeof(decimal);
            this.thresholdc.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cratio
            // 
            this.cratio.AllowDBNull = false;
            this.cratio.Caption = "ratio";
            this.cratio.ColumnName = "ratio";
            this.cratio.DataType = typeof(decimal);
            this.cratio.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // aboost
            // 
            this.aboost.AllowDBNull = false;
            this.aboost.Caption = "boost";
            this.aboost.ColumnName = "boost";
            this.aboost.DataType = typeof(decimal);
            this.aboost.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // kneec
            // 
            this.kneec.AllowDBNull = false;
            this.kneec.Caption = "knee";
            this.kneec.ColumnName = "knee";
            this.kneec.DataType = typeof(decimal);
            this.kneec.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            treeNode31.Name = "nodeMasterVolume";
            treeNode31.Tag = "Volume";
            treeNode31.Text = "Volume";
            treeNode32.Name = "nodeMaster";
            treeNode32.Tag = "Master";
            treeNode32.Text = "Master";
            treeNode33.Name = "nodeString0";
            treeNode33.Tag = "t1";
            treeNode33.Text = "String #0";
            treeNode34.Name = "nodeString1";
            treeNode34.Tag = "t2";
            treeNode34.Text = "String #1";
            treeNode35.Name = "nodeString2";
            treeNode35.Tag = "t3";
            treeNode35.Text = "String #2";
            treeNode36.Name = "nodeString3";
            treeNode36.Tag = "t4";
            treeNode36.Text = "String #3";
            treeNode37.Name = "nodeString4";
            treeNode37.Tag = "t5";
            treeNode37.Text = "String #4";
            treeNode38.Name = "nodeString5";
            treeNode38.Tag = "6";
            treeNode38.Text = "String #5";
            treeNode39.Name = "nodeTuning";
            treeNode39.Tag = "Tuning";
            treeNode39.Text = "Tuning";
            treeNode40.Name = "nodeChannel0";
            treeNode40.Tag = "ch1";
            treeNode40.Text = "Channel #0";
            treeNode41.Name = "nodeChannel1";
            treeNode41.Tag = "ch2";
            treeNode41.Text = "Channel #1";
            treeNode42.Name = "nodeChannel2";
            treeNode42.Tag = "ch3";
            treeNode42.Text = "Channel #2";
            treeNode43.Name = "nodeChannel3";
            treeNode43.Tag = "ch4";
            treeNode43.Text = "Channel #3";
            treeNode44.Name = "nodeChannel4";
            treeNode44.Tag = "ch5";
            treeNode44.Text = "Channel #4";
            treeNode45.Name = "nodeChannel5";
            treeNode45.Tag = "ch6";
            treeNode45.Text = "Channel #5";
            treeNode46.Name = "nodeMidiOutChannel";
            treeNode46.Tag = "MidiOutChannel";
            treeNode46.Text = "MidiOutChannel";
            treeNode47.Name = "Lowest";
            treeNode47.Tag = "Lowest";
            treeNode47.Text = "Lowest";
            treeNode48.Name = "Lower";
            treeNode48.Tag = "Lower";
            treeNode48.Text = "Lower";
            treeNode49.Name = "Higher";
            treeNode49.Tag = "Higher";
            treeNode49.Text = "Higher";
            treeNode50.Name = "Highest";
            treeNode50.Tag = "Highest";
            treeNode50.Text = "Highest";
            treeNode51.Name = "nodeEqualizer";
            treeNode51.Tag = "Equalizer";
            treeNode51.Text = "Equalizer";
            treeNode52.Name = "nodeReverb";
            treeNode52.Tag = "Reverberation";
            treeNode52.Text = "Reverberation";
            treeNode53.Name = "nodeDistortion";
            treeNode53.Tag = "Distortion";
            treeNode53.Text = "Distortion";
            treeNode54.Name = "nodeModulation";
            treeNode54.Tag = "Modulation";
            treeNode54.Text = "Modulation";
            treeNode55.Name = "nodeCompression";
            treeNode55.Tag = "Compression";
            treeNode55.Text = "Compression";
            treeNode56.Name = "nodeDelay";
            treeNode56.Tag = "Delay";
            treeNode56.Text = "Delay";
            treeNode57.Name = "nodeMixer";
            treeNode57.Tag = "Mixer";
            treeNode57.Text = "Mixer";
            treeNode58.Name = "nodeVoice";
            treeNode58.Tag = "Voice";
            treeNode58.Text = "Voice";
            treeNode59.Name = "nodeControl";
            treeNode59.Tag = "Control";
            treeNode59.Text = "Control";
            treeNode60.Name = "rootPreset";
            treeNode60.Tag = "Preset";
            treeNode60.Text = "Preset";
            this.treeViewXML.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode60});
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PresetForm_FormClosed);
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
            ((System.ComponentModel.ISupportInitialize)(this.tMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEqualizerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompression)).EndInit();
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
        private System.Data.DataColumn rType;
        private System.Data.DataColumn rPre_lpf;
        private System.Data.DataColumn rLevel;
        private System.Data.DataColumn rTime;
        private System.Data.DataColumn rDelayFeedback;
        private System.Data.DataColumn tag;
        private System.Data.DataColumn pRreDelayTime;
        private System.Windows.Forms.SaveFileDialog sfd_SaveFile;
        private System.Data.DataTable tMaster;
        private System.Data.DataColumn rTag;
        private System.Data.DataColumn mVolume;
        private System.Data.DataTable tEqualizerMain;
        private System.Data.DataColumn mvTag;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn eqTag;
        private System.Data.DataColumn gain;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn fxblock;
        private System.Data.DataColumn on;
        private System.Data.DataColumn dType;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn tone;
        private System.Data.DataColumn booster;
        private System.Data.DataTable tCompression;
        private System.Data.DataColumn cthreshold;
        private System.Data.DataColumn cfxblock;
        private System.Data.DataColumn con;
        private System.Data.DataColumn cattack;
        private System.Data.DataColumn crelease;
        private System.Data.DataColumn thresholdc;
        private System.Data.DataColumn cratio;
        private System.Data.DataColumn aboost;
        private System.Data.DataColumn kneec;
        private System.Data.DataColumn tagc;
        private System.Data.DataColumn fxblockm;
        private System.Data.DataColumn ow_cut_filter_frequency;
        private System.Data.DataColumn high_cut_filter_frequencym;
        private System.Data.DataColumn input_gainm;
        private System.Data.DataColumn output_levelm;
        private System.Data.DataColumn pan;
        private System.Data.DataColumn reverb_sendm;
        private System.Data.DataColumn tagd;
        private System.Data.DataColumn fxblockd;
        private System.Data.DataColumn ond;
        private System.Data.DataColumn moden;
        private System.Data.DataColumn pre_lp;
        private System.Data.DataColumn levelc;
        private System.Data.DataColumn timen;
        private System.Data.DataColumn feedbackd;
        private System.Data.DataColumn feedback_filter;
        private System.Data.DataColumn tagt;
        private System.Data.DataColumn valued;
        private System.Data.DataColumn tagmidi;
        private System.Data.DataColumn valuem;
        private System.Data.DataColumn tagm;
        private System.Data.DataColumn fxblockmd;
        private System.Data.DataColumn onde;
        private System.Data.DataColumn typem;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn chorus_delay_timede;
        private System.Data.DataColumn chorus_feedbackd;
        private System.Data.DataColumn chorus_hpf;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn rate;
        private System.Data.DataColumn depth;
        private System.Data.DataColumn tremolo;
        private System.Data.DataColumn tagcont;
        private System.Data.DataColumn wave_id;
        private System.Data.DataColumn amplitude_attack;
        private System.Data.DataColumn amplitude_decayd;
        private System.Data.DataColumn amplitude_released;
        private System.Data.DataColumn detune_coursec;
        private System.Data.DataColumn detune_fined;
        private System.Data.DataColumn vibrate_rated;
        private System.Data.DataColumn vibrate_depthc;
        private System.Data.DataColumn vibrate_delayc;
        private System.Data.DataColumn channel_volumec;
        private System.Data.DataColumn portamento_timec;
        private System.Data.DataColumn panc;
        private System.Data.DataColumn pitch_bend_semitones;
        private System.Data.DataColumn pitch_wheel;
        private System.Data.DataColumn velocity;
        private System.Data.DataColumn fxb0_on;
        private System.Data.DataColumn fxb1_on;
        private System.Data.DataColumn reverb_send;
        private System.Data.DataColumn filter_frequency;
        private System.Data.DataColumn filter_resonance;
        private System.Data.DataColumn filter_type;
        private System.Data.DataColumn filter_attack;
        private System.Data.DataColumn filter_decay;
        private System.Data.DataColumn filter_release;
        private System.Data.DataColumn stringv;
        private System.Data.DataColumn tagcon;
        private System.Data.DataColumn typec;
        private System.Data.DataColumn namecs;
        private System.Data.DataColumn stringc;
        private System.Data.DataColumn indexc;
        private System.Data.DataColumn output;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn cc;
        private System.Data.DataColumn inverse;
        private System.Data.DataColumn variation_start;
        private System.Data.DataColumn variation_end;
        private System.Data.DataColumn fxb;
        private System.Data.DataColumn drag_center;
        private System.Windows.Forms.ToolStripMenuItem addVoiceToolStripMenuItem;
    }
}