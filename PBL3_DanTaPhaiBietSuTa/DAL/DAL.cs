using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa
{
    public class DAL
    {
        public static DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static DAL _Instance;
        private DAL() { }
        public bool AddUser(UserInfo user)
        {
            if (IsExistUser(user.Username)) return false;
            else
            {
                using (DB db = new DB())
                {
                    db.UserInfos.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
        }
        public bool CheckLogin(string userName, string passWord)
        {
            using (var db = new DB())
            {
                var User = db.UserInfos.Where(s => s.Username == userName && s.Password == passWord).FirstOrDefault<UserInfo>();
                if (User != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool IsExistUser(string userName)
        {
            using (var db = new DB())
            {
                var User = db.UserInfos.Where(s => s.Username == userName).FirstOrDefault<UserInfo>();
                if (User != null)
                {

                    return true; //Đã tồn tại
                }
                else
                {
                    return false;
                }
            }

        }
        public List<UserInfo> GetListUserInfo()
        {
            List<UserInfo> list = new List<UserInfo>();
            using (DB db = new DB())
            {
                list = db.UserInfos.ToList();
            }
            return list;
        }
    }
}
