using PBL3_DanTaPhaiBietSuTa.DTO;
using PBL3_DanTaPhaiBietSuTa.Properties;
using PBL3_DanTaPhaiBietSuTa.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DanTaPhaiBietSuTa
{
    public partial class User : Form
    {
        Thread threadLogout;
        Thread threadPlay;
        public User()
        {
            InitializeComponent();
            DisplayLevel();
            ShowUserInfor();
            ShowBXH();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            gbUser.Visible = true;
        }
        private void OpenLoginForm(object sender)
        {
            Application.Run(new DangNhap());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            threadLogout = new Thread(OpenLoginForm);
            threadLogout.SetApartmentState(ApartmentState.STA);
            threadLogout.Start();
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
            int userID = Convert.ToInt32(File.ReadLines(path).First());
            UserInfo userInfor = BLL.Instance.GetUserInfoByUserID(userID);
            string oldPass = userInfor.Password;
            if (IsValid() == false) return;
            if (checkBox1.Checked)
            {
                if (String.Compare(txtOldPass.Text, oldPass) != 0)
                {
                    ShowMessage("Mật khẩu hiện tại không đúng!");
                    return;
                }
                else if (String.Compare(txtOldPass.Text, txtNewPass.Text) == 0)
                {
                    ShowMessage("Mật khẩu mới trùng với mật khẩu cũ!");
                    return;
                }    
                else
                    oldPass = txtNewPass.Text;
            }
            UserInfo user = new UserInfo()
            {
                UserID = Convert.ToInt32(userInfor.UserID),
                Username = userInfor.Username,
                Password = oldPass,
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            if (BLL.Instance.UpdateUserInfor(user))
            {
                ShowMessage("Cập nhập thông tin thành công");
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtRePass.Text = "";
                checkBox1.Checked = false;
            }
            else
            {
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
            gbFeedback.Visible = false;
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
            gbRanked.Visible = false;
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
        private void ShowUserInfor()
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            int userID = Convert.ToInt32(File.ReadLines(path).First());
            UserInfo userInfor = BLL.Instance.GetUserInfoByUserID(userID);
            Standing userStand = BLL.Instance.GetStandingByUserID(Convert.ToInt32(userInfor.UserID));

            if (userInfor.Name != "") 
                btnAccountInfo.Text = userInfor.Name;
            else 
                btnAccountInfo.Text = userInfor.Username;

            lbAccount.Text = userInfor.Username;
            txtName.Text = userInfor.Name;
            txtEmail.Text = userInfor.Email;
            if (BLL.Instance.GetRankByUserID(Convert.ToInt32(userInfor.UserID)) == -1)
                lbRanked.Text = "Chưa có xếp hạng!";
            else
                lbRanked.Text = BLL.Instance.GetRankByUserID(Convert.ToInt32(userInfor.UserID)).ToString();

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
        private void OpenPlayForm(object sender)
        {
            Play play = new Play();
            Application.Run(play);
        }
        private void Level1_Click(object sender, EventArgs e)
        {
            ChooseLevel(1);
        }
        private void Level2_Click(object sender, EventArgs e)
        {
            ChooseLevel(2);
        }
        private void Level3_Click(object sender, EventArgs e)
        {
            ChooseLevel(3);
        }
        private void Level4_Click(object sender, EventArgs e)
        {
            ChooseLevel(4);
        }
        private void Level5_Click(object sender, EventArgs e)
        {
            ChooseLevel(5);
        }
        private void ChooseLevel(int stageID)
        {
            Play.stageID = stageID;
            HomePage.StopSound();
            this.Dispose();
            threadPlay = new Thread(OpenPlayForm);
            threadPlay.SetApartmentState(ApartmentState.STA);
            threadPlay.Start();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();
            setting.ShowDialog();
        }
        private void DisplayLevel()
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            string picPath = @Application.StartupPath + @"\Assets\Image\";
            int userID = Convert.ToInt32(File.ReadLines(path).First());
            Standing userStand = BLL.Instance.GetStandingByUserID(userID);
            int currentStage = userStand.StageID + 1;
            List<PictureBox> levels = new List<PictureBox>();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is PictureBox)
                {
                    levels.Add((PictureBox)c);
                }
            }
            //set default img
            foreach (var i in levels)
            {
                try
                {
                    i.Image = Image.FromFile(picPath + i.Name + ".png");
                    i.Cursor = Cursors.Hand;
                }
                catch(FileNotFoundException) { };
            }
            //set lock levels
            for (int i = currentStage; i < levels.Count; i++)
            {
                try
                {
                    levels[i].Image = Image.FromFile(picPath + "LockLevel.png");
                    levels[i].Enabled = false;
                    levels[i].Cursor = Cursors.Default;
                }
                catch (FileNotFoundException) { };
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
            catch(ArgumentOutOfRangeException) { };
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
        private void User_Load(object sender, EventArgs e)
        {
            // Align the groubox in the middle of the screen
            gbRanked.Location = new System.Drawing.Point((this.Size.Width - gbRanked.Size.Width) / 2,
                (this.Size.Height - gbRanked.Size.Height) / 2);
            gbFeedback.Location = new System.Drawing.Point((this.Size.Width - gbFeedback.Size.Width) / 2,
                (this.Size.Height - gbFeedback.Size.Height) / 2);
            gbUser.Location = new System.Drawing.Point((this.Size.Width - gbUser.Size.Width) / 2,
                (this.Size.Height - gbUser.Size.Height) / 2);
            gbLevel.Location = new System.Drawing.Point((this.Size.Width - gbLevel.Size.Width) / 2,
                (this.Size.Height - gbLevel.Size.Height) / 2);

            // Align the gbUser
            label8.Location = new System.Drawing.Point((gbUser.Size.Width - label8.Size.Width) / 2, label8.Location.Y);
            int PosRight = label7.Location.X + label7.Size.Width;
            label14.Location = new System.Drawing.Point(PosRight - label14.Size.Width, label14.Location.Y);
            label12.Location = new System.Drawing.Point(PosRight - label12.Size.Width, label12.Location.Y);
            label17.Location = new System.Drawing.Point(PosRight - label17.Size.Width, label17.Location.Y);
            label18.Location = new System.Drawing.Point(PosRight - label18.Size.Width, label18.Location.Y);
            label15.Location = new System.Drawing.Point(PosRight - label15.Size.Width, label15.Location.Y);
            label16.Location = new System.Drawing.Point(PosRight - label16.Size.Width, label16.Location.Y);
            label19.Location = new System.Drawing.Point(PosRight - label19.Size.Width, label19.Location.Y);
            btnSaveInfo.Location = new System.Drawing.Point((gbUser.Size.Width - btnSaveInfo.Size.Width) / 2,
                btnSaveInfo.Location.Y);
        }
    }
}
