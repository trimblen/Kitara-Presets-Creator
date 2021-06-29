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

        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
