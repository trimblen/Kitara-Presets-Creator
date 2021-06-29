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

        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
