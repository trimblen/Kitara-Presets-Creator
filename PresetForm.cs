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

            if (this.file_Path != null)
            {
                String[] fileName = file_Path.Split('\\');
                this.Text = fileName[fileName.Length - 1];

                XMLTextBox.LoadFile(file_Path, RichTextBoxStreamType.PlainText);

                BuildXMLTree();

                this.IsChanged = false;
    
                //GenerateXMLFilePreset(XMLTextBox, treeViewXML);

                //UpdateTextHighLight(XMLTextBox);
            }
            else {

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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);

                //UpdateTextHighLight(XMLTextBox);
            }
            
        }

        private void XMLTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTextHighLight(XMLTextBox);

            this.IsChanged = true;
        }

        private void Parse()
        {

            String inputLanguage =
              XMLTextBox.Text;


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

            //if (file_Path != null)
            //{
            //    System.IO.StreamReader mzReader;

            //    mzReader = new System.IO.StreamReader(file_Path);

            //}

            String[] fileName   = file_Path.Split('\\');
            this.Text           = fileName[fileName.Length - 1];
            
            XMLTextBox.LoadFile(file_Path, RichTextBoxStreamType.PlainText);

            BuildXMLTree();

            this.IsChanged = false;
        }
        public void Save_File()
        {
            if (this.file_Path == null)
            {
                sfd_SaveFile.FileName = this.Text;
            }
            else 
            {
                sfd_SaveFile.FileName = this.file_Path;
            };            

            sfd_SaveFile.Filter = "Kitara Preset Files (.mz) | *.mz";

            if (sfd_SaveFile.ShowDialog() == DialogResult.OK)
            {
                this.file_Path      = sfd_SaveFile.FileName;
                String[] fileName   = file_Path.Split('\\');
                this.Text           = fileName[fileName.Length - 1];

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);

                XMLTextBox.SaveFile(this.file_Path, RichTextBoxStreamType.PlainText);

                this.IsChanged = false;
            }          
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
                XmlNodeList tunings              = dom.GetElementsByTagName("tuning");
                XmlNodeList master               = dom.GetElementsByTagName("master");
                XmlNodeList midi_out_channels    = dom.GetElementsByTagName("midi_out_channel");
                XmlNodeList equalizer            = dom.GetElementsByTagName("equalizer");
                XmlNodeList equaBands            = equalizer[0].SelectNodes("eq_band");


                //now we have to check the availability of main settings, if they are not, then we generate an exception
                if (tunings.Count == 0 | master.Count == 0 | midi_out_channels.Count == 0 | equalizer.Count == 0) {

                    throw new XmlException("Invalid or corrupted preset file!");
                };

                AddMasterVolumeData(0, master[0]);

                AddBasicEqualizerData(equalizer[0]);       

                AddEqualizerData("lowest"   , equaBands[0]);
                AddEqualizerData("lower"    , equaBands[1]);
                AddEqualizerData("higher"   , equaBands[2]);
                AddEqualizerData("highest"  , equaBands[3]);

                for (var i = 0; i<=5 ; i++) {
                    AddMidiOutChannel("ch"+i.ToString(), midi_out_channels[i]);
                };

                for (var i = 0; i <= 5; i++)
                {
                    AddTuning("t" + i.ToString(), tunings[i]);
                };

                //getting and setting elements from xml preset...
                // Get elements of presets
                XmlNodeList reverbs              = dom.GetElementsByTagName("reverb");
                XmlNodeList distortions          = dom.GetElementsByTagName("distortion");
                XmlNodeList compressions         = dom.GetElementsByTagName("compression"); 
                XmlNodeList modulations          = dom.GetElementsByTagName("modulation");
                XmlNodeList delays               = dom.GetElementsByTagName("delay");
                XmlNodeList mixers               = dom.GetElementsByTagName("mixer");
                XmlNodeList voices               = dom.GetElementsByTagName("voice");
                XmlNodeList controls             = dom.GetElementsByTagName("control");

                foreach (XmlNode xmlRev in reverbs) {
                    this.AddNodeByType("nodeReverb", "Reverberation", "tReverberation", xmlRev);
                };

                foreach (XmlNode xmlDist in distortions)
                {
                    this.AddNodeByType("nodeDistortion", "Distortion", "tDistortion", xmlDist);
                };

                foreach (XmlNode xmlCom in compressions)
                {
                    this.AddNodeByType("nodeCompression", "Compression", "tCompression", xmlCom);
                };

                foreach (XmlNode xmlMod in modulations)
                {
                    this.AddNodeByType("nodeModulation", "Modulation", "tModulation", xmlMod);
                };

                foreach (XmlNode xmlDel in delays)
                {
                    this.AddNodeByType("nodeDelay", "Delay", "tDelay", xmlDel);
                };

                foreach (XmlNode xmlMx in mixers)
                {
                    this.AddNodeByType("nodeMixer", "Mixer", "tMixer", xmlMx);
                };

                foreach (XmlNode xmlV in voices)
                {
                    this.AddNodeByType("nodeVoice", "Voice", "tVoice", xmlV);
                };

                foreach (XmlNode xmlC in controls)
                {
                    this.AddNodeByType("nodeControl", "Control", "tControl", xmlC);
                };
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show("Incorrect or corrupted preset file! "+ xmlEx.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect or corrupted preset file! " +  ex.Message);
            }
        }

        private void GenerateXMLFilePreset(RichTextBox m_rtb, TreeView treeViewXML) {

            m_rtb.Clear();

            //getting and parsing base parameters
            String XMLString = "";

            XMLString += "<? xml version =\"1.0\" ?>\n<preset>\n";
            XMLString += "  <kitara_id ap=\"v1.0\" />\n";

            DataRow[] maRow = GetARowStringByTag("Volume", "tMaster");

            XMLString += "  <master volume="+"\"" +maRow[0].Field<Decimal>("MasterVolume").ToString()+"\""+"/>\n";

            DataRow[] t0Row = GetARowStringByTag("t0", "tTuning");
            DataRow[] t1Row = GetARowStringByTag("t1", "tTuning");
            DataRow[] t2Row = GetARowStringByTag("t2", "tTuning");
            DataRow[] t3Row = GetARowStringByTag("t3", "tTuning");
            DataRow[] t4Row = GetARowStringByTag("t4", "tTuning");
            DataRow[] t5Row = GetARowStringByTag("t5", "tTuning");

            XMLString += "  <tuning string=" + "\"0\" value=" + "\"" + t0Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <tuning string=" + "\"1\" value=" + "\"" + t1Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <tuning string=" + "\"2\" value=" + "\"" + t2Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <tuning string=" + "\"3\" value=" + "\"" + t3Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <tuning string=" + "\"4\" value=" + "\"" + t4Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <tuning string=" + "\"5\" value=" + "\"" + t5Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";

            DataRow[] ch0Row = GetARowStringByTag("ch0", "tMidiOutChannel");
            DataRow[] ch1Row = GetARowStringByTag("ch1", "tMidiOutChannel");
            DataRow[] ch2Row = GetARowStringByTag("ch2", "tMidiOutChannel");
            DataRow[] ch3Row = GetARowStringByTag("ch3", "tMidiOutChannel");
            DataRow[] ch4Row = GetARowStringByTag("ch4", "tMidiOutChannel");
            DataRow[] ch5Row = GetARowStringByTag("ch5", "tMidiOutChannel");

            XMLString += "  <midi_out_channel string=" + "\"0\" value=" + "\"" + ch0Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <midi_out_channel string=" + "\"1\" value=" + "\"" + ch1Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <midi_out_channel string=" + "\"2\" value=" + "\"" + ch2Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <midi_out_channel string=" + "\"3\" value=" + "\"" + ch3Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <midi_out_channel string=" + "\"4\" value=" + "\"" + ch4Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";
            XMLString += "  <midi_out_channel string=" + "\"5\" value=" + "\"" + ch5Row[0].Field<Decimal>("value").ToString() + "\"" + "/>\n";

            DataRow[] beqRow        = GetARowStringByTag("Equalizer", "tEqualizerMain");

            DataRow[] lowerRow      = GetARowStringByTag("Lowest", "tEqualizer");
            DataRow[] lowRow        = GetARowStringByTag("Lower", "tEqualizer");
            DataRow[] highRow       = GetARowStringByTag("Higher", "tEqualizer");
            DataRow[] highestRow    = GetARowStringByTag("Highest", "tEqualizer");

            string eqOn;

            if (beqRow[0].Field<Boolean>("on") == true)
            {
                eqOn = "\"" + "1" + "\"";
            }
            else {

                eqOn = "\"" + "0" + "\"";
            }
            
            XMLString += "  <equalizer on=" + eqOn + " low_mid_q=" + "\""+ beqRow[0].Field<Decimal>("low_mid_q").ToString() + "\"" + " high_mid_q=" + "\"" + beqRow[0].Field<Decimal>("high_mid_q") + "\"" + "/>\n";
            XMLString += "      <eq_band type=" + "\"lowest\" gain=" + "\"" + lowerRow[0].Field<Decimal>("gain").ToString() + "\"" + " frequency=" + "\"" + lowerRow[0].Field<Decimal>("frequency").ToString() + "\"" + "/>\n";
            XMLString += "      <eq_band type=" + "\"lower\" gain=" + "\"" + lowRow[0].Field<Decimal>("gain").ToString() + "\"" + " frequency=" + "\"" + lowRow[0].Field<Decimal>("frequency").ToString() + "\"" + "/>\n";
            XMLString += "      <eq_band type=" + "\"higher\" gain=" + "\"" + highRow[0].Field<Decimal>("gain").ToString() + "\"" + " frequency=" + "\"" + highRow[0].Field<Decimal>("frequency").ToString() + "\"" + "/>\n";
            XMLString += "      <eq_band type=" + "\"highest\" gain=" + "\"" + highestRow[0].Field<Decimal>("gain").ToString() + "\"" + " frequency="+ "\""+ highestRow[0].Field<Decimal>("frequency").ToString() + "\"" + "/>\n";
            XMLString += "  </equalizer>\n";

            //getting and setting presets parameters
            TreeNode tRev   = GetParentNode("nodeReverb");
            TreeNode tCom   = GetParentNode("nodeCompression");
            TreeNode tContr = GetParentNode("nodeControl");
            TreeNode tDel   = GetParentNode("nodeDelay");
            TreeNode tDistr = GetParentNode("nodeDistortion");
            TreeNode tMixr  = GetParentNode("nodeMixer");
            TreeNode tMod   = GetParentNode("nodeModulation");
            TreeNode tVo   =  GetParentNode("nodeVoice");

            foreach (TreeNode trn in tRev.Nodes)
            {
                DataRow[] revRow = GetARowStringByTag(trn.Tag.ToString(), "tReverberation");

                XMLString += "  <reverb type="+ "\""+ revRow[0].Field<Decimal>("rType").ToString() + "\""
                    + " prid=" + "\"" + trn.Text + "\""
                    + " pre_lpf="+ "\"" + revRow[0].Field<Decimal>("rPre_lpf").ToString() + "\""+ " level="+ "\""
                    + revRow[0].Field<Decimal>("rLevel").ToString() + "\"" 
                    +"  time="+ "\"" + revRow[0].Field<Decimal>("rTime").ToString() + "\"" 
                    + " delay_feedback ="+ "\"" + revRow[0].Field<Decimal>("rDelayFeedback").ToString() + "\"" 
                    + " pre_delay_time=" + "\"" + revRow[0].Field<Decimal>("pRreDelayTime").ToString()  + "\""+ "/>\n";
            }

            foreach (TreeNode tcm in tCom.Nodes)
            {
                DataRow[] tcmRow = GetARowStringByTag(tcm.Tag.ToString(), "tCompression");

                string tOn;

                if (tcmRow[0].Field<Boolean>("on") == true)
                {
                    tOn = "1";
                }
                else
                {

                    tOn = "0";
                };

                XMLString += "  <compression fxblock=" + "\"" + tcmRow[0].Field<Decimal>("fxblock").ToString() + "\""
                    + " prid=" + "\"" + tcm.Text + "\""
                    + " on=" + "\"" + tOn + "\""
                    + " attack=" + "\"" + tcmRow[0].Field<Decimal>("attack").ToString() + "\""
                    + " release=" + "\"" + tcmRow[0].Field<Decimal>("release").ToString() + "\""
                    + " threshold=" + "\"" + tcmRow[0].Field<Decimal>("threshold").ToString() + "\""
                    + " ratio=" + "\"" + tcmRow[0].Field<Decimal>("ratio").ToString() + "\""
                    + " boost=" + "\"" + tcmRow[0].Field<Decimal>("boost").ToString() + "\""
                    + " knee=" + "\"" + tcmRow[0].Field<Decimal>("knee").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode tctr in tContr.Nodes)
            {
                DataRow[] tctrRow = GetARowStringByTag(tctr.Tag.ToString(), "tControl");

                XMLString += "  <control type="  +"\"" + tctrRow[0].Field<Decimal>("type").ToString() + "\""
                            + " prid="+ "\"" + tctr.Text + "\""
                            + " name=" + "\"" + tctrRow[0].Field<Decimal>("name").ToString() + "\""
                            + " string=" + "\"" + tctrRow[0].Field<Decimal>("string").ToString() + "\""
                            + " index=" + "\"" + tctrRow[0].Field<Decimal>("index").ToString() + "\""
                            + " output=" + "\"" + tctrRow[0].Field<Decimal>("output").ToString() + "\""
                            + " channel=" + "\"" + tctrRow[0].Field<Decimal>("channel").ToString() + "\""
                            + " cc=" + "\"" + tctrRow[0].Field<Decimal>("cc").ToString() + "\""
                            + " inverse=" + "\"" + tctrRow[0].Field<Decimal>("inverse").ToString() + "\""
                            + " variation_start=" + "\"" + tctrRow[0].Field<Decimal>("variation_start").ToString() + "\""
                            + " variation_end=" + "\"" + tctrRow[0].Field<Decimal>("variation_end").ToString() + "\""
                            + " fxb=" + "\"" + tctrRow[0].Field<Decimal>("fxb").ToString() + "\""
                            + " drag_center=" + "\"" + tctrRow[0].Field<Decimal>("drag_center").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode tdl in tDel.Nodes)
            {
                DataRow[] tdlRow = GetARowStringByTag(tdl.Tag.ToString(), "tDelay");

                string dOn;

                if (tdlRow[0].Field<Boolean>("on") == true)
                {
                    dOn = "1";
                }
                else
                {

                    dOn = "0";
                };

                XMLString += "  <delay fxblock=" + "\"" + tdlRow[0].Field<Decimal>("fxblock").ToString() + "\""
                    + "  prid=" + "\"" + tdl.Text + "\""
                    + "  on=" + "\"" + dOn + "\""
                    + "  mode=" + "\"" + tdlRow[0].Field<Decimal>("mode").ToString() + "\""
                    + "  pre_lp=" + "\"" + tdlRow[0].Field<Decimal>("pre_lp").ToString() + "\""
                    + "  level=" + "\"" + tdlRow[0].Field<Decimal>("level").ToString() + "\""
                    + "  time=" + "\"" + tdlRow[0].Field<Decimal>("time").ToString() + "\""
                    + "  feedback=" + "\"" + tdlRow[0].Field<Decimal>("feedback").ToString() + "\""
                    + "  feedback_filter=" + "\"" + tdlRow[0].Field<Decimal>("feedback_filter").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode tds in tDistr.Nodes)
            {
                DataRow[] tctrRow = GetARowStringByTag(tds.Tag.ToString(), "tDistortion");

                string dsOn;

                if (tctrRow[0].Field<Boolean>("on") == true)
                {
                    dsOn = "1";
                }
                else
                {

                    dsOn = "0";
                };

                XMLString += "  <distortion fxblock=" + "\"" + tctrRow[0].Field<Decimal>("fxblock").ToString() + "\"" 
                                                      +"    prid=" + "\"" + tds.Text + "\""
                                                      +"    on=" + "\"" + dsOn + "\""
                                                      +"    type=" + "\"" + tctrRow[0].Field<Decimal>("type").ToString() + "\""
                                                      +"    level=" + "\"" + tctrRow[0].Field<Decimal>("level").ToString() + "\""
                                                      +"    drive=" + "\"" + tctrRow[0].Field<Decimal>("drive").ToString() + "\""
                                                      +"    tone=" + "\"" + tctrRow[0].Field<Decimal>("tone").ToString() + "\""
                                                      +"    booster=" + "\"" + tctrRow[0].Field<Decimal>("booster").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode txmr in tMixr.Nodes)
            {
                DataRow[] txmrRow = GetARowStringByTag(txmr.Tag.ToString(), "tMixer");

                XMLString += "  <mixer fxblock=" +"\"" + txmrRow[0].Field<Decimal>("fxblock").ToString() + "\""
                                +"  prid="+ "\"" + txmr.Text + "\""
                                +"  low_cut_filter_frequency=" + "\"" + txmrRow[0].Field<Decimal>("low_cut_filter_frequency").ToString() + "\""
                                +"  high_cut_filter_frequency=" + "\"" + txmrRow[0].Field<Decimal>("low_cut_filter_frequency").ToString() + "\""
                                +"  input_gain=" + "\"" + txmrRow[0].Field<Decimal>("input_gain").ToString() + "\""
                                +"  output_level=" + "\"" + txmrRow[0].Field<Decimal>("output_level").ToString() + "\""
                                +"  pan=" + "\"" + txmrRow[0].Field<Decimal>("pan").ToString() + "\""
                                +"  reverb_send=" + "\"" + txmrRow[0].Field<Decimal>("reverb_send").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode tm in tMod.Nodes)
            {
                DataRow[] tmRow = GetARowStringByTag(tm.Tag.ToString(), "tModulation");

                string tmOn;

                if (tmRow[0].Field<Boolean>("on") == true)
                {
                    tmOn = "1";
                }
                else
                {

                    tmOn = "0";
                };

                XMLString += "  <modulation fxblock=" + "\"" + tmRow[0].Field<Decimal>("fxblock").ToString() + "\""
                                 + "  prid=" + "\"" + tm.Text + "\""
                                 + "  on=" + "\"" + tmOn + "\""
                                 + "  type=" + "\"" + tmRow[0].Field<Decimal>("type").ToString() + "\""
                                 + "  level=" + "\"" + tmRow[0].Field<Decimal>("level").ToString() + "\""
                                 + "  chorus_delay_time=" + "\"" + tmRow[0].Field<Decimal>("chorus_delay_time").ToString() + "\""
                                 + "  chorus_feedback=" + "\"" + tmRow[0].Field<Decimal>("chorus_feedback").ToString() + "\""
                                 + "  chorus_hpf=" + "\"" + tmRow[0].Field<Decimal>("chorus_hpf").ToString() + "\""
                                 + "  delay_feedback_filter=" + "\"" + tmRow[0].Field<Decimal>("delay_feedback_filter").ToString() + "\""
                                 + "  rate=" + "\"" + tmRow[0].Field<Decimal>("rate").ToString() + "\""
                                 + "  depth=" + "\"" + tmRow[0].Field<Decimal>("depth").ToString() + "\""
                                 + "  tremolo=" + "\"" + tmRow[0].Field<Decimal>("tremolo").ToString() + "\"" + "/>\n";
            }

            foreach (TreeNode tv in tVo.Nodes)
            {
                DataRow[] tvRow = GetARowStringByTag(tv.Tag.ToString(), "tVoice");

                string t1vOn;

                if (tvRow[0].Field<Boolean>("fxb0_on") == true)
                {
                    t1vOn = "1";
                }
                else
                {

                    t1vOn = "0";
                };

                string t2vOn;

                if (tvRow[0].Field<Boolean>("fxb1_on") == true)
                {
                    t2vOn = "1";
                }
                else
                {

                    t2vOn = "0";
                };

                XMLString += "  <voice string=" + "\""+ tvRow[0].Field<Decimal>("string").ToString() + "\""
                                                +"  prid="+"\"" + tv.Text + "\""
                                                +"  wave_id=" + "\"" + tvRow[0].Field<String>("wave_id") + "\""
                                                +"  amplitude_attack=" + "\"" + tvRow[0].Field<Decimal>("amplitude_attack").ToString() + "\""
                                                +"  amplitude_decay=" + "\"" + tvRow[0].Field<Decimal>("amplitude_decay").ToString() + "\""
                                                +"  amplitude_release=" + "\"" + tvRow[0].Field<Decimal>("amplitude_release").ToString() + "\""
                                                +"  detune_course=" + "\"" + tvRow[0].Field<Decimal>("detune_course").ToString() + "\""
                                                +"  detune_fine=" + "\"" + tvRow[0].Field<Decimal>("detune_fine").ToString() + "\""
                                                +"  vibrate_rate=" + "\"" + tvRow[0].Field<Decimal>("vibrate_rate").ToString() + "\""
                                                +"  vibrate_depth=" + "\"" + tvRow[0].Field<Decimal>("vibrate_depth").ToString() + "\""
                                                +"  vibrate_delay=" + "\"" + tvRow[0].Field<Decimal>("vibrate_delay").ToString() + "\""
                                                +"  channel_volume=" + "\"" + tvRow[0].Field<Decimal>("channel_volume").ToString() + "\""
                                                +"  portamento_time=" + "\"" + tvRow[0].Field<Decimal>("portamento_time").ToString() + "\""
                                                +"  pan=" + "\"" + tvRow[0].Field<Decimal>("pan").ToString() + "\""
                                                +"  pitch_bend_semitones=" + "\"" + tvRow[0].Field<Decimal>("pitch_bend_semitones").ToString() + "\""
                                                +"  pitch_wheel=" + "\"" + tvRow[0].Field<Decimal>("pitch_wheel").ToString() + "\""
                                                +"  velocity=" + "\"" + tvRow[0].Field<Decimal>("velocity").ToString() + "\""
                                                +"  fxb0_on=" + "\"" + t1vOn + "\""
                                                +"  fxb1_on=" + "\"" + t2vOn + "\""
                                                +"  reverb_send=" + "\"" + tvRow[0].Field<Decimal>("reverb_send").ToString() + "\""
                                                +"  filter_frequency=" + "\"" + tvRow[0].Field<Decimal>("filter_frequency").ToString() + "\""
                                                +"  filter_resonance=" + "\"" + tvRow[0].Field<Decimal>("filter_resonance").ToString() + "\""
                                                +"  filter_type=" + "\"" + tvRow[0].Field<Decimal>("filter_type").ToString() + "\""
                                                +"  filter_attack=" + "\"" + tvRow[0].Field<Decimal>("filter_attack").ToString() + "\""
                                                +"  filter_decay=" + "\"" + tvRow[0].Field<Decimal>("filter_decay").ToString() + "\""
                                                +"  filter_release=" + "\"" + tvRow[0].Field<Decimal>("filter_release").ToString() + "\"" + "/>\n";
            }

            XMLString += "</preset>";

            m_rtb.Text = XMLString;

            this.IsChanged = true;

        }

        private void ClearTreeNodes(TreeView trView) {
                   

            DataRow[] maRow = GetARowStringByTag("Volume", "tMaster");

            //let's think that if we don't have a main parameter, then everything is empty too
            if (maRow.Count() == 0) {
                return;
            }

            dataSetPresets.Tables["tMaster"].Rows.Remove(maRow[0]);

            DataRow[] t0Row = GetARowStringByTag("t0", "tTuning");
            DataRow[] t1Row = GetARowStringByTag("t1", "tTuning");
            DataRow[] t2Row = GetARowStringByTag("t2", "tTuning");
            DataRow[] t3Row = GetARowStringByTag("t3", "tTuning");
            DataRow[] t4Row = GetARowStringByTag("t4", "tTuning");
            DataRow[] t5Row = GetARowStringByTag("t5", "tTuning");

            dataSetPresets.Tables["tTuning"].Rows.Remove(t0Row[0]);
            dataSetPresets.Tables["tTuning"].Rows.Remove(t1Row[0]);
            dataSetPresets.Tables["tTuning"].Rows.Remove(t2Row[0]);
            dataSetPresets.Tables["tTuning"].Rows.Remove(t3Row[0]);
            dataSetPresets.Tables["tTuning"].Rows.Remove(t4Row[0]);
            dataSetPresets.Tables["tTuning"].Rows.Remove(t5Row[0]);

            DataRow[] ch0Row = GetARowStringByTag("ch0", "tMidiOutChannel");
            DataRow[] ch1Row = GetARowStringByTag("ch1", "tMidiOutChannel");
            DataRow[] ch2Row = GetARowStringByTag("ch2", "tMidiOutChannel");
            DataRow[] ch3Row = GetARowStringByTag("ch3", "tMidiOutChannel");
            DataRow[] ch4Row = GetARowStringByTag("ch4", "tMidiOutChannel");
            DataRow[] ch5Row = GetARowStringByTag("ch5", "tMidiOutChannel");

            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch0Row[0]);
            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch1Row[0]);
            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch2Row[0]);
            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch3Row[0]);
            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch4Row[0]);
            dataSetPresets.Tables["tMidiOutChannel"].Rows.Remove(ch5Row[0]);

            DataRow[] beqRow        = GetARowStringByTag("Equalizer", "tEqualizerMain");

            DataRow[] lowerRow      = GetARowStringByTag("Lowest", "tEqualizer");
            DataRow[] lowRow        = GetARowStringByTag("Lower", "tEqualizer");
            DataRow[] highRow       = GetARowStringByTag("Higher", "tEqualizer");
            DataRow[] highestRow    = GetARowStringByTag("Highest", "tEqualizer");

            dataSetPresets.Tables["tEqualizerMain"].Rows.Remove(beqRow[0]);
            dataSetPresets.Tables["tEqualizer"].Rows.Remove(lowerRow[0]);
            dataSetPresets.Tables["tEqualizer"].Rows.Remove(lowRow[0]);
            dataSetPresets.Tables["tEqualizer"].Rows.Remove(highRow[0]);
            dataSetPresets.Tables["tEqualizer"].Rows.Remove(highestRow[0]);

            //getting and setting presets parameters
            TreeNode tRev = GetParentNode("nodeReverb");
            TreeNode tCom = GetParentNode("nodeCompression");
            TreeNode tContr = GetParentNode("nodeControl");
            TreeNode tDel = GetParentNode("nodeDelay");
            TreeNode tDistr = GetParentNode("nodeDistortion");
            TreeNode tMixr = GetParentNode("nodeMixer");
            TreeNode tMod = GetParentNode("nodeModulation");
            TreeNode tVo = GetParentNode("nodeVoice");

            foreach (TreeNode trn in tRev.Nodes)
            {
                DataRow[] revRow = GetARowStringByTag(trn.Tag.ToString(), "tReverberation");

                dataSetPresets.Tables["tReverberation"].Rows.Remove(revRow[0]);

                trView.Nodes.Remove(trn);
            }

            foreach (TreeNode tcm in tCom.Nodes)
            {
                DataRow[] tcmRow = GetARowStringByTag(tcm.Tag.ToString(), "tCompression");

                dataSetPresets.Tables["tCompression"].Rows.Remove(tcmRow[0]);

                trView.Nodes.Remove(tcm);
            }

            foreach (TreeNode tctr in tContr.Nodes)
            {
                DataRow[] tctrRow = GetARowStringByTag(tctr.Tag.ToString(), "tControl");

                dataSetPresets.Tables["tCompression"].Rows.Remove(tctrRow[0]);

                trView.Nodes.Remove(tctr);
            }

            foreach (TreeNode tdl in tDel.Nodes)
            {
                DataRow[] tdlRow = GetARowStringByTag(tdl.Tag.ToString(), "tDelay");

                dataSetPresets.Tables["tDelay"].Rows.Remove(tdlRow[0]);

                trView.Nodes.Remove(tdl);
            }

            foreach (TreeNode tds in tDistr.Nodes)
            {
                DataRow[] tctrRow = GetARowStringByTag(tds.Tag.ToString(), "tDistortion");

                dataSetPresets.Tables["tDistortion"].Rows.Remove(tctrRow[0]);

                trView.Nodes.Remove(tds);
            }

            foreach (TreeNode txmr in tMixr.Nodes)
            {
                DataRow[] txmrRow = GetARowStringByTag(txmr.Tag.ToString(), "tMixer");

                dataSetPresets.Tables["tMixer"].Rows.Remove(txmrRow[0]);

                trView.Nodes.Remove(txmr);
            }

            foreach (TreeNode tm in tMod.Nodes)
            {
                DataRow[] tmRow = GetARowStringByTag(tm.Tag.ToString(), "tModulation");

                dataSetPresets.Tables["tModulation"].Rows.Remove(tmRow[0]);

                trView.Nodes.Remove(tm);
            }

            foreach (TreeNode tv in tVo.Nodes)
            {
                DataRow[] tvRow = GetARowStringByTag(tv.Tag.ToString(), "tVoice");

                dataSetPresets.Tables["tVoice"].Rows.Remove(tvRow[0]);

                trView.Nodes.Remove(tv);
            }

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

        //we have to add some node 
        private void AddNodeByType(string NodeType, string nodeParentName, string tableName, XmlNode xmlPar = null) {
            TreeNode tns = treeViewXML.Nodes.Find(NodeType, true).FirstOrDefault();

            treeViewXML.SelectedNode = tns;
            int NodeCount            = treeViewXML.SelectedNode.GetNodeCount(true);
            string namePrefix        = (NodeCount == 0) ? "1" : (NodeCount + 1).ToString();

            TreeNode tNewNode   = new TreeNode(nodeParentName + namePrefix);
            tNewNode.Tag        = NodeType + namePrefix;

            

            DataRow rNewRow = dataSetPresets.Tables[tableName].NewRow();
            rNewRow["tag"]  = NodeType + namePrefix;

            if (xmlPar!= null)            
            {
                //set value if exists
                if (xmlPar.Attributes.GetNamedItem("prid") != null) {
                    tNewNode.Name   = xmlPar.Attributes["prid"].Value;
                    tNewNode.Text   = xmlPar.Attributes["prid"].Value;
                };

                setPresetsParamsFromXML(xmlPar, rNewRow, nodeParentName);
            }

            treeViewXML.SelectedNode.Nodes.Add(tNewNode);

            dataSetPresets.Tables[tableName].Rows.Add(rNewRow);
        }

        private void setPresetsParamsFromXML(XmlNode xmlParam, DataRow rNewRow, string pType) {

            switch (pType)
            {      
                case "t1":
                    break;
                case "t2":                  
                    break;
                case "t3":               
                    break;
                case "t4":     
                    break;
                case "t5":  
                    break;
                case "t6":
                    break;
                case "ch1":
                    break;
                case "ch2":
                    break;
                case "ch3":
                    break;
                case "ch4": 
                    break;
                case "ch5":               
                    break;
                case "ch6":
                    break;
                case "Master":
                    break;
                case "Volume":
                    rNewRow["masterVolume"] = Convert.ToDecimal(xmlParam.Attributes["volume"].Value);
                    break;
                case "Reverberation":
                    rNewRow["rType"]                = Convert.ToDecimal(xmlParam.Attributes["type"].Value);
                    rNewRow["rPre_lpf"]             = Convert.ToDecimal(xmlParam.Attributes["pre_lpf"].Value);
                    rNewRow["rLevel"]               = Convert.ToDecimal(xmlParam.Attributes["level"].Value);
                    rNewRow["rTime"]                = Convert.ToDecimal(xmlParam.Attributes["time"].Value);
                    rNewRow["rDelayFeedback"]       = Convert.ToDecimal(xmlParam.Attributes["delay_feedback"].Value);
                    rNewRow["pRreDelayTime"]        = Convert.ToDecimal(xmlParam.Attributes["pre_delay_time"].Value);
                    break;
                case "Delay":
                    break;
                case "Mixer":
                    break;
                case "Control":
                    break;
                case "Voice":
                    break;
                case "Modulation":
                    break;
                case "Compression":
                    break;
                case "MidiOutChannel":
                    break;
                case "Equalizer":
                    if (xmlParam.Attributes["on"].Value == "0")
                    {
                        rNewRow["on"] = false;
                    }
                    else 
                    {
                        rNewRow["on"] = true;
                    };

                    rNewRow["low_mid_q"]    = Convert.ToDecimal(xmlParam.Attributes["low_mid_q"].Value);
                    rNewRow["high_mid_q"]   = Convert.ToDecimal(xmlParam.Attributes["high_mid_q"].Value);              
                    break;
                case "Lowest":       
                    rNewRow["gain"]         = Convert.ToDecimal(xmlParam.Attributes["gain"].Value);
                    rNewRow["frequency"]    = Convert.ToDecimal(xmlParam.Attributes["frequency"].Value);
                    break;
                case "Lower":
                    rNewRow["gain"]         = Convert.ToDecimal(xmlParam.Attributes["gain"].Value);
                    rNewRow["frequency"]    = Convert.ToDecimal(xmlParam.Attributes["frequency"].Value);
                    break;
                case "Higher":
                    rNewRow["gain"]         = Convert.ToDecimal(xmlParam.Attributes["gain"].Value);
                    rNewRow["frequency"]    = Convert.ToDecimal(xmlParam.Attributes["frequency"].Value);
                    break;
                case "Highest":
                    rNewRow["gain"]         = Convert.ToDecimal(xmlParam.Attributes["gain"].Value);
                    rNewRow["frequency"]    = Convert.ToDecimal(xmlParam.Attributes["frequency"].Value);
                    break;
                default:
                    break;
            }
        }

        private TreeNode GetParentNode(string NodeType) {
            TreeNode tns = treeViewXML.Nodes.Find(NodeType, true).FirstOrDefault();

            return tns;
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

                    GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

            if (dResult == DialogResult.OK) 
            {
                MessageBox.Show("Your data has been changed!", "Ok");

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
            };
        }

        private void EditTuningData(string rTag)
        {
            DataRow[] findRow = GetARowStringByTag(rTag, "tTuning");

            this.drFind = findRow[0];

            TuningEdit tForm        = new TuningEdit(this);
            DialogResult dResult    = tForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Your data has been changed!", "Ok");

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
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

                GenerateXMLFilePreset(XMLTextBox, treeViewXML);
            };
        }

        private void AddMasterVolumeData(byte Volume=127, XmlNode xmlPar = null)
        {
            DataRow rNewRow             = dataSetPresets.Tables["tMaster"].NewRow();
            rNewRow["tag"]              = "Volume";
            rNewRow["MasterVolume"]     = Volume;

            if (xmlPar!= null) {
                setPresetsParamsFromXML(xmlPar, rNewRow, "Volume");
            };            

            dataSetPresets.Tables["tMaster"].Rows.Add(rNewRow);
        }

        private void AddBasicEqualizerData(XmlNode xmlPar = null)
        {
            DataRow rNewRow = dataSetPresets.Tables["tEqualizerMain"].NewRow();
            rNewRow["tag"]  = "Equalizer";

            if (xmlPar != null)
            {
                setPresetsParamsFromXML(xmlPar, rNewRow, "Equalizer");
            };

            dataSetPresets.Tables["tEqualizerMain"].Rows.Add(rNewRow);
        }

        private void AddEqualizerData(string equalizerVolume, XmlNode xmlPar = null)
        {
            DataRow rNewRow = dataSetPresets.Tables["tEqualizer"].NewRow();
            rNewRow["tag"]  = equalizerVolume;

            if (xmlPar != null)
            {
                setPresetsParamsFromXML(xmlPar, rNewRow, equalizerVolume);
            };

            dataSetPresets.Tables["tEqualizer"].Rows.Add(rNewRow);
        }

        private void AddMidiOutChannel(string midiChannel, XmlNode xmlPar = null)
        {
            DataRow rNewRow = dataSetPresets.Tables["tMidiOutChannel"].NewRow();
            rNewRow["tag"]  = midiChannel;

            if (xmlPar != null)
            {
                setPresetsParamsFromXML(xmlPar, rNewRow, midiChannel);
            };

            dataSetPresets.Tables["tMidiOutChannel"].Rows.Add(rNewRow);
        }

        private void AddTuning(string tuningChannel, XmlNode xmlPar = null)
        {
            DataRow rNewRow = dataSetPresets.Tables["tTuning"].NewRow();
            rNewRow["tag"]  = tuningChannel;

            if (xmlPar != null)
            {
                setPresetsParamsFromXML(xmlPar, rNewRow, tuningChannel);
            };

            dataSetPresets.Tables["tTuning"].Rows.Add(rNewRow);
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
                case "Tuning":
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
                    chResult = true;
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
                case "Tuning":
                    EditTuningData(tNode.Tag.ToString());
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
            if (treeViewXML.SelectedNode.Parent == null) {
                return;
            }

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

        private void treeViewXML_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == "") {
                e.CancelEdit = true;
            }
        }
    }
}
