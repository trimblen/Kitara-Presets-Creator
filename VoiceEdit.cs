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
    public partial class VoiceEdit : Form
    {
        private PresetForm _pFrm;

        public VoiceEdit(PresetForm pFrm)
        {
            InitializeComponent();

            this._pFrm = pFrm;
        }

        private void VoiceEdit_Load(object sender, EventArgs e)
        {
            numString.Value                     = this._pFrm.drFind.Field<Decimal>("string");
            textWaveId.Text                     = this._pFrm.drFind.Field<String>("wave_id");
            numAmplitudeAttack.Value            = this._pFrm.drFind.Field<Decimal>("amplitude_attack");
            numAmplitudeDecay.Value             = this._pFrm.drFind.Field<Decimal>("amplitude_decay");
            numAmplitudeRelease.Value           = this._pFrm.drFind.Field<Decimal>("amplitude_release");
            numDetuneCourse.Value               = this._pFrm.drFind.Field<Decimal>("detune_course");
            numDetuneFine.Value                 = this._pFrm.drFind.Field<Decimal>("detune_fine");
            numVibrateRate.Value                = this._pFrm.drFind.Field<Decimal>("vibrate_rate");
            numVibrateDepth.Value               = this._pFrm.drFind.Field<Decimal>("vibrate_depth");
            numVibrateDelay.Value               = this._pFrm.drFind.Field<Decimal>("vibrate_delay");
            numChannelVolume.Value              = this._pFrm.drFind.Field<Decimal>("channel_volume");
            numPortamentoTime.Value             = this._pFrm.drFind.Field<Decimal>("portamento_time");
            numPan.Value                        = this._pFrm.drFind.Field<Decimal>("pan");
            numPitchBendSemitones.Value         = this._pFrm.drFind.Field<Decimal>("pitch_bend_semitones");
            numpPitchWheel.Value                = this._pFrm.drFind.Field<Decimal>("pitch_wheel");
            numVelocity.Value                   = this._pFrm.drFind.Field<Decimal>("velocity");
            chFxb0_on.Checked                   = this._pFrm.drFind.Field<Boolean>("fxb0_on");
            chFxb1_on.Checked                   = this._pFrm.drFind.Field<Boolean>("fxb1_on");
            numReverbSend.Value                 = this._pFrm.drFind.Field<Decimal>("reverb_send");
            numFilterFrequency.Value            = this._pFrm.drFind.Field<Decimal>("filter_frequency");
            numFilterResonance.Value            = this._pFrm.drFind.Field<Decimal>("filter_resonance");
            numFilterType.Value                 = this._pFrm.drFind.Field<Decimal>("filter_type");
            numFilterAttack.Value               = this._pFrm.drFind.Field<Decimal>("filter_attack");
            numFilterDecay.Value                = this._pFrm.drFind.Field<Decimal>("filter_decay");
            numFilterRelease.Value              = this._pFrm.drFind.Field<Decimal>("filter_release");
        }

        private void buttSave_Click(object sender, EventArgs e)
        {
            this._pFrm.drFind.SetField(1, textWaveId.Text);
            this._pFrm.drFind.SetField(2, numAmplitudeAttack.Value);
            this._pFrm.drFind.SetField(3, numAmplitudeDecay.Value);
            this._pFrm.drFind.SetField(4, numAmplitudeRelease.Value);

            this._pFrm.drFind.SetField(5, numDetuneCourse.Value);
            this._pFrm.drFind.SetField(6, numDetuneFine.Value);
            this._pFrm.drFind.SetField(7, numVibrateRate.Value);
            this._pFrm.drFind.SetField(8, numVibrateDepth.Value);

            this._pFrm.drFind.SetField(9,  numVibrateDelay.Value);
            this._pFrm.drFind.SetField(10, numChannelVolume.Value);
            this._pFrm.drFind.SetField(11, numPortamentoTime.Value);
            this._pFrm.drFind.SetField(12, numPan.Value);

            this._pFrm.drFind.SetField(13, numPitchBendSemitones.Value);
            this._pFrm.drFind.SetField(14, numpPitchWheel.Value);
            this._pFrm.drFind.SetField(15, chFxb0_on.Checked);
            this._pFrm.drFind.SetField(16, chFxb1_on.Checked);

            this._pFrm.drFind.SetField(17, numReverbSend.Value);
            this._pFrm.drFind.SetField(18, numFilterFrequency.Value);
            this._pFrm.drFind.SetField(19, numFilterResonance.Value);
            this._pFrm.drFind.SetField(20, numFilterType.Value);

            this._pFrm.drFind.SetField(21, numFilterAttack.Value);
            this._pFrm.drFind.SetField(22, numFilterDecay.Value);
            this._pFrm.drFind.SetField(23, numFilterRelease.Value);
            this._pFrm.drFind.SetField(24, numString.Value);
                        
            this.DialogResult = DialogResult.OK;
        }
      
    }
}
