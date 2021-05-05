using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSoundOn_Click(object sender, EventArgs e)
        {
            HomePage.StopSound();
            btnSoundOff.Visible = true;
            btnSoundOn.Visible = false;
        }

        private void btnSoundOff_Click(object sender, EventArgs e)
        {
            HomePage.PlaySound();
            btnSoundOff.Visible = false;
            btnSoundOn.Visible = true;
        }

        private void btnMusicOn_Click(object sender, EventArgs e)
        {
            btnMusicOn.Visible = false;
            btnMusicOff.Visible = true;
        }

        private void btnMusicOff_Click(object sender, EventArgs e)
        {
            btnMusicOn.Visible = true;
            btnMusicOff.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
