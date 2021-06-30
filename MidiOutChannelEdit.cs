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
    public partial class MidiOutChannelEdit : Form
    {
        private PresetForm _pFrm;

        public MidiOutChannelEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void MidiOutChannelEdit_Load(object sender, EventArgs e)
        {
            numMidiOut.Value = this._pFrm.drFind.Field<Decimal>("value");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, numMidiOut.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
