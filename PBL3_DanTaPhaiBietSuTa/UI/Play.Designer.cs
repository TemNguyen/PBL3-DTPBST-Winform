using AxWMPLib;
using System.Windows.Forms;

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    partial class Play
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.gbVideo = new System.Windows.Forms.GroupBox();
            this.Video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbUser = new System.Windows.Forms.Label();
            this.videoTime = new System.Windows.Forms.Timer(this.components);
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.btnSetting = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.btnD = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.btnC = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.btnB = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.btnA = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.txtQuestion = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.customButton1 = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.customButton2 = new PBL3_DanTaPhaiBietSuTa.CustomButton();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.gbVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVideo
            // 
            this.gbVideo.BackColor = System.Drawing.Color.White;
            this.gbVideo.Controls.Add(this.lbPoint);
            this.gbVideo.Controls.Add(this.lbTime);
            this.gbVideo.Controls.Add(this.Video);
            this.gbVideo.Controls.Add(this.lbUser);
            this.gbVideo.Location = new System.Drawing.Point(93, 4);
            this.gbVideo.Margin = new System.Windows.Forms.Padding(4);
            this.gbVideo.Name = "gbVideo";
            this.gbVideo.Padding = new System.Windows.Forms.Padding(4);
            this.gbVideo.Size = new System.Drawing.Size(883, 484);
            this.gbVideo.TabIndex = 1;
            this.gbVideo.TabStop = false;
            this.gbVideo.Text = "groupBox1";
            // 
            // Video
            // 
            this.Video.Enabled = true;
            this.Video.Location = new System.Drawing.Point(0, 0);
            this.Video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Video.Name = "Video";
            this.Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video.OcxState")));
            this.Video.Size = new System.Drawing.Size(883, 478);
            this.Video.TabIndex = 7;
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.White;
            this.lbUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbUser.Location = new System.Drawing.Point(1, 0);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(1199, 30);
            this.lbUser.TabIndex = 6;
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoTime
            // 
            this.videoTime.Tick += new System.EventHandler(this.videoTime_Tick);
            // 
            // questionTime
            // 
            this.questionTime.Tick += new System.EventHandler(this.questionTime_Tick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1, 1);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(69, 71);
            this.btnHome.TabIndex = 34;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.DarkGray;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(997, 1);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(69, 71);
            this.btnSetting.TabIndex = 33;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.btnD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnD.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(723, 837);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD.Name = "btnD";
            this.btnD.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnD.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnD.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnD.Size = new System.Drawing.Size(549, 89);
            this.btnD.TabIndex = 32;
            this.btnD.Text = "D.";
            this.btnD.TextColor = System.Drawing.Color.White;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // btnC
            // 
            this.btnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.btnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnC.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(153, 837);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnC.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnC.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnC.Size = new System.Drawing.Size(549, 89);
            this.btnC.TabIndex = 31;
            this.btnC.Text = "C.";
            this.btnC.TextColor = System.Drawing.Color.White;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.btnB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(541, 597);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnB.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnB.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnB.Size = new System.Drawing.Size(412, 71);
            this.btnB.TabIndex = 30;
            this.btnB.Text = "B.";
            this.btnB.TextColor = System.Drawing.Color.White;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.btnA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnA.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(115, 597);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnA.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnA.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnA.Size = new System.Drawing.Size(412, 71);
            this.btnA.TabIndex = 29;
            this.btnA.Text = "A.";
            this.btnA.TextColor = System.Drawing.Color.White;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.txtQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.txtQuestion.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuestion.Enabled = false;
            this.txtQuestion.FlatAppearance.BorderSize = 0;
            this.txtQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(115, 495);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.txtQuestion.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.txtQuestion.OnHoverTextColor = System.Drawing.Color.Gray;
            this.txtQuestion.Size = new System.Drawing.Size(839, 87);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Câu hỏi";
            this.txtQuestion.TextColor = System.Drawing.Color.White;
            this.txtQuestion.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.customButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.Location = new System.Drawing.Point(541, 680);
            this.customButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customButton1.Name = "customButton1";
            this.customButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.customButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.customButton1.Size = new System.Drawing.Size(412, 71);
            this.customButton1.TabIndex = 35;
            this.customButton1.Text = "D.";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // customButton2
            // 
            this.customButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.customButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.customButton2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.Location = new System.Drawing.Point(115, 680);
            this.customButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customButton2.Name = "customButton2";
            this.customButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.customButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.customButton2.Size = new System.Drawing.Size(412, 71);
            this.customButton2.TabIndex = 36;
            this.customButton2.Text = "C.";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.SelectAnswer);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.White;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(3, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(78, 38);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Time";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.Location = new System.Drawing.Point(807, 5);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(69, 32);
            this.lbPoint.TabIndex = 9;
            this.lbPoint.Text = "Point";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 794);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.gbVideo);
            this.Controls.Add(this.txtQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.gbVideo.ResumeLayout(false);
            this.gbVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVideo;
        private System.Windows.Forms.Label lbUser;
        private CustomButton txtQuestion;
        private CustomButton btnA;
        private CustomButton btnB;
        private CustomButton btnD;
        private CustomButton btnC;
        private OvalPictureBox btnSetting;
        private OvalPictureBox btnHome;
        private Timer videoTime;
        private Timer questionTime;
        private AxWindowsMediaPlayer Video;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private Label lbPoint;
        private Label lbTime;
    }
}