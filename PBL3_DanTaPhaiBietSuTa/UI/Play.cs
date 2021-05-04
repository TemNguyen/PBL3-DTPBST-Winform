using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections;
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

namespace PBL3_DanTaPhaiBietSuTa.UI
{
    public partial class Play : Form
    {
        List<int> listTimeStop = new List<int>();
        static int stageID;
        Question selectedQuestion;
        int point = 0, questionID = 0;
        int TVideo = 0, countDown = 300;
        public Play()
        {
            InitializeComponent();
            stageID = 1;
            lbPoint.Text = point.ToString();
            lbTime.Text = "Time: " + (countDown/10).ToString();
            SetTimeStop();
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
            if (Video.playState != WMPLib.WMPPlayState.wmppsMediaEnded)
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
            Video.settings.volume = 100;
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
            listTimeStop.Sort();
        }
        private void DisplayQuestion()
        {
            selectedQuestion = BLL.Instance.GetRandomQuestionByTimeStop(stageID, listTimeStop[questionID]);
            //Display question
            txtQuestion.Text = selectedQuestion.QuestionContent;
            List<string> listAnswer = new List<string>();
            listAnswer.Add(selectedQuestion.KeyA);
            listAnswer.Add(selectedQuestion.KeyB);
            listAnswer.Add(selectedQuestion.KeyC);
            listAnswer.Add(selectedQuestion.KeyD);
            Random rd = new Random();
            int questionrd;
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnA.Text = "A. " + listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            btnB.Text += "B. " + listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            customButton2.Text += "C. " + listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
            questionrd = rd.Next(0, listAnswer.Count - 1);
            customButton1.Text += "D. " + listAnswer[questionrd];
            listAnswer.RemoveAt(questionrd);
        }
        private bool CheckAnswer(string answer)
        {
            //answer == selectedQuestion.Answer => true
            //answer != selectedQuestion.Answer => true
            //countdown == 0 => false
            if (String.Compare(answer, selectedQuestion.Answer) != 0 || countDown == 0)
                return false;
            else
                return true;
        }
        private void CaculationPoint(int timeUsed)
        {
            //Caculation Point
            //Display Point
            point += Convert.ToInt32((countDown*1.0/300) * 100);
            lbPoint.Text = point.ToString();
        }
        private bool IsSavePoint()
        {
            string path = @Application.StartupPath + @"\Assets\SavedUser\Account.txt";
            GameProcess userProcess = new GameProcess();
            userProcess.StageID = stageID;
            userProcess.UserID = Convert.ToInt32(File.ReadLines(path).First());
            userProcess.Point = point;
            BLL.Instance.UpdatePoint(userProcess);
            return true;
        }

        private void videoTime_Tick(object sender, EventArgs e)
        {
            TVideo = Convert.ToInt32(Video.Ctlcontrols.currentPosition * 10);
            try
            {
                if (TVideo >= listTimeStop[questionID])
                {
                    Video.Ctlcontrols.pause();
                    DisplayQuestion();
                    videoTime.Stop();
                    questionTime.Start();
                }
            }
            catch(Exception)
            {

            };
            if (IsFinish()) videoTime.Stop();
        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            try
            {
                if (TVideo >= listTimeStop[questionID])
                {
                    countDown--;
                }
            }
            catch (Exception) { };
            lbTime.Text = "Time: " + (countDown/10).ToString();
            if(countDown == 0)
            {
                countDown = 300;
                lbTime.Text = "Time: ";
                ResetQuestion();
                questionID++;
                videoTime.Start();
                Video.Ctlcontrols.play();
            }    
        }
        private void SelectAnswer(object sender, EventArgs e)
        {
            string answer = ((Button)sender).Text.Remove(0, 3);
            //UX Show correct Answer
            if (CheckAnswer(answer))
            {
                CaculationPoint(countDown);
            }
            Color btnColor = ((CustomButton)sender).ButtonColor;
            Color borderColor = ((CustomButton)sender).BorderColor;
            ShowCorrectAnswer(borderColor, btnColor);
            //Delay t(s)
            //reset countDown
            countDown = 300;
            lbTime.Text = "Time: ";
            //Delete question
            ResetQuestion();
            //Increse questionID
            questionID++;
            videoTime.Start();
            Video.Ctlcontrols.play();
        }
        private void ResetQuestion()
        {
            txtQuestion.Text = "";
            btnA.Text = "";
            btnB.Text = "";
            customButton1.Text = "";
            customButton2.Text = "";
        }
        private void ShowCorrectAnswer(Color border, Color button)
        {
            
        }
        private bool IsFinish()
        {
            if (Video.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                IsSavePoint();
                //Hiện UI chơi lại
                MessageBox.Show("Chúc mừng bạn đã hoàn thành xong màn, số điểm của bạn là: " + point, "Congratulation", MessageBoxButtons.OK);
                DialogResult d = MessageBox.Show("Bạn có muốn chơi lại không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch(d)
                {
                    case DialogResult.Yes:
                        //reset form
                        break;
                    case DialogResult.No:
                        new User().Show();
                        this.Hide();
                        break;
                }
                return true;
            }
            return false;
        }
    }
}
