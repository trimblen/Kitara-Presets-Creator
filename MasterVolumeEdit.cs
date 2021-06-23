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
    public partial class MasterVolumeEdit : Form
    {
        private PresetForm _pFrm;

        public MasterVolumeEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void buttOk_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numericMasterVolume.Value);

            this.DialogResult = DialogResult.OK;
        }

        private void MasterVolumeEdit_Load(object sender, EventArgs e)
        {
            numericMasterVolume.Value = Convert.ToDecimal(this._pFrm.drFind.ItemArray[1]);       
        }
    }
}
