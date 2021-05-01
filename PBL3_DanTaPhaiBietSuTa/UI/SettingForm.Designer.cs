
namespace PBL3_DanTaPhaiBietSuTa.UI
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSoundOn = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.btnHelp = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.ovalPictureBox3 = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            this.btnMusicOn = new PBL3_DanTaPhaiBietSuTa.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSoundOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusicOn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSoundOn
            // 
            this.btnSoundOn.BackColor = System.Drawing.Color.DarkGray;
            this.btnSoundOn.Image = ((System.Drawing.Image)(resources.GetObject("btnSoundOn.Image")));
            this.btnSoundOn.Location = new System.Drawing.Point(-1, -1);
            this.btnSoundOn.Name = "btnSoundOn";
            this.btnSoundOn.Size = new System.Drawing.Size(71, 71);
            this.btnSoundOn.TabIndex = 1;
            this.btnSoundOn.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkGray;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(153, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(71, 71);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.TabStop = false;
            // 
            // ovalPictureBox3
            // 
            this.ovalPictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("ovalPictureBox3.Image")));
            this.ovalPictureBox3.Location = new System.Drawing.Point(230, -1);
            this.ovalPictureBox3.Name = "ovalPictureBox3";
            this.ovalPictureBox3.Size = new System.Drawing.Size(71, 71);
            this.ovalPictureBox3.TabIndex = 3;
            this.ovalPictureBox3.TabStop = false;
            // 
            // btnMusicOn
            // 
            this.btnMusicOn.BackColor = System.Drawing.Color.DarkGray;
            this.btnMusicOn.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicOn.Image")));
            this.btnMusicOn.Location = new System.Drawing.Point(76, -1);
            this.btnMusicOn.Name = "btnMusicOn";
            this.btnMusicOn.Size = new System.Drawing.Size(71, 71);
            this.btnMusicOn.TabIndex = 4;
            this.btnMusicOn.TabStop = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 76);
            this.Controls.Add(this.btnMusicOn);
            this.Controls.Add(this.ovalPictureBox3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSoundOn);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnSoundOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMusicOn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private OvalPictureBox btnSoundOn;
        private OvalPictureBox btnHelp;
        private OvalPictureBox ovalPictureBox3;
        private OvalPictureBox btnMusicOn;
    }
}