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
        private bool pIsNew;
        private string fPath;

        public PresetForm(bool isNew, string filePath)
        {
            InitializeComponent();

            this.pIsNew = isNew;
            this.fPath  = filePath;
        }

        private void PresetForm_Load(object sender, EventArgs e)
        {
            dataSetPresets.BeginInit();

            Parse(this.pIsNew, this.fPath);
        }

        private void XMLTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTextHighLight(XMLTextBox);
        }

        private void Parse(bool isnewPrst, string pPath)
        {
            if (isnewPrst) {

                System.IO.StreamReader mzReader;

                mzReader = new System.IO.StreamReader(pPath);
            }

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
                String[] keywords = { "public", "void", "using", "static", "class", "tuning", "preset" };
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
                treeViewXML.Nodes.Clear();
                // Create the root tree node, on any XML file the container (first root)
                // will be the DocumentElement name as any content must be wrapped in some node first.
                treeViewXML.Nodes.Add(new TreeNode(dom.DocumentElement.Name));

                // 4. Create an instance of the first node in the treeview (the one that contains the DocumentElement name)
                TreeNode tNode = new TreeNode();
                tNode = treeViewXML.Nodes[0];

                // 5. Populate the TreeView with the DOM nodes with the helper 'AddNode' function
                this.AddNode(dom.DocumentElement, tNode);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void addCompressionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode();

          //  TreeNode[] tParent = treeViewXML.Nodes.Find("Compression", false);
            //tParent.
            treeViewXML.SelectedNode.Nodes.Add(newNode);
            newNode.EnsureVisible();
        }

        private void AddReverb_Click(object sender, EventArgs e)
        {            
           this.AddNodeByType("nodeReverb", "Reverberation", "tReverberation");            
        }

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

        private void setReverbDataInDataSetTemporarily(string revTab, SByte rType, SByte rPre_lpf, SByte rLevel, SByte rDelay_Feedback, SByte rPre_Delay_Time, string revTag) {

            DataRow[] findRow = GetARowStringByTag(revTab, revTab);

            if (findRow!=null) {
            
            
            } else 
            {

                DataRow rNewRow = dataSetPresets.Tables["tReverberation"].NewRow();

                rNewRow["revTab"] = revTab;

                dataSetPresets.Tables["tReverberation"].Rows.Add(rNewRow);

            }

        }

        private void EditReverbData(string rTag) {

            DataRow[] findRow = GetARowStringByTag(rTag, "tReverberation");

            this.drFind = findRow[0];
          
            ReverberationEdit revForm   = new ReverberationEdit(this);
            DialogResult dResult        =  revForm.ShowDialog();

            if (dResult == DialogResult.OK) {
                MessageBox.Show("Your data has been changed!", "Ok");
            };
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
                    break;
                case "Master":         
                    break;
                case "Reverberation":
                    EditReverbData(tNode.Tag.ToString());
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
                default:
                    break;
            }

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
    }
}
