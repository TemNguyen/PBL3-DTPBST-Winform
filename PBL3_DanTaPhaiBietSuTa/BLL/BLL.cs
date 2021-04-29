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
            DB db = new DB();
            var list = db.UserInfos.Select(p => p).ToList(); //linq sẽ viết trong DAL.
            foreach(var user in list)
            {
                if (user.Username == userName && user.Password == passWord) return true;
            }
            return false;
        }
        public bool AddNewUser(UserInfo user)
        {
            //gọi DAL add neu user.
            using (DB db = new DB())
            {
                db.UserInfos.Add(user);
                db.SaveChanges();
            }    
            return true;
        }
        public bool IsExistUser(string userName)
        {
            //DAL checkExistUser
            DB db = new DB();
            if (db.UserInfos.Where(p => p.Username == userName).ToList().Count > 0) 
                return true;
            return false;
        }
    }
}
