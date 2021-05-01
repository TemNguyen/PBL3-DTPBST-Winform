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

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    public partial class HomePage : Form
    {
        private static bool sttSetting = false;

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            if (true) //Kiểm tra có tk đã lưu chưa
            {
                DangNhap login = new DangNhap();
                login.ShowDialog();
            }
            else
            {
                //Nếu đã có tk đã lưu sẵn thì vô luôn form trong
            }
            this.Dispose();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (sttSetting == false)
            {
                btnHelp.Visible = true;
                btnInfo.Visible = true;
                sttSetting = true;
            }
            else
            {
                btnHelp.Visible = false;
                btnInfo.Visible = false;
                sttSetting = false;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            gbIntro.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbIntro.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbHelp.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            gbHelp.Visible = true;
        }
    }
}
