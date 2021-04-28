using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa.DTO
{
    public class Video
    {
        [Key]
        public int VideoID { get; set; }
        public string VideoName { get; set; }
        public string VideoLink { get; set; }
    }
}
