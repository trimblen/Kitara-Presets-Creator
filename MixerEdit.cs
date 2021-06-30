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
    public partial class MixerEdit : Form
    {
        private PresetForm _pFrm;

        public MixerEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void MixerEdit_Load(object sender, EventArgs e)
        {
            numFxblock.Value                = this._pFrm.drFind.Field<Decimal>("fxblock");
            numLowCutFilterLrequency.Value  = this._pFrm.drFind.Field<Decimal>("low_cut_filter_frequency");
            numHighCutFilterFrequency.Value = this._pFrm.drFind.Field<Decimal>("high_cut_filter_frequency");
            numInputGain.Value              = this._pFrm.drFind.Field<Decimal>("input_gain");
            numOutputLevel.Value            = this._pFrm.drFind.Field<Decimal>("output_level");
            numPan.Value                    = this._pFrm.drFind.Field<Decimal>("pan");
            numReverbSend.Value             = this._pFrm.drFind.Field<Decimal>("reverb_send");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numFxblock.Value);
            this._pFrm.drFind.SetField(2, numLowCutFilterLrequency.Value);
            this._pFrm.drFind.SetField(3, numHighCutFilterFrequency.Value);
            this._pFrm.drFind.SetField(4, numInputGain.Value);

            this._pFrm.drFind.SetField(5, numOutputLevel.Value);
            this._pFrm.drFind.SetField(6, numPan.Value);
            this._pFrm.drFind.SetField(7, numReverbSend.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
