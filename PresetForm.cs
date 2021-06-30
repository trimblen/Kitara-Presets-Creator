using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KitaraPresetsCreator
{
    public partial class PresetForm : Form
    {
        public DataRow drFind;

        private bool IsChanged = false;
        public string file_Path { get; set; }

        public PresetForm()
        {
            InitializeComponent();

            if (file_Path != null)
            { 
            }
            else 
            {
                this.Text = "NewPreset.mz";
            }
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            dataSetPresets.BeginInit();

            AddMasterVolumeData();

            AddBasicEqualizerData();

            AddEqualizerData("lowest");
            AddEqualizerData("lower");
            AddEqualizerData("higher");
            AddEqualizerData("highest");

            AddMidiOutChannel("ch0");
            AddMidiOutChannel("ch1");
            AddMidiOutChannel("ch2");
            AddMidiOutChannel("ch3");
            AddMidiOutChannel("ch4");
            AddMidiOutChannel("ch5");

            AddTuning("t0");
            AddTuning("t1");
            AddTuning("t2");
            AddTuning("t3");
            AddTuning("t4");
            AddTuning("t5");

           // Load_File();

            BuildXMLTree();

            Parse();
        }

        private void XMLTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTextHighLight(XMLTextBox);

            this.IsChanged = true;
        }

        private void Parse()
        {

            String inputLanguage =
              "<?xml version=\"1.0\" ?><preset><master volume=\"127\"/></preset>";


            // Foreach line in input,
            // identify key words and format them when adding to the rich text box.
            Regex r = new Regex("\\n");
            String[] lines = r.Split(inputLanguage);
            foreach (string l in lines)
            {
                ParseLine(l, XMLTextBox);
            }
        }

        public void Load_File()
        {
            if (file_Path != null)
            {
                DialogResult save = MessageBox.Show("Do you want to save the file?", "Warning", MessageBoxButtons.OKCancel);
                if (save == DialogResult.OK)
                {
                    this.Save_File();
                }
            }

            XMLTextBox.Clear();

            if (file_Path != null)
            {
                System.IO.StreamReader mzReader;

                mzReader = new System.IO.StreamReader(file_Path);
            }

            String[] fileName = file_Path.Split('\\');
            this.Text = fileName[fileName.Length - 1];
            XMLTextBox.LoadFile(file_Path, RichTextBoxStreamType.RichText);

            this.IsChanged = false;
        }
        public void Save_File()
        {
            if (file_Path == null)
            {
                sfd_SaveFile.FileName = this.Text;
            }
            else 
            {
                sfd_SaveFile.FileName = file_Path;
            };

            GenerateXMLFilePreset(XMLTextBox, treeViewXML);

            sfd_SaveFile.Filter = "Kitara Preset Files (.mz) | *.mz";

            if (sfd_SaveFile.ShowDialog() == DialogResult.OK)
            {
                this.file_Path      = sfd_SaveFile.FileName;
                String[] fileName   = file_Path.Split('\\');
                this.Text           = fileName[fileName.Length - 1];

                XMLTextBox.SaveFile(this.file_Path, RichTextBoxStreamType.RichText);
            }

            this.IsChanged = false;
        }
        private void ParseLine(string line, RichTextBox m_rtb)
        {
            Regex r = new Regex("([ \\t{}():;])");
            String[] tokens = r.Split(line);
            foreach (string token in tokens)
            {
                // Set the tokens default color and font.  
                m_rtb.SelectionColor = Color.Black;
                m_rtb.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                // Check whether the token is a keyword.   
                String[] keywords = {"tuning", "preset" };
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == token)
                    {
                        // Apply alternative color and font to highlight keyword.  
                        m_rtb.SelectionColor = Color.Blue;
                        m_rtb.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        break;
                    }
                }
                m_rtb.SelectedText = token;
            }
            m_rtb.SelectedText = "\n";
        }

        private void BuildXMLTree() {
            try
            {
                // 1. Read XML File from a local path
                string xmlString = XMLTextBox.Text.ToString();

                // 2. Create a XML DOM Document and load the data into it.
                XmlDocument dom = new XmlDocument();
                dom.LoadXml(xmlString);

                // 3. Initialize the TreeView control. treeView1 can be created dinamically
                // and attached to the form or you can just drag and drop the widget from the toolbox
                // into the Form.

                // Clear any previous content of the widget
                ClearTreeNodes(treeViewXML);

                // Get elements main settings
                XmlNodeList tunings             = dom.GetElementsByTagName("tuning");
                XmlNodeList master              = dom.GetElementsByTagName("master");
                XmlNodeList midi_out_channels   = dom.GetElementsByTagName("midi_out_channel");
                XmlNodeList gqualizer           = dom.GetElementsByTagName("equalizer");
                XmlNodeList eq_bands            = dom.GetElementsByTagName("eq_band");

                // Get elements of presets
                XmlNodeList reverbs              = dom.GetElementsByTagName("reverb");
                XmlNodeList distortions          = dom.GetElementsByTagName("distortion");
                XmlNodeList compressions         = dom.GetElementsByTagName("compression"); 
                XmlNodeList modulations          = dom.GetElementsByTagName("modulation");
                XmlNodeList delays               = dom.GetElementsByTagName("delay");
                XmlNodeList mixers               = dom.GetElementsByTagName("mixer");
                XmlNodeList voices               = dom.GetElementsByTagName("voice");
                XmlNodeList controls             = dom.GetElementsByTagName("control");

            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show("Incorrect or corrupted preset file! "+ xmlEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateXMLFilePreset(RichTextBox m_rtb, TreeView treeViewXML) {
            var nodes = treeViewXML.Nodes;

            foreach (TreeNode node in nodes)
            {
                WalkUpTreeViewRecursively(node);            
            }
        }

        private void WalkUpTreeViewRecursively(TreeNode trNode) {
            var nodes = trNode.Nodes;

            foreach (var node in nodes)
            {
                WalkUpTreeViewRecursively(trNode);
            }
        }

        private void ClearTreeNodes(TreeView trView) { 
        
        }

        //adding node by xml node
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;

                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    this.AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void UpdateTextHighLight(RichTextBox m_rtb) 
        {
            // Calculate the starting position of the current line.
            int start = 0, end = 0;
            for (start = m_rtb.SelectionStart - 1; start > 0; start--)
            {
                if (m_rtb.Text[start] == '\n') { start++; break; }
            }

            // Calculate the end position of the current line.
            for (end = m_rtb.SelectionStart; end < m_rtb.Text.Length; end++)
            {
                if (m_rtb.Text[end] == '\n') break;
            }

            // Extract the current line that is being edited.
            String line = m_rtb.Text.Substring(start, end - start);

            // Backup the users current selection point.
            int selectionStart = m_rtb.SelectionStart;
            int selectionLength = m_rtb.SelectionLength;

            // Split the line into tokens.
            Regex r = new Regex("([ \\t{}();])");
            string[] tokens = r.Split(line);
            int index = start;
            foreach (string token in tokens)
            {

                // Set the token's default color and font.
                m_rtb.SelectionStart = index;
                m_rtb.SelectionLength = token.Length;
                m_rtb.SelectionColor = Color.Black;
                m_rtb.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);

                // Check for a comment.
                if (token == "//" || token.StartsWith("//"))
                {
                    // Find the start of the comment and then extract the whole comment.
                    int length = line.Length - (index - start);
                    string commentText = m_rtb.Text.Substring(index, length);
                    m_rtb.SelectionStart = index;
                    m_rtb.SelectionLength = length;
                    m_rtb.SelectionColor = Color.LightGreen;
                    m_rtb.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                    break;
                }

                // Check whether the token is a keyword. 
                String[] keywords = { "xml", "version", "preset", "master", "volume" };
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == token)
                    {
                        // Apply alternative color and font to highlight keyword.        
                        m_rtb.SelectionColor = Color.Blue;
                        m_rtb.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        break;
                    }
                }
                index += token.Length;
            }
            // Restore the users current selection point.    
            m_rtb.SelectionStart = selectionStart;
            m_rtb.SelectionLength = selectionLength;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //we need to add some node 
        private void AddNodeByType(string NodeType, string nodeParentName, string tableName) {
            TreeNode tns = treeViewXML.Nodes.Find(NodeType, true).FirstOrDefault();

            treeViewXML.SelectedNode = tns;
            int NodeCount            = treeViewXML.SelectedNode.GetNodeCount(true);
            string namePrefix        = (NodeCount == 0) ? "1" : (NodeCount + 1).ToString();

            TreeNode tNewNode   = new TreeNode(nodeParentName + namePrefix);
            tNewNode.Tag        = NodeType + namePrefix;

            treeViewXML.SelectedNode.Nodes.Add(tNewNode);

            DataRow rNewRow = dataSetPresets.Tables[tableName].NewRow();

            rNewRow["tag"] = NodeType + namePrefix;

            dataSetPresets.Tables[tableName].Rows.Add(rNewRow);
        }

        //remove presets property
        private void RemoveCurrentProperty_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This setting will be removed. Proceed?", "Really Remove?", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                bool ChRes = CheckTreeNode(treeViewXML.SelectedNode);

                if (ChRes)
                {
                    DeleteDataSetFromNode(treeViewXML.SelectedNode);
                    treeViewXML.Nodes.Remove(treeViewXML.SelectedNode);                   
                }
                else 
                {
                    MessageBox.Show("Unable to remove predefined settings!", "Error!");
                }
            }
        }

        //edit custom properties
        private void EditReverbData(string rTag) {
            DataRow[] findRow = GetARowStringByTag(rTag, "tReverberation");

            this.drFind = findRow[0];
          
            ReverberationEdit revForm   = new ReverberationEdit(this);
            DialogResult dResult        =  revForm.ShowDialog();

            if (dResult == DialogResult.OK) {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditDelayData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tDelay");

            this.drFind = findRow[0];

            DelayEdit dlForm        = new DelayEdit(this);
            DialogResult dResult    = dlForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditDistortionData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tDistortion");

            this.drFind = findRow[0];

            DistortionEdit dsrForm       = new DistortionEdit(this);
            DialogResult dResult         = dsrForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditMixerData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tMixer");

            this.drFind = findRow[0];

            MixerEdit mxForm        = new MixerEdit(this);
            DialogResult dResult    = mxForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditEqualizerData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tEqualizer");

            this.drFind = findRow[0];

            EqualizerEdit revForm = new EqualizerEdit(this);
            DialogResult dResult = revForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditEqualizerMainData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tEqualizerMain");

            this.drFind = findRow[0];

            EqualizerMainEdit emForm    = new EqualizerMainEdit(this);
            DialogResult dResult        = emForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }


        private void EditModulationData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tModulation");

            this.drFind = findRow[0];

            ModulationEdit mForm    = new ModulationEdit(this);
            DialogResult dResult    = mForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditControlData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tControl");

            this.drFind = findRow[0];

            ControlEdit cForm       = new ControlEdit(this);
            DialogResult dResult    = cForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditCompressionData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tCompression");

            this.drFind = findRow[0];

            CompressionEdit cmpForm = new CompressionEdit(this);
            DialogResult dResult    = cmpForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditVoiceData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tVoice");

            this.drFind = findRow[0];

            VoiceEdit vForm         = new VoiceEdit(this);
            DialogResult dResult    = vForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditMidiOutChannelData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tMidiOutChannel");

            this.drFind = findRow[0];

            MidiOutChannelEdit mcForm   = new MidiOutChannelEdit(this);
            DialogResult dResult        = mcForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void EditMasterVolumeData(string mTag)
        {
            DataRow[] findRow = GetARowStringByTag(mTag, "tMaster");

            this.drFind = findRow[0];

            MasterVolumeEdit mvForm = new MasterVolumeEdit(this);
            DialogResult dResult    = mvForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
        }

        private void AddMasterVolumeData(byte Volume=127)
        {
            DataRow rNewRow             = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"]              = "Volume";
            rNewRow["MasterVolume"]     = Volume;

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }

        private void AddBasicEqualizerData()
        {
            DataRow rNewRow = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"]  = "Volume";

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }

        private void AddEqualizerData(string equalizerVolume)
        {
            DataRow rNewRow = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"] = "Volume";

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }

        private void AddMidiOutChannel(string midiChannel)
        {
            DataRow rNewRow = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"] = "Volume";

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }

        private void AddTuning(string tuningChannel)
        {
            DataRow rNewRow = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"] = "Volume";

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }


        private DataRow[] GetARowStringByTag(string rowTag, string tableName) {
            DataRow[] foundRow = dataSetPresets.Tables[tableName].Select("tag = '"+rowTag+"'");

            return foundRow;          
        }

        private bool CheckTreeNode(TreeNode tNode) {
            bool chResult = true;

            switch (tNode.Tag)
            {
                case "Preset":               
                    chResult = false;
                    break;
                case "t1":
                    chResult = false;
                    break;
                case "t2":
                    chResult = false;
                    break;
                case "t3":
                    chResult = false;
                    break;
                case "t4":
                    chResult = false;
                    break;
                case "t5":
                    chResult = false;
                    break;
                case "t6":
                    chResult = false;
                    break;
                case "ch1":
                    chResult = false;
                    break;
                case "ch2":
                    chResult = false;
                    break;
                case "ch3":
                    chResult = false;
                    break;
                case "ch4":
                    chResult = false;
                    break;
                case "ch5":
                    chResult = false;
                    break;
                case "ch6":
                    chResult = false;
                    break;
                case "Master":
                    chResult = false;
                    break;
                case "Volume":
                    chResult = false;
                    break;
                case "Reverberation":
                    chResult = false;
                    break;
                case "Delay":
                    chResult = false;
                    break;
                case "Mixer":
                    chResult = false;
                    break;
                case "Control":
                    chResult = false;
                    break;
                case "Voice":
                    chResult = false;
                    break;
                case "Modulation":
                    chResult = false;
                    break;
                case "Compression":
                    chResult = false;
                    break;
                case "MidiOutChannel":
                    chResult = false;
                    break;
                case "Equalizer":
                    chResult = false;
                    break;
                case "Lowest":
                    chResult = false;
                    break;
                case "Lower":
                    chResult = false;
                    break;
                case "Higher":
                    chResult = false;
                    break;
                case "Highest":
                    chResult = false;
                    break;
                default:
                    chResult = true;
                    break;
            }

            return chResult;
        }

        private void DeleteDataSetFromNode(TreeNode tNode)
        {
            switch (tNode.Parent.Tag)
            {
                case "Reverberation":
                    DataRow[] fRow = GetARowStringByTag(tNode.Tag.ToString(), "tReverberation");
                    dataSetPresets.Tables["tReverberation"].Rows.Remove(fRow[0]);
                    break;                
                case "Delay":
                    DataRow[] dRow = GetARowStringByTag(tNode.Tag.ToString(), "tDelay");
                    dataSetPresets.Tables["tDelay"].Rows.Remove(dRow[0]);
                    break;
                case "Mixer":
                    DataRow[] mRow = GetARowStringByTag(tNode.Tag.ToString(), "tMixer");
                    dataSetPresets.Tables["tMixer"].Rows.Remove(mRow[0]);
                    break;
                case "Control":
                    DataRow[] сRow = GetARowStringByTag(tNode.Tag.ToString(), "tControl");
                    dataSetPresets.Tables["tControl"].Rows.Remove(сRow[0]);
                    break;
                case "Voice":
                    DataRow[] vRow = GetARowStringByTag(tNode.Tag.ToString(), "tVoice");
                    dataSetPresets.Tables["tVoice"].Rows.Remove(vRow[0]);
                    break;
                case "Modulation":
                    DataRow[] mdRow = GetARowStringByTag(tNode.Tag.ToString(), "tModulation");
                    dataSetPresets.Tables["tModulation"].Rows.Remove(mdRow[0]);
                    break;
                case "Distortion":
                    DataRow[] dsRow = GetARowStringByTag(tNode.Tag.ToString(), "tDistortion");
                    dataSetPresets.Tables["tDistortion"].Rows.Remove(dsRow[0]);
                    break;
                case "Compression":
                    DataRow[] cmpRow = GetARowStringByTag(tNode.Tag.ToString(), "tCompression");
                    dataSetPresets.Tables["tCompression"].Rows.Remove(cmpRow[0]);
                    break;
                default:            
                    break;
            }
        }

        private bool CheckTreeNodeForEditing(TreeNode tNode)
        {
            bool chResult;

            switch (tNode.Tag)
            {
                case "Preset":
                    chResult = true;
                    break;
                case "Master":
                    chResult = true;
                    break;
                case "Reverberation":
                    chResult = true;
                    break;
                case "Delay":
                    chResult = true;
                    break;
                case "Mixer":
                    chResult = true;
                    break;
                case "Control":
                    chResult = true;
                    break;
                case "Distortion":
                    chResult = true;
                    break;
                case "Voice":
                    chResult = true;
                    break;
                case "Modulation":
                    chResult = true;
                    break;
                case "Compression":
                    chResult = true;
                    break;
                case "MidiOutChannel":
                    chResult = true;
                    break;
                case "Equalizer":
                    chResult = false;
                    break;
                case "Lowest":
                    chResult = false;
                    break;
                case "Lower":
                    chResult = false;
                    break;
                case "Higher":
                    chResult = false;
                    break;
                case "Highest":
                    chResult = false;
                    break;
                default:
                    chResult = false;
                    break;
            }

            return chResult;
        }

        private void EditNodeInfo(TreeNode tNode, string tNodeParentTag)
        {
            switch (tNodeParentTag)
            {
                case "Preset":
                    if (tNode.Tag.ToString() == "Equalizer") {
                        EditEqualizerMainData(tNode.Tag.ToString());
                    }
                    break;
                case "Master":           
                    EditMasterVolumeData(tNode.Tag.ToString());                
                    break;
                case "Reverberation":
                    EditReverbData(tNode.Tag.ToString());
                    break;
                case "Delay":
                    EditDelayData(tNode.Tag.ToString());
                    break;
                case "Equalizer":
                    EditEqualizerData(tNode.Tag.ToString());
                    break;
                case "Mixer":
                    EditMixerData(tNode.Tag.ToString());
                    break;
                case "Control":
                    EditControlData(tNode.Tag.ToString());
                    break;
                case "Distortion":
                    EditDistortionData(tNode.Tag.ToString());
                    break;
                case "Voice":
                    EditVoiceData(tNode.Tag.ToString());
                    break;
                case "Modulation":
                    EditModulationData(tNode.Tag.ToString());
                    break;
                case "Compression":
                    EditCompressionData(tNode.Tag.ToString());
                    break;
                case "MidiOutChannel":
                    EditMidiOutChannelData(tNode.Tag.ToString());
                    break;
                default:
                    break;
            };
        }

        private void treeViewXML_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            bool ResCheck = CheckTreeNode(e.Node);

            if (!ResCheck) 
            {
                e.CancelEdit = true;
            }
        }

        private void EditCurrentProperty_Click(object sender, EventArgs e)
        {
            bool ResCheck = CheckTreeNodeForEditing(treeViewXML.SelectedNode.Parent);

            if (ResCheck) 
            {
                EditNodeInfo(treeViewXML.SelectedNode, treeViewXML.SelectedNode.Parent.Text);
            }

        }

        private void PresetForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
            if (this.IsChanged) { 

                DialogResult save = MessageBox.Show("Do you want to save this preset?", "Warning", MessageBoxButtons.OKCancel);

                if (save == DialogResult.OK)
                {
                    this.Save_File();
                }

            }
        }

        private void addCompressionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeCompression", "Compression", "tCompression");
        }

        private void AddReverb_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeReverb", "Reverberation", "tReverberation");

        }

        private void AddDistiortion_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeDistortion", "Distortion", "tDistortion");
        }

        private void AddDelay_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeDelay", "Delay", "tDelay");
        }

        private void AddControl_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeControl", "Control", "tControl");
        }

        private void AddModulation_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeModulation", "Modulation", "tModulation");
        }

        private void AddMixer_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeMixer", "Mixer", "tMixer");
        }

        private void addVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNodeByType("nodeVoice", "Voice", "tVoice");
        }
    }
}
