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
    public partial class CompressionEdit : Form
    {
        private PresetForm _pFrm;

        public CompressionEdit(PresetForm pFrm)
        {        
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void CompressionEdit_Load(object sender, EventArgs e)
        {
            numFxblock.Value        = this._pFrm.drFind.Field<Decimal>("fxblock");                
            chOn.Checked            = this._pFrm.drFind.Field<Boolean>("on");
            numAttack.Value         = this._pFrm.drFind.Field<Decimal>("attack");
            numRelease.Value        = this._pFrm.drFind.Field<Decimal>("release");             
            numThreshold.Value      = this._pFrm.drFind.Field<Decimal>("threshold");            
            numRatio.Value          = this._pFrm.drFind.Field<Decimal>("ratio");  
            numBoost.Value          = this._pFrm.drFind.Field<Decimal>("boost");   
            numKnee.Value           = this._pFrm.drFind.Field<Decimal>("knee");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numFxblock.Value);
            this._pFrm.drFind.SetField(2, chOn.Checked);
            this._pFrm.drFind.SetField(3, numAttack.Value);
            this._pFrm.drFind.SetField(4, numRelease.Value);

            this._pFrm.drFind.SetField(5, numThreshold.Value);
            this._pFrm.drFind.SetField(6, numRatio.Value);
            this._pFrm.drFind.SetField(7, numBoost.Value);
            this._pFrm.drFind.SetField(8, numKnee.Value);

            this.DialogResult = DialogResult.OK;
        }

     
    }
}
