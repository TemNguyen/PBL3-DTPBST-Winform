using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_DanTaPhaiBietSuTa.UI;

namespace PBL3_DanTaPhaiBietSuTa
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            //Rectangle r = new Rectangle(0, 0, Setting.Width, Setting.Height);
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, Setting.Width+30, Setting.Height+30);
            //Region rg = new Region(gp);
            //Setting.Region = rg;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }

        private void txtLoginR_Click(object sender, EventArgs e)
        {
            gbRegister.Visible = false;
            gbLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            gbLogin.Visible = false;
            gbRegister.Visible = true;
        }
    }
}
