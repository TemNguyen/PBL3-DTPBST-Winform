﻿using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            SetUserInfor();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            gbUser.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            Close();
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
        private void SetUserInfor()
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            List<string> userInfor = new List<string>(File.ReadAllLines(path));
            if (userInfor[3] != "") btnAccountInfo.Text = userInfor[3];
            else btnAccountInfo.Text = userInfor[1];
            lbAccount.Text = userInfor[1];
            txtName.Text = userInfor[3];
            txtEmail.Text = userInfor[4];
            if (checkBox1.Checked)
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

        private void Level1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {   
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            List<string> userInfor = new List<string>(File.ReadAllLines(path));
            string oldPass = userInfor[2];
            if (checkBox1.Checked)
            {
                if (IsValid() == false)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại thông tin tài khoản!");
                    return;
                }
                else if (String.Compare(txtOldPass.Text, oldPass) > 0)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!");
                    return;
                }    
                else
                    oldPass = txtNewPass.Text;
            }
            UserInfo user = new UserInfo()
            {
                UserID = Convert.ToInt32(userInfor[0]),
                Username = userInfor[1],
                Password = oldPass,
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            if (BLL.Instance.UpdateUserInfor(user))
            {
                //Hiện Form thông báo.
                MessageBox.Show("Cập nhập thông tin thành công");
                //Cập nhập lại txtAccount
                string userLogin = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
                using (StreamWriter sw = File.CreateText(userLogin))
                {
                    sw.WriteLine(user.UserID);
                    sw.WriteLine(user.Username);
                    sw.WriteLine(user.Password);
                    sw.WriteLine(user.Name);
                    sw.WriteLine(user.Email);
                }
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtRePass.Text = "";
                checkBox1.Checked = false;
            }
            else
            {
                //Hiện Form thông báo.
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau");
            }
            SetUserInfor();
        }
        private bool IsValid()
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtRePass.Text == "") return false;
            if (String.Compare(txtNewPass.Text, txtRePass.Text) > 0) return false;
            return true;
        }
    }
}
