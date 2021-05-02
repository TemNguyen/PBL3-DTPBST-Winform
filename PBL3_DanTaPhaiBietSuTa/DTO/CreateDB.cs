using PBL3_DanTaPhaiBietSuTa.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DanTaPhaiBietSuTa
{
    public class CreateDB : CreateDatabaseIfNotExists<DB>
    {
        protected override void Seed(PBL3_DanTaPhaiBietSuTa.DB context)
        {
            context.Videos.AddRange(new Video[]
            {
                new Video
                {
                    VideoID = 1,VideoName = "Đại chiến Bạch Đằng",VideoLink = "C:/123.txt"
                },
                new Video
                {
                    VideoID = 2,VideoName = "Quang Trung Đại Phá Quân Thanh",VideoLink = "C:/1234.txt"
                }
            });
            context.Stages.AddRange(new Stage[] {
                new Stage
                {
                    StageID = 1, VideoID =1, StageName = "Màn 1"
                },
                new Stage
                {
                    StageID = 2,VideoID = 2, StageName = "Màn 2"
                }
            });


            context.UserInfos.AddRange(new UserInfo[] {
                new UserInfo
                {
                    Username = "gnol5498",Password = "123456",Name = "Lê Thanh Long",
                    Email = "thanhlong9654147@gmail.com",
                },
                new UserInfo
                {
                    Username = "temnguyen",Password = "123456",Name = "Nguyễn Duy Thịnh",
                    Email = "temnguyen@gmail.com"
                }
            });
            context.GameProcesses.AddRange(new GameProcess[] {
                new GameProcess
                {
                    GameProcessID = 1, Point = 100, StageID = 1, UserID = 1
                }
            });
            context.Questions.AddRange(new Question[] {
                new Question
                {
                    QuestionID =1 , QuestionContent = "123456",StageID = 1,TimeStop = 1000
                }

            });
        }
    }
}
