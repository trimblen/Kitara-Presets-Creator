using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitaraPresetsCreator
{
    public partial class ReverberationEdit : Form
    {
        private PresetForm _pFrm;

        public ReverberationEdit(PresetForm pFrm)
        {           
           InitializeComponent();

           this._pFrm = pFrm;
        }

        private void ReverberationEdit_Load(object sender, EventArgs e)
        {
            rTypeNumber.Value           = this._pFrm.drFind.Field<Decimal>("rType");                //Convert.ToDecimal(this._pFrm.drFind.ItemArray[0]);
            rPrelpf.Value               = this._pFrm.drFind.Field<Decimal>("rPre_lpf");            //Convert.ToDecimal(this._pFrm.drFind.ItemArray[1]);
            rLev.Value                  = this._pFrm.drFind.Field<Decimal>("rLevel");             //Convert.ToDecimal(this._pFrm.drFind.ItemArray[2]);
            rTime.Value                 = this._pFrm.drFind.Field<Decimal>("rTime");             //Convert.ToDecimal(this._pFrm.drFind.ItemArray[3]);
            rDelayFeedback.Value        = this._pFrm.drFind.Field<Decimal>("rDelayFeedback");   //Convert.ToDecimal(this._pFrm.drFind.ItemArray[4]);
            rDelTime.Value              = this._pFrm.drFind.Field<Decimal>("pRreDelayTime");   //Convert.ToDecimal(this._pFrm.drFind.ItemArray[6]);
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(0, rTypeNumber.Value);
            this._pFrm.drFind.SetField(1, rPrelpf.Value);
            this._pFrm.drFind.SetField(2, rLev.Value);
            this._pFrm.drFind.SetField(3, rTime.Value);
  
            this._pFrm.drFind.SetField(4, rDelayFeedback.Value);
            this._pFrm.drFind.SetField(6, rDelTime.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
