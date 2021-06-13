using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitaraPresetsCreator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresetForm newMDIChild = new PresetForm();

            newMDIChild.MdiParent = this;         
            newMDIChild.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abtFrm = new AboutForm();

            abtFrm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog   = new OpenFileDialog();
            openFileDialog.DefaultExt       = "mz";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter           = "Kitara Preset Files (*.mz)|*.mz";
            openFileDialog.FilterIndex      = 1;
            openFileDialog.FileName         = string.Empty;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {

                if (openFileDialog.FileName == "")
                {
                    return;
                }
                
                PresetForm loadPresetForm   = new PresetForm(false, openFileDialog.FileName);
                loadPresetForm.MdiParent    = this;

                loadPresetForm.Show();

            }

            else
            {
                MessageBox.Show("Open File request cancelled by user.",
                "Cancelled");
            }

        }
    
    }
}
