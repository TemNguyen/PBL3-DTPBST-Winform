using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa.DTO
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Username;
        }
    }
}
