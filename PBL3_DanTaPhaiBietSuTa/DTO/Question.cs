using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa.DTO
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        public int StageID { get; set; }
        public string QuestionContent { get; set; }
        public int TimeStop { get; set; }
        [ForeignKey("StageID")]
        public virtual Stage Stage { get; set; }
    }
}
