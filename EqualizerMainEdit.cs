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
    public partial class EqualizerMainEdit : Form
    {
        private PresetForm _pFrm;

        public EqualizerMainEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void EqualizerMainEdit_Load(object sender, EventArgs e)
        {
            chOn.Checked        = this._pFrm.drFind.Field<Boolean>("on");
            numLowMidQ.Value    = this._pFrm.drFind.Field<Decimal>("low_mid_q");
            numHighMidQ.Value   = this._pFrm.drFind.Field<Decimal>("high_mid_q");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numLowMidQ.Value);
            this._pFrm.drFind.SetField(2, numHighMidQ.Value);
            this._pFrm.drFind.SetField(3, chOn.Checked);

            this.DialogResult = DialogResult.OK;
        }
    }
}
