namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using PBL3_DanTaPhaiBietSuTa.DTO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<PBL3_DanTaPhaiBietSuTa.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PBL3_DanTaPhaiBietSuTa.DB";
        }

        protected override void Seed(PBL3_DanTaPhaiBietSuTa.DB context)
        {
            
            context.Videos.AddOrUpdate(x =>x.VideoID,     
                new Video()
                {
                    VideoID = 1,VideoName = "Đại chiến Bạch Đằng",VideoLink = "C:/123.txt"
                },
                new Video()
                {
                    VideoID = 2,VideoName = "Quang Trung Đại Phá Quân Thanh",VideoLink = "C:/1234.txt"
                },
                new Video()
                {
                    VideoID = 3,VideoName = "Quang Trung Đại Phá Quân Thanh",VideoLink = "C:/1234.txt"
                }
            );

            context.Stages.AddOrUpdate(s => s.StageID,
                new Stage
                {
                    StageID = 1,
                    VideoID =1, StageName = "Màn 1"
                },
                new Stage
                {
                    StageID = 2,
                    VideoID = 2, StageName = "Màn 2"
                },
                new Stage
                {
                    StageID = 3,
                    VideoID = 3, StageName = "Màn 3"
                }
            );



            context.UserInfos.AddOrUpdate(s=>s.UserID,
                new UserInfo
                {
                    UserID = 1,
                    Username = "gnol5498",Password = "123456",Name = "Lê Thanh Long",
                    Email = "thanhlong9654147@gmail.com",
                },
                new UserInfo
                {
                    UserID = 2,
                    Username = "temnguyen",Password = "123456",Name = "Nguyễn Duy Thịnh",
                    Email = "temnguyen@gmail.com"
                }
            );

            context.GameProcesses.AddOrUpdate (
                new GameProcess
                {
                    GameProcessID = 1,
                     Point = 100, StageID = 1, UserID = 1
                }
            );
            
            
            
            context.Questions.AddOrUpdate(s => s.QuestionID,
                new Question
                {
                    QuestionID = 1,
                    QuestionContent = "Năm 937 Ngô Quyền kéo quân ra Bắc để :",
                    KeyA = "Mở rộng vùng kiểm soát",
                    KeyB = "Chuẩn bị đánh quân xâm lược",
                    KeyC = "Ra gần quê",
                    KeyD = "Trừng trị Kiều Công Tiễn làm phản",
                    Answer = "Trừng trị Kiều Công Tiễn làm phản",
                    StageID = 1,
                    TimeStop = 910
                },
                new Question
                {
                    QuestionID = 2,
                    QuestionContent = "Vua Nam Hán cho quân xâm lược nước ta lần 2 vì :",
                    KeyA = "Được Kiều Công Tiễn cầu cứu mời gọi",
                    KeyB = "Mở rộng bờ cõi",
                    KeyC = "Trả thù rửa hận",
                    KeyD = "A, B, C đúng",
                    Answer = "A, B, C đúng",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 3,
                    QuestionContent = "Lưu Hoằng Tháo đem quân sang xâm lược nước ta vào năm:",
                    KeyA = "937",
                    KeyB = "938",
                    KeyC = "939",
                    KeyD = "940",
                    Answer = "938",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 4,
                    QuestionContent = "Kiểu Công Tiễn sát hại Dương Đình Nghệ ở đâu ?",
                    KeyA = "Thành Đại La",
                    KeyB = "Thành Tiểu La",
                    KeyC = "Thành Bạch Mã",
                    KeyD = "Tất cả đều sai",
                    Answer = "Thành Đại La",
                    StageID = 1,
                    TimeStop = 910
                },
                new Question
                {
                    QuestionID = 5,
                    QuestionContent = "Để chuẩn bị cho cuộc chống quân xâm lược, Ngô Quyền tấn công vào Đại La bắt giết Kiều Công Tiễn nhằm:",
                    KeyA = "Trừ khử kẻ thù sau lưng trước khi quân Nam Hán vào",
                    KeyB = "Tiêu hao quân địch",
                    KeyC = "Chia rẽ lực lượng",
                    KeyD = "Hạn chế sức mạnh kẻ thù",
                    Answer = "Trừ khử kẻ thù sau lưng trước khi quân Nam Hán vào",
                    StageID = 1,
                    TimeStop = 1760
                },
                new Question
                {
                    QuestionID = 6,
                    QuestionContent = "Kế hoạch đánh giặc của Ngô Quyền có điểm độc đáo là:",
                    KeyA = "Quân sĩ đông",
                    KeyB = "Vũ khí hiện đại",
                    KeyC = "Lợi dụng thủy triều lên xuống làm trận địa cọc ngầm",
                    KeyD = "Biết trước được kế giặc.",
                    Answer = "Lợi dụng thủy triều lên xuống làm trận địa cọc ngầm",
                    StageID = 1,
                    TimeStop = 1760
                },
                new Question
                {
                    QuestionID = 7,
                    QuestionContent = "Kết quả của Trận Bạch Đằng của Ngô Quyền năm 938 là:",
                    KeyA = "kết thúc hoàn toàn thắng lợi.",
                    KeyB = "thất bại.",
                    KeyC = "không phân thắng bại.",
                    KeyD = "thắng lợi một phần.",
                    Answer = "kết thúc hoàn toàn thắng lợi.",
                    StageID = 1,
                    TimeStop = 3360
                },
                new Question
                {
                    QuestionID = 8,
                    QuestionContent = "Những chiếc cọc gỗ ngầm của Ngô Quyền có điểm độc đáo là:",
                    KeyA = "rất to và nhọn",
                    KeyB = "đầu cọc gỗ được đẽo nhọn và bịt sắt",
                    KeyC = "được lấy từ gỗ cây bạch đàn",
                    KeyD = "được lấy từ gỗ cây lim",
                    Answer = "đầu cọc gỗ được đẽo nhọn và bịt sắt",
                    StageID = 1,
                    TimeStop = 1760
                },
                new Question
                {
                    QuestionID = 9,
                    QuestionContent = "Lúc quân Nam Hán kéo quân vào Bạch Đằng là lúc:",
                    KeyA = "thủy triều đang xuống",
                    KeyB = "thủy triều đang lên",
                    KeyC = "quân ta chưa đóng xong cọc ngầm",
                    KeyD = "quân ta mới đóng xong một nửa trận địa cọc ngầm",
                    Answer = "thủy triều đang lên",
                    StageID = 1,
                    TimeStop = 2740
                },
                new Question
                {
                    QuestionID = 10,
                    QuestionContent = "Tướng Hoằng Tháo trong trận Bạch Đằng đã:",
                    KeyA = "bị tử trận",
                    KeyB = "ngụy trang trốn về nước",
                    KeyC = "bị quân ta bắt sống",
                    KeyD = "chui vào ống cống trở về nước",
                    Answer = "bị tử trận",
                    StageID = 1,
                    TimeStop = 3360
                },
                new Question
                {
                    QuestionID = 11,
                    QuestionContent = "Đại quân của Ngô Quyền bắt đầu phản công khi nào:",
                    KeyA = "khi địch đã vào sâu bãi cọc và thủy triều đang xuống",
                    KeyB = "khi địch đã vào sâu bãi cọc và thủy triều đang lên",
                    KeyC = "khi địch chưa vào bãi cọc",
                    KeyD = "khi quân ta chưa đóng xong cọc ngầm",
                    Answer = "khi địch đã vào sâu bãi cọc và thủy triều đang xuống",
                    StageID = 1,
                    TimeStop = 2740
                },
                new Question
                {
                    QuestionID = 12,
                    QuestionContent = "Nguyên nhân lớn nhất dẫn đến trận thua của quân Nam Hán?",
                    KeyA = "Do quân Nam Hán chủ quan khinh địch",
                    KeyB = "Do thuyền chiến lớn của Nam Hán bị mắc cạn và lần lượt bị cọc đâm thủng gần hết",
                    KeyC = "Do sự anh dũng của quân ta",
                    KeyD = "Tất cả đều sai",
                    Answer = "Do thuyền chiến lớn của Nam Hán bị mắc cạn và lần lượt bị cọc đâm thủng gần hết",
                    StageID = 1,
                    TimeStop = 3360
                },
                new Question
                {
                    QuestionID = 13,
                    QuestionContent = "Ngô Quyền sinh vào năm nào ?",
                    KeyA = "Năm 895",
                    KeyB = "Năm 898",
                    KeyC = "Năm 897",
                    KeyD = "Năm 899",
                    Answer = "Năm 898",
                    StageID = 1,
                    TimeStop = 710
                },
                new Question
                {
                    QuestionID = 14,
                    QuestionContent = "Ngô Quyền mất vào năm nào ?",
                    KeyA = "Năm 943",
                    KeyB = "Năm 944",
                    KeyC = "Năm 945",
                    KeyD = "Năm 947",
                    Answer = "Năm 944",
                    StageID = 1,
                    TimeStop = 710
                },
                new Question
                {
                    QuestionID = 15,
                    QuestionContent = "Ngô Quyền còn được biết đến với tên gọi là:",
                    KeyA = "Ngô Vương Quyền",
                    KeyB = "Ngô Vũ Vương",
                    KeyC = "Tiền Ngô Vương",
                    KeyD = "Tất cả đều đúng",
                    Answer = "Tất cả đều đúng",
                    StageID = 1,
                    TimeStop = 3510
                },
                new Question
                {
                    QuestionID = 16,
                    QuestionContent = "Ngô Quyền thống lĩnh ... ra Bắc dẹp loạn Kiểu Công Tiễn",
                    KeyA = "Thuỷ binh",
                    KeyB = "Bộ binh",
                    KeyC = "Pháo binh",
                    KeyD = "Kỵ binh",
                    Answer = "Thuỷ binh",
                    StageID = 1,
                    TimeStop = 910
                },
                new Question
                {
                    QuestionID = 17,
                    QuestionContent = "Quân Nam Hán thống lĩnh bao nhiêu binh lính xâm lược nước ta:",
                    KeyA = "Hai vạn thuỷ binh",
                    KeyB = "Ba vạn bộ binh",
                    KeyC = "Một vạn kỵ binh",
                    KeyD = "Ba vạn thuỷ binh",
                    Answer = "Hai vạn thuỷ binh",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 18,
                    QuestionContent = "Kiểu Công Tiễn bị giết chết và bị bêu đầu ở đâu?",
                    KeyA = "Trước doanh trại",
                    KeyB = "Trước cổng thành",
                    KeyC = "Trước sảnh đại tướng quân",
                    KeyD = "Tất cả đều sai",
                    Answer = "Trước cổng thành",
                    StageID = 1,
                    TimeStop = 1760
                },
                new Question
                {
                    QuestionID = 19,
                    QuestionContent = "Lưu Hoằng Tháo là ai:",
                    KeyA = "Thái tử của nước Nam Hán",
                    KeyB = "Phò mã của nước Nam Hán",
                    KeyC = "Tể tướng của nước Nam Hán",
                    KeyD = "Đại tướng quân của nước Nam Hán",
                    Answer = "Thái tử của nước Nam Hán",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 20,
                    QuestionContent = "Vua Nam Hán phong cho Hoằng Tháo chức gì?",
                    KeyA = "Tĩnh Hải quân Tiết độ sứ",
                    KeyB = "Bình Hải tướng quân",
                    KeyC = "Giao vương",
                    KeyD = "Tất cả đều đúng",
                    Answer = "Tất cả đều đúng",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 21,
                    QuestionContent = "Vì sao Kiều Công Tiễn cho người sang cầu cứu nhà Nam Hán?",
                    KeyA = "Kiều Công Tiễn sợ Ngô Quyền",
                    KeyB = "Kiều Công Tiễn biết mình không thể đối phó với Ngô Quyền",
                    KeyC = "Kiều Công Tiễn muốn giảng hòa với nhà Nam Hán",
                    KeyD = "Kiều Công Tiễn muốn vua Nam Hán công nhận mình là Tiết độ sứ",
                    Answer = "Kiều Công Tiễn biết mình không thể đối phó với Ngô Quyền",
                    StageID = 1,
                    TimeStop = 1170
                },
                new Question
                {
                    QuestionID = 22,
                    QuestionContent = "Thành Cổ Loa thuộc địa phương nào của nước ta hiện nay",
                    KeyA = "Đông Anh, Hà Nội",
                    KeyB = "Ba Đình, Hà Nội",
                    KeyC = "Ba Vì, Hà Nội",
                    KeyD = "Gia Lâm, Hà Nội",
                    Answer = "Đông Anh, Hà Nội",
                    StageID = 1,
                    TimeStop = 3510
                }
            );
            context.SaveChanges();
            
            
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
