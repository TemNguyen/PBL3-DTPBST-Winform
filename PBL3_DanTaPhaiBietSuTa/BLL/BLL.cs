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
        public List<UserInfo> GetUserInfos()
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
    }
}
