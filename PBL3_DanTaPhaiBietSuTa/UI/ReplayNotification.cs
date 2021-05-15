using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    public partial class ReplayNotification : Form
    {
        public delegate void MyDel(string message);
        MyDel Get;
        string message = "";
        public static bool isUnlockNextLevel;
        private void getMessage(string _message)
        {
            message = _message;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public ReplayNotification()
        {
            InitializeComponent();
            Get = new MyDel(getMessage);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ReplayNotification_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, 40);
            if (isUnlockNextLevel)
            {
                btnNext.Image = Image.FromFile(@Application.StartupPath + @"\Assets\Image\next.png");
            } 
            else
            {
                btnNext.Image = Image.FromFile(@Application.StartupPath + @"\Assets\Image\notnext.png");
                btnNext.Cursor = Cursors.Default;
                btnNext.Enabled = false;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Play.isPlayAgain = false;
            Dispose();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            Play.isPlayAgain = true;
            Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Play.stageID++;
            Play.isPlayAgain = true;
            Dispose();
        }
    }
}
