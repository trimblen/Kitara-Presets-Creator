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
    public partial class ControlEdit : Form
    {
        private PresetForm _pFrm;

        public ControlEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void ControlEdit_Load(object sender, EventArgs e)
        {
            numType.Value                   = this._pFrm.drFind.Field<Decimal>("type");
            numName.Value                   = this._pFrm.drFind.Field<Decimal>("name");
            numString.Value                 = this._pFrm.drFind.Field<Decimal>("string");
            numIndex.Value                  = this._pFrm.drFind.Field<Decimal>("index");
            numOutput.Value                 = this._pFrm.drFind.Field<Decimal>("output");
            numChannel.Value                = this._pFrm.drFind.Field<Decimal>("channel");
            numCc.Value                     = this._pFrm.drFind.Field<Decimal>("cc");
            numInverse.Value                = this._pFrm.drFind.Field<Decimal>("inverse");
            numVariation_start.Value        = this._pFrm.drFind.Field<Decimal>("variation_start");
            numVariation_end.Value          = this._pFrm.drFind.Field<Decimal>("variation_end");
            numFxb.Value                    = this._pFrm.drFind.Field<Decimal>("fxb");
            numDrag_center.Value            = this._pFrm.drFind.Field<Decimal>("drag_center"); 
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numType.Value);
            this._pFrm.drFind.SetField(2, numName.Value);
            this._pFrm.drFind.SetField(3, numString.Value);
            this._pFrm.drFind.SetField(4, numIndex.Value);

            this._pFrm.drFind.SetField(5, numOutput.Value);
            this._pFrm.drFind.SetField(6, numChannel.Value);
            this._pFrm.drFind.SetField(7, numCc.Value);
            this._pFrm.drFind.SetField(8, numInverse.Value);
            this._pFrm.drFind.SetField(9, numVariation_start.Value);
            this._pFrm.drFind.SetField(10, numVariation_end.Value);
            this._pFrm.drFind.SetField(11, numFxb.Value);
            this._pFrm.drFind.SetField(12, numDrag_center.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
