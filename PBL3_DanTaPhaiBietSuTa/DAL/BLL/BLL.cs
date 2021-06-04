using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa
{
    class BLL
    {
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static BLL _Instance;
        private BLL()
        {

        }
        public bool CheckLogin(string userName, string passWord)
        {
            return DAL.Instance.CheckLogin(userName, passWord);
        }
        public bool AddNewUser(UserInfo user)
        {
            return DAL.Instance.AddUser(user);
        }
        public List<UserInfo> GetListUserInfor()
        {
            return DAL.Instance.GetListUserInfo();
        }
        public bool UpdateUserInfor(UserInfo user)
        {
            return DAL.Instance.UpdateUser(user);
        }
        public UserInfo GetUserInforByUserName(string userName)
        {
            return DAL.Instance.GetUserInfoByUsername(userName);
        }
        public Video GetVideo(int stageID)
        {
            return DAL.Instance.GetVideo(stageID);
        }
        public List<Question> GetQuestionsByStage(int stageID)
        {
            return DAL.Instance.GetListQuestion(stageID);
        }
        public Question GetRandomQuestionByTimeStop(int stageID, int timeStop)
        {
            var listQuestion = DAL.Instance.GetListQuestionByTimeStop(stageID, timeStop);
            Random rd = new Random();
            int idQuestion = rd.Next(0, listQuestion.Count - 1);
            return listQuestion[idQuestion];
        }
        public Standing GetStandingByUserID(int userID)
        {
            return DAL.Instance.GetStandingByUserID(userID);
        }
        public List<Standing> SortListStandings()
        {
            List<Standing> standings = DAL.Instance.GetListStanding();
            standings = standings.OrderByDescending(p => p.Point).ToList();
            return standings;
        }
        public int GetRankByUserID(int userID)
        {
            int pos = 1;
            List<Standing> standings = SortListStandings();
            foreach (var i in standings)
            {
                if (i.UserID == userID)
                    return pos;
                pos++;
            }
            return -1;
        }
        public void UpdatePoint(GameProcess gameProcess)
        {
            DAL.Instance.UpdatePointTable(gameProcess);
        }
        public UserInfo GetUserInfoByUserID(int userID)
        {
            return DAL.Instance.GetUserInfoByUserID(userID);
        }



        //new function
        public List<Question> GetAllQuestion()
        {
            DB db = new DB();
            return db.Questions.Select(p => p).ToList();
        }
        public bool DeleteUser(int userID)
        {
            using (DB db = new DB())
            {
                var user = db.UserInfos.Find(userID);
                if (user == null) return false;
                else
                {
                    db.UserInfos.Remove(user);
                    db.SaveChanges();
                    return true;
                }
            }
        }
        public Question GetQuestionByQuestionID(int questionID)
        {
            Question question = new Question();
            var listAllQuestion = GetAllQuestion();
            foreach (var q in listAllQuestion)
            {
                if (q.QuestionID == questionID)
                    question = q;
            }
            return question;
        }
        public bool DeleteQuestion(int questionID)
        {
            using (DB db = new DB())
            {
                var question = db.Questions.Find(questionID);
                if (question == null) return false;
                else
                {
                    db.Questions.Remove(question);
                    db.SaveChanges();
                    return true;
                }
            }
        }
        public bool UpdateQuestion(Question question)
        {
            using (DB db = new DB())
            {
                var q = db.Questions.Find(question.QuestionID);
                if (q == null)
                    return false;
                else
                {
                    q.QuestionContent = question.QuestionContent;
                    q.KeyA = question.KeyA;
                    q.KeyB = question.KeyB;
                    q.KeyC = question.KeyC;
                    q.KeyD = question.KeyD;
                    q.Answer = question.Answer;
                    db.SaveChanges();
                    return true;
                }
            }
        }
    }
}
