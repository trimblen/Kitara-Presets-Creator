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
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abtFrm = new AboutForm();

            abtFrm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd_OpenFile.Filter             = "Kitara Preset Files (*.mz)|*.mz";
            ofd_OpenFile.DefaultExt         = "mz";
            ofd_OpenFile.InitialDirectory   = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ofd_OpenFile.Filter             = "Kitara Preset Files (*.mz)|*.mz";
            ofd_OpenFile.FilterIndex        = 1;
            ofd_OpenFile.FileName           = string.Empty;

            if (ofd_OpenFile.ShowDialog() == DialogResult.OK)
            {
                PresetForm loadPresetForm;
                if (this.ActiveMdiChild != null)
                {
                    loadPresetForm = (PresetForm)this.ActiveMdiChild;
                    loadPresetForm.file_Path = ofd_OpenFile.FileName;
                    loadPresetForm.Load_File();
                }
                else
                {
                    loadPresetForm = new PresetForm();
                    loadPresetForm.file_Path = ofd_OpenFile.FileName;
                    loadPresetForm.MdiParent = this;
                    loadPresetForm.Show();
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void closeToolStripCloseWindow_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void saveToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                PresetForm pForm = (PresetForm)this.ActiveMdiChild;

                pForm.Save_File();
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PresetForm frm in this.MdiChildren)
            {
                frm.Save_File();
            }
        }
    }
}
