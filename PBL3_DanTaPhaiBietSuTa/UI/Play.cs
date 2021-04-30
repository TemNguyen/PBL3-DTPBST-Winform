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
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
