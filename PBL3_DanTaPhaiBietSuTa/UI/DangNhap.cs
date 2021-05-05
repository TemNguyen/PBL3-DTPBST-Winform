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
using PBL3_DanTaPhaiBietSuTa.DTO;
using PBL3_DanTaPhaiBietSuTa.UI;


namespace PBL3_DanTaPhaiBietSuTa
{
    public partial class DangNhap : Form
    {
        Thread th;
        public DangNhap()
        {
            InitializeComponent();
            IsRememberUser();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }

        private void txtLoginR_Click(object sender, EventArgs e)
        {
            txtAccountR.Text = "";
            txtEmailR.Text = "";
            txtPassR.Text = "";
            txtRepassR.Text = "";
            gbRegister.Visible = false;
            gbLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            gbLogin.Visible = false;
            gbRegister.Visible = true;
        }

        private void OpenUserForm(object sender)
        {
            Application.Run(new User());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text;
            string passWord = txtPass.Text;
            if(BLL.Instance.CheckLogin(userName, passWord))
            {
                if(cbRemember.Checked) //lưu userName và passWord vào file.
                {
                    string rememberUserPath = @Application.StartupPath + @"\Assets\SavedUser\rememberUser.txt";
                    using (StreamWriter sw = File.CreateText(rememberUserPath))
                    {
                        sw.WriteLine(txtAccount.Text);
                        sw.WriteLine(txtPass.Text);
                    }
                }
                else
                {
                    string rememberUserPath = @Application.StartupPath + @"\Assets\SavedUser\rememberUser.txt";
                    File.Delete(rememberUserPath);
                }
                ShowMessage("Đăng nhập thành công!");
                GetUserLogin(txtAccount.Text);
                //User user = new User();
                //user.Show();
                //Close();
                this.Dispose();
                th = new Thread(OpenUserForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                //Hiện Thông báo đăng nhập thất bại
                ShowMessage("Có lỗi xảy ra, vui lòng kiểm tra lại thông tin tài khoản!");
                txtAccount.Text = "";
                txtPass.Text = "";
                return;
            }    
        }

        private void btnRegisterR_Click(object sender, EventArgs e)
        {
            if (txtPassR.Text != txtRepassR.Text)
            {
                ShowMessage("Pass và Repass không giống nhau!");
                txtPassR.Text = "";
                txtRepassR.Text = "";
                return;
            }
            if (IsValid() == false) return;
            UserInfo newUser = new UserInfo()
            {
                //newUser.Name = txtNameR.Text,
                Username = txtAccountR.Text,
                Password = txtPassR.Text,
                Email = txtEmailR.Text,
            };
            if(BLL.Instance.AddNewUser(newUser))
            {
                //Hiện thông báo đăng ký thành công
                ShowMessage("Đăng ký thành công!");
                txtAccountR.Text = "";
                txtEmailR.Text = "";
                txtPassR.Text = "";
                txtRepassR.Text = "";
                gbRegister.Visible = false;
                gbLogin.Visible = true;
            }   
            else
            {
                //Hiện thông báo đăng ký thất bại
                ShowMessage("Tên tài khoản đã tồn tại!");
                return;
            }    
        }
        private bool IsRememberUser()
        {
            string rememberUserPath = @Application.StartupPath + @"\Assets\SavedUser\rememberUser.txt";
            if (File.Exists(rememberUserPath))
            {
                cbRemember.Checked = true;
                List<string> rememberUser = new List<string>(File.ReadAllLines(rememberUserPath));
                txtAccount.Text = rememberUser[0];
                txtPass.Text = rememberUser[1];
            }
            return true;
        }
        //Kiểm tra đầu vào
        private bool IsValid()
        {
            List<char> list = new List<char>()
            {
                '`', '~', '!', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=',
                '{', '[', ']', '}', '|', ';', ':', ',', '<', '>', '/', '?' 
            };
            if (txtAccountR.Text == "" || txtEmailR.Text == "" || txtPassR.Text == "" || txtRepassR.Text == "")
            {
                //UX viền đỏ
                ShowMessage("Vui lòng nhập đủ thông tin!");
                return false;
            }
            foreach(var l in list)
            {
                if(txtEmailR.Text.Contains(l))
                {
                    ShowMessage("Email không thể chứa các ký tự `,~,!,..");
                    return false;
                }
            }
            if (!txtEmailR.Text.Contains("@"))
            {
                ShowMessage("Địa chỉ Email phải chứa ký tự @!");
                return false;
            }    
            if (txtEmailR.Text.Substring(0, 1) == "@")
            {
                ShowMessage("Email không thể bắt đầu bằng ký tự @!");
                return false;
            }
            return true;
        }
        private void GetUserLogin(string userName)
        {
            UserInfo user = BLL.Instance.GetUserInforByUserName(userName);
            string userLogin = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            using (StreamWriter sw = File.CreateText(userLogin))
            {
                sw.WriteLine(user.UserID);
                sw.WriteLine(user.Username);
                sw.WriteLine(user.Password);
                sw.WriteLine(user.Name);
                sw.WriteLine(user.Email);
            }
        }
        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtAccount.Text == "") txtPass.Text = "";
        }
        private void ShowMessage(string message)
        {
            Notification notification = new Notification();
            notification.Get(message);
            notification.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            gbLogin.Location = new System.Drawing.Point((this.Size.Width - gbLogin.Size.Width) / 2, 
                (this.Size.Height - gbLogin.Size.Height) / 2);
            gbRegister.Location = new System.Drawing.Point((this.Size.Width - gbRegister.Size.Width) / 2,
                (this.Size.Height - gbRegister.Size.Height) / 2);
        }
    }
}
