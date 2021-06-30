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
    public partial class DelayEdit : Form
    {
        private PresetForm _pFrm;

        public DelayEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void DelayEdit_Load(object sender, EventArgs e)
        {
            numFxblock.Value        = this._pFrm.drFind.Field<Decimal>("fxblock");
            chOn.Checked            = this._pFrm.drFind.Field<Boolean>("on");
            numMode.Value           = this._pFrm.drFind.Field<Decimal>("mode");
            numPreLp.Value          = this._pFrm.drFind.Field<Decimal>("pre_lp");
            numLevel.Value          = this._pFrm.drFind.Field<Decimal>("level");
            numTime.Value           = this._pFrm.drFind.Field<Decimal>("time");
            numFeedback.Value       = this._pFrm.drFind.Field<Decimal>("feedback");
            numFeedbackFilter.Value = this._pFrm.drFind.Field<Decimal>("feedback_filter");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numFxblock.Value);
            this._pFrm.drFind.SetField(2, chOn.Checked);
            this._pFrm.drFind.SetField(3, numMode.Value);
            this._pFrm.drFind.SetField(4, numPreLp.Value);

            this._pFrm.drFind.SetField(5, numLevel.Value);
            this._pFrm.drFind.SetField(6, numTime.Value);
            this._pFrm.drFind.SetField(7, numFeedback.Value);
            this._pFrm.drFind.SetField(8, numFeedbackFilter.Value);
  
            this.DialogResult = DialogResult.OK;
        }
    }
}
