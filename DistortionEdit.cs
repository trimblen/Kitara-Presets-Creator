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
    public partial class DistortionEdit : Form
    {
        private PresetForm _pFrm;

        public DistortionEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void DistortionEdit_Load(object sender, EventArgs e)
        {
            numFxblock.Value            = this._pFrm.drFind.Field<Decimal>("fxblock");
            chOn.Checked                = this._pFrm.drFind.Field<Boolean>("on");
            numType.Value               = this._pFrm.drFind.Field<Decimal>("type");
            numLevel.Value              = this._pFrm.drFind.Field<Decimal>("level");
            numDrive.Value              = this._pFrm.drFind.Field<Decimal>("drive");
            numTone.Value               = this._pFrm.drFind.Field<Decimal>("tone");
            numBooster.Value            = this._pFrm.drFind.Field<Decimal>("booster");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numFxblock.Value);
            this._pFrm.drFind.SetField(2, chOn.Checked);
            this._pFrm.drFind.SetField(3, numType.Value);
            this._pFrm.drFind.SetField(4, numLevel.Value);

            this._pFrm.drFind.SetField(5, numDrive.Value);
            this._pFrm.drFind.SetField(6, numTone.Value);
            this._pFrm.drFind.SetField(7, numBooster.Value);
      
            this.DialogResult = DialogResult.OK;
        }
           
    }
}
