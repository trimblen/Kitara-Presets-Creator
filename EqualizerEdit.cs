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
    public partial class EqualizerEdit : Form
    {
        private PresetForm _pFrm;

        public EqualizerEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void EqualizerEdit_Load(object sender, EventArgs e)
        {
            numGain.Value       = this._pFrm.drFind.Field<Decimal>("gain");
            numFrequency.Value  = this._pFrm.drFind.Field<Decimal>("frequency");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numGain.Value);
            this._pFrm.drFind.SetField(2, numFrequency.Value);

            this.DialogResult = DialogResult.OK;
        }   
    }
}
