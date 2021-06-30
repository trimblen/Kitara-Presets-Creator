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
    public partial class ModulationEdit : Form
    {
        private PresetForm _pFrm;

        public ModulationEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void ModulationEdit_Load(object sender, EventArgs e)
        {
            numFxblock.Value                    = this._pFrm.drFind.Field<Decimal>("fxblock");
            chOn.Checked                        = this._pFrm.drFind.Field<Boolean>("on");
            numType.Value                       = this._pFrm.drFind.Field<Decimal>("type");
            numLevel.Value                      = this._pFrm.drFind.Field<Decimal>("level");
            numChorusDelayTime.Value            = this._pFrm.drFind.Field<Decimal>("chorus_delay_time");
            numChorusFeedback.Value             = this._pFrm.drFind.Field<Decimal>("chorus_feedback");
            numChorusHpf.Value                  = this._pFrm.drFind.Field<Decimal>("chorus_hpf");
            numRate.Value                       = this._pFrm.drFind.Field<Decimal>("rate");
            numDelayFeedbackFilter.Value        = this._pFrm.drFind.Field<Decimal>("delay_feedback_filter");
            numDepth.Value                      = this._pFrm.drFind.Field<Decimal>("depth");
            numTremolo.Value                    = this._pFrm.drFind.Field<Decimal>("tremolo");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numFxblock.Value);
            this._pFrm.drFind.SetField(2, chOn.Checked);
            this._pFrm.drFind.SetField(3, numType.Value);
            this._pFrm.drFind.SetField(4, numLevel.Value);

            this._pFrm.drFind.SetField(5, numChorusDelayTime.Value);
            this._pFrm.drFind.SetField(6, numChorusFeedback.Value);
            this._pFrm.drFind.SetField(7, numChorusHpf.Value);
            this._pFrm.drFind.SetField(8, numDelayFeedbackFilter.Value);
            this._pFrm.drFind.SetField(9, numRate.Value);
            this._pFrm.drFind.SetField(10, numDepth.Value);
            this._pFrm.drFind.SetField(11, numTremolo.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
