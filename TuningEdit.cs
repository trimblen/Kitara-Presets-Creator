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
    public partial class TuningEdit : Form
    {
        private PresetForm _pFrm;

        public TuningEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void TuningEdit_Load(object sender, EventArgs e)
        {
            numValue.Value = this._pFrm.drFind.Field<Decimal>("value");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numValue.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
