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
    public partial class User : Form
    {
        private static bool sttRanked = false;

        public User()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            gbUser.Visible = true;
        }

        private void btnExitRanked_Click(object sender, EventArgs e)
        {
            gbRanked.Visible = false;
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            gbRanked.Visible = true;
        }

        private void btnExitFeedback_Click(object sender, EventArgs e)
        {
            gbFeedback.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            gbFeedback.Visible = true;
        }

        private void btnSendFb_Click(object sender, EventArgs e)
        {
            //
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            txtFeedback.SelectionStart = txtFeedback.Text.Length;
            txtFeedback.ScrollToCaret();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtOldPass.Enabled = true;
                txtNewPass.Enabled = true;
                txtRePass.Enabled = true;
            }
            else
            {
                txtOldPass.Enabled = false;
                txtNewPass.Enabled = false;
                txtRePass.Enabled = false;
            }
        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
        }

        private void Level1_Click(object sender, EventArgs e)
        {

        }
    }
}
