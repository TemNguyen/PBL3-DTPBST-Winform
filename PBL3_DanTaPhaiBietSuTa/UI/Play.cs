using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    public partial class Play : Form
    {
        List<int> listTimeStop = new List<int>();
        static int stageID;
        Question selectedQuestion;
        int point = 0, questionID = 0;
        int TVideo = 0, countDown = 60;
        public Play()
        {
            InitializeComponent();
            stageID = 1;
            //SetTimeStop();
            SetVideoStage();
            videoTime.Start();
            ResetQuestion();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm s = new SettingForm();
            s.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (TVideo < listTimeStop[listTimeStop.Count - 1])
            {
                //Hiện thông báo kh lưu proccess
                DialogResult d = MessageBox.Show("Tiến trình hiện tại sẽ không được lưu, Tiêp tục?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch(d)
                {
                    case DialogResult.Yes:
                        new User().Show();
                        this.Hide();
                        break;
                    case DialogResult.No:
                        return;
                }    
            }
            else
            {
                new User().Show();
                this.Hide();
            }    
        }
        private void SetVideoStage()
        {
            var video = BLL.Instance.GetVideo(stageID);
            Video.URL = @Application.StartupPath + @"\Assets\Video\" + video.VideoID + ".mp4";
            Video.Ctlenabled = false;
        }
        private void SetTimeStop()
        {
            List<int> list = new List<int>();
            foreach(var i in BLL.Instance.GetQuestionsByStage(stageID))
            {
                list.Add(i.TimeStop);
            }
            HashSet<int> setListTimeStop = new HashSet<int>(list);
            listTimeStop.AddRange(setListTimeStop);
        }
        private void DisplayQuestion()
        {
            selectedQuestion = BLL.Instance.GetRandomQuestionByTimeStop(stageID, listTimeStop[questionID]);
            //Display question
            //txtQuestion = selectedQuestion.
            List<string> listAnswer = new List<string>();
            //add answer to list
            Random rd = new Random();
            int questionrd;
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnA.Text += listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnB.Text += listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnC.Text += listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnD.Text += listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
        }
        private bool CheckAnswer(string answer)
        {
            //answer == selectedQuestion.Answer => true
            //answer != selectedQuestion.Answer => true
            //countdown > 30 => false
            return true;
        }
        private void CaculationPoint(int timeUsed)
        {
            //Caculation Point
            //Display Point
        }
        private bool IsSavePoint()
        {
            //Point > Saved Point => Update CSDL
            return true;
        }

        private void videoTime_Tick(object sender, EventArgs e)
        {
            TVideo++;
            if (TVideo == listTimeStop[questionID])
            {
                Video.Ctlcontrols.pause();
                DisplayQuestion();
                videoTime.Stop();
                questionTime.Start();
            }
        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            if(TVideo == listTimeStop[questionID])
            {
                countDown--;
            }    
        }
        private void SelectAnswer(object sender, EventArgs e)
        {
            string answer = ((Button)sender).ToString().Remove(0, 3);
            //UX Show correct Answer
            if (CheckAnswer(answer))
            {
                //Caculation Point
                //Display Point
            }
            else
            {
                //
            }
            //Delay t(s)
            Task.Delay(10000);
            //reset countDown
            countDown = 30;
            //Delete question
            ResetQuestion();
            videoTime.Start();
            Video.Ctlcontrols.play();
        }
        private void ResetQuestion()
        {
            txtQuestion.Text = "";
            btnA.Text = "";
            btnB.Text = "";
            btnC.Text = "";
            btnD.Text = "";
        }
    }
}
