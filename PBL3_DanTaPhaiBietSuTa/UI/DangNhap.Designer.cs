
using System.Drawing;

namespace PBL3_DanTaPhaiBietSuTa
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lbthongbao = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccountR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoginR = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.txtRepassR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegisterR = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.Setting = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.gbLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).BeginInit();
            this.SuspendLayout();
            // 
            // lbthongbao
            // 
            this.lbthongbao.BackColor = System.Drawing.Color.White;
            this.lbthongbao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbthongbao.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbthongbao.Location = new System.Drawing.Point(1, 0);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new System.Drawing.Size(370, 34);
            this.lbthongbao.TabIndex = 2;
            this.lbthongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(138, 132);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(204, 34);
            this.txtPass.TabIndex = 3;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(138, 73);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(204, 34);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minh họa logo here :3";
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbLogin.Controls.Add(this.cbRemember);
            this.gbLogin.Controls.Add(this.btnRegister);
            this.gbLogin.Controls.Add(this.label5);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.lbthongbao);
            this.gbLogin.Controls.Add(this.txtAccount);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.txtPass);
            this.gbLogin.Location = new System.Drawing.Point(357, 317);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(2);
            this.gbLogin.Size = new System.Drawing.Size(370, 284);
            this.gbLogin.TabIndex = 7;
            this.gbLogin.TabStop = false;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.Location = new System.Drawing.Point(138, 168);
            this.cbRemember.Margin = new System.Windows.Forms.Padding(2);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(115, 23);
            this.cbRemember.TabIndex = 10;
            this.cbRemember.Text = "Nhớ tài khoản";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegister.Location = new System.Drawing.Point(216, 251);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(60, 19);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chưa có tài khoản?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(124, 196);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnLogin.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnLogin.Size = new System.Drawing.Size(132, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmailR
            // 
            this.txtEmailR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailR.Location = new System.Drawing.Point(138, 124);
            this.txtEmailR.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(204, 29);
            this.txtEmailR.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên đăng nhập";
            // 
            // txtAccountR
            // 
            this.txtAccountR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountR.Location = new System.Drawing.Point(138, 73);
            this.txtAccountR.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountR.Name = "txtAccountR";
            this.txtAccountR.Size = new System.Drawing.Size(204, 29);
            this.txtAccountR.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 34);
            this.label10.TabIndex = 2;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(146, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đăng ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đã có tài khoản?";
            // 
            // txtLoginR
            // 
            this.txtLoginR.AutoSize = true;
            this.txtLoginR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLoginR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLoginR.Location = new System.Drawing.Point(212, 320);
            this.txtLoginR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLoginR.Name = "txtLoginR";
            this.txtLoginR.Size = new System.Drawing.Size(77, 19);
            this.txtLoginR.TabIndex = 9;
            this.txtLoginR.Text = "Đăng nhập";
            this.txtLoginR.Click += new System.EventHandler(this.txtLoginR_Click);
            // 
            // gbRegister
            // 
            this.gbRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbRegister.Controls.Add(this.txtRepassR);
            this.gbRegister.Controls.Add(this.label13);
            this.gbRegister.Controls.Add(this.txtPassR);
            this.gbRegister.Controls.Add(this.label12);
            this.gbRegister.Controls.Add(this.txtLoginR);
            this.gbRegister.Controls.Add(this.label7);
            this.gbRegister.Controls.Add(this.label8);
            this.gbRegister.Controls.Add(this.label9);
            this.gbRegister.Controls.Add(this.btnRegisterR);
            this.gbRegister.Controls.Add(this.label10);
            this.gbRegister.Controls.Add(this.txtAccountR);
            this.gbRegister.Controls.Add(this.label11);
            this.gbRegister.Controls.Add(this.txtEmailR);
            this.gbRegister.Location = new System.Drawing.Point(358, 283);
            this.gbRegister.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegister.Size = new System.Drawing.Size(370, 357);
            this.gbRegister.TabIndex = 11;
            this.gbRegister.TabStop = false;
            this.gbRegister.Visible = false;
            // 
            // txtRepassR
            // 
            this.txtRepassR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassR.Location = new System.Drawing.Point(138, 226);
            this.txtRepassR.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepassR.Name = "txtRepassR";
            this.txtRepassR.PasswordChar = '*';
            this.txtRepassR.Size = new System.Drawing.Size(204, 29);
            this.txtRepassR.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nhập lại mật khẩu";
            // 
            // txtPassR
            // 
            this.txtPassR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassR.Location = new System.Drawing.Point(138, 175);
            this.txtPassR.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassR.Name = "txtPassR";
            this.txtPassR.PasswordChar = '*';
            this.txtPassR.Size = new System.Drawing.Size(204, 29);
            this.txtPassR.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 131);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Email";
            // 
            // btnRegisterR
            // 
            this.btnRegisterR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRegisterR.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRegisterR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterR.FlatAppearance.BorderSize = 0;
            this.btnRegisterR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterR.Location = new System.Drawing.Point(125, 269);
            this.btnRegisterR.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterR.Name = "btnRegisterR";
            this.btnRegisterR.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnRegisterR.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnRegisterR.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnRegisterR.Size = new System.Drawing.Size(132, 44);
            this.btnRegisterR.TabIndex = 0;
            this.btnRegisterR.Text = "Đăng ký";
            this.btnRegisterR.TextColor = System.Drawing.Color.White;
            this.btnRegisterR.UseVisualStyleBackColor = true;
            this.btnRegisterR.Click += new System.EventHandler(this.btnRegisterR_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.DarkGray;
            this.Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting.Image = ((System.Drawing.Image)(resources.GetObject("Setting.Image")));
            this.Setting.Location = new System.Drawing.Point(987, 713);
            this.Setting.Margin = new System.Windows.Forms.Padding(2);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(70, 71);
            this.Setting.TabIndex = 13;
            this.Setting.TabStop = false;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 794);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnLogin;
        private System.Windows.Forms.Label lbthongbao;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccountR;
        private System.Windows.Forms.Label label10;
        private CustomButton btnRegisterR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtLoginR;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.TextBox txtRepassR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassR;
        private System.Windows.Forms.Label label12;
        private OvalPictureBox Setting;
    }
}

