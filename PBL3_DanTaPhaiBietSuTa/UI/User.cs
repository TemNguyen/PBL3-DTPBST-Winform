using PBL3_DanTaPhaiBietSuTa.DTO;
using PBL3_DanTaPhaiBietSuTa.UI;
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

namespace PBL3_DanTaPhaiBietSuTa
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            ShowUserInfor();
            ShowBXH();
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
            gbLevel.Visible = false;
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
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            List<string> userInfor = new List<string>(File.ReadAllLines(path));
            string oldPass = userInfor[2];
            if (IsValid() == false) return;
            if (checkBox1.Checked)
            {
                if (String.Compare(txtOldPass.Text, oldPass) != 0)
                {
                    ShowMessage("Mật khẩu hiện tại không đúng!");
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
                ShowMessage("Cập nhập thông tin thành công");
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
                ShowMessage("Có lỗi xảy ra, vui lòng thử lại sau!");
            }
            ShowUserInfor();
        }
        private void btnExitUser_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbLevel.Visible = true;
        }
        private void btnRank_Click(object sender, EventArgs e)
        {
            gbRanked.Visible = true;
            gbLevel.Visible = false;
        }
        private void btnExitRanked_Click(object sender, EventArgs e)
        {
            gbRanked.Visible = false;
            gbLevel.Visible = true;
        }
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            gbFeedback.Visible = true;
            gbLevel.Visible = false;
        }
        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            txtFeedback.SelectionStart = txtFeedback.Text.Length;
            txtFeedback.ScrollToCaret();
        }
        private void btnSendFb_Click(object sender, EventArgs e)
        {
            if (txtFeedback.Text == "")
            {
                ShowMessage("Vui lòng nhập feedback!");
                return;
            }
            else
            {
                DateTime d = DateTime.Now;
                string path = @Application.StartupPath + @"\Assets\FeedBack\" + d.ToString("dddd, dd MMMM yyyy HH-mm-ss") + ".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(btnAccountInfo.Text + "   " + d.ToString());
                    sw.Write(txtFeedback.Text);
                }
                ShowMessage("Cảm ơn bạn đã gửi FeedBack!");
            }
            txtFeedback.Text = "";
        }
        private void btnExitFeedback_Click(object sender, EventArgs e)
        {
            gbFeedback.Visible = false;
            gbLevel.Visible = true;
        }
        private void Level1_Click(object sender, EventArgs e)
        {
            Play p = new Play();
            p.Show();
            Close();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }
        private void ShowUserInfor()
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            List<string> userInfor = new List<string>(File.ReadAllLines(path));
            Standing userStand = BLL.Instance.GetStandingByUserID(Convert.ToInt32(userInfor[0]));
            if (userInfor[3] != "") btnAccountInfo.Text = userInfor[3];
            else btnAccountInfo.Text = userInfor[1];
            lbAccount.Text = userInfor[1];
            txtName.Text = userInfor[3];
            txtEmail.Text = userInfor[4];
            if (BLL.Instance.GetRankByUserID(Convert.ToInt32(userInfor[0])) == -1)
            {
                lbRanked.Text = "Chưa có xếp hạng!";
            }
            else
                lbRanked.Text = BLL.Instance.GetRankByUserID(Convert.ToInt32(userInfor[0])).ToString();
            lbPoint.Text = userStand.Point.ToString();
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
        private bool IsValid()
        {
            List<char> list = new List<char>()
            {
                '`', '~', '!', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=',
                '{', '[', ']', '}', '|', ';', ':', ',', '<', '>', '/', '?'
            };
            if (checkBox1.Checked)
            {
                if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtRePass.Text == "")
                {
                    ShowMessage("Vui lòng điền đủ thông tin!");
                    return false;
                }
                if (String.Compare(txtNewPass.Text, txtRePass.Text) != 0)
                {
                    ShowMessage("Mật khẩu mới không khớp!");
                    return false;
                }
            }
            foreach (var l in list)
            {
                if (txtEmail.Text.Contains(l))
                {
                    ShowMessage("Email không thể chứa các ký tự `,~,!,..");
                    return false;
                }
            }
            if (!txtEmail.Text.Contains("@"))
            {
                ShowMessage("Địa chỉ Email phải chứa ký tự @");
                return false;
            }
            if (txtEmail.Text.Substring(0, 1) == "@")
            {
                ShowMessage("Email không thể bắt đầu bằng ký tự @");
                return false;
            }
            return true;
        }
        private void ShowBXH()
        {
            try
            {
                List<Standing> standings = BLL.Instance.SortListStandings();
                lb1Acc.Text = GetUserByUserID(standings[0].UserID);
                lb1Level.Text = standings[0].StageID.ToString();
                lb1Point.Text = standings[0].Point.ToString();

                lb2Acc.Text = GetUserByUserID(standings[1].UserID);
                lb2Level.Text = standings[1].StageID.ToString();
                lb2Point.Text = standings[1].Point.ToString();

                lb3Acc.Text = GetUserByUserID(standings[2].UserID);
                lb3Level.Text = standings[2].StageID.ToString();
                lb3Point.Text = standings[2].Point.ToString();

                lb4Acc.Text = GetUserByUserID(standings[3].UserID);
                lb4Level.Text = standings[3].StageID.ToString();
                lb4Point.Text = standings[3].Point.ToString();

                lb5Acc.Text = GetUserByUserID(standings[4].UserID);
                lb5Level.Text = standings[4].StageID.ToString();
                lb5Point.Text = standings[4].Point.ToString();
            }
            catch(Exception) { };
        }
        private string GetUserByUserID(int userID)
        {
            UserInfo user = BLL.Instance.GetUserInfoByUserID(userID);
            return user.Username;
        }
        private void ShowMessage(string message)
        {
            Notification notification = new Notification();
            notification.Get(message);
            notification.ShowDialog();
        }
    }
}
