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
                    VideoID = 1,VideoName = "Khởi nghĩa Hai Bà Trưng",
                    VideoLink = "C:/123.txt"
                },
                new Video()
                {
                    VideoID = 2,VideoName = "Đại chiến Bạch Đằng",
                    VideoLink = "C:/1234.txt"
                },
                new Video()
                {
                    VideoID = 3,VideoName = "Trận chiến trên sông Như Nguyệt",VideoLink = "C:/1234.txt"
                },
                new Video()
                {
                    VideoID = 4,
                    VideoName = "Khởi nghĩa Lam Sơn",
                    VideoLink = "C:/1234.txt"
                },
                new Video()
                {
                    VideoID = 5,
                    VideoName = "Quang Trung Đại Phá Quân Thanh",
                    VideoLink = "C:/1234.txt"
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
                }, new Stage
                {
                    StageID = 4,
                    VideoID = 4,
                    StageName = "Màn 4"
                },
                new Stage
                {
                    StageID = 5,
                    VideoID = 5,
                    StageName = "Màn 5"
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

            context.GameProcesses.AddOrUpdate(
                new GameProcess
                {
                    GameProcessID = 1,
                    Point = 100,
                    StageID = 1,
                    UserID = 1,
                    IsPass = true
                }
            ) ;
            
            
            
            context.Questions.AddOrUpdate(s => s.QuestionID,
                //Màn 2
                new Question
                {
                    QuestionID = 1,
                    QuestionContent = "Năm 937 Ngô Quyền kéo quân ra Bắc để :",
                    KeyA = "Mở rộng vùng kiểm soát",
                    KeyB = "Chuẩn bị đánh quân xâm lược",
                    KeyC = "Ra gần quê",
                    KeyD = "Trừng trị Kiều Công Tiễn làm phản",
                    Answer = "Trừng trị Kiều Công Tiễn làm phản",
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
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
                    StageID = 2,
                    TimeStop = 3510
                },
                //Màn 1
                new Question
                {
                    QuestionID = 23,
                    QuestionContent = "Hai Bà Trưng phất cờ khởi nghĩa năm nào ?",
                    KeyA = "Mùa xuân năm 40 trước công nguyên",
                    KeyB = "Mùa xuân năm 40 ",
                    KeyC = "Năm 981",
                    KeyD = "Năm 938",
                    Answer = "Mùa xuân năm 40 ",
                    StageID = 1,
                    TimeStop = 250
                },
                new Question
                {
                    QuestionID = 24,
                    QuestionContent = "Mùa xuân năm 40 đã diễn ra sự kiện gì quan trọng trong lịch sử nước ta?",
                    KeyA = "Hai Bà Trưng kháng chiến chống quân xâm lược Hán",
                    KeyB = "Hai Bà Trưng dựng cờ khởi nghĩa ở Hát Môn (Hà Nội)",
                    KeyC = "Hai Bà Trưng xây dựng chính quyền tự chủ",
                    KeyD = "Hai Bà Trưng tập trung chuẩn bị lực lượng kháng chiến",
                    Answer = "Hai Bà Trưng dựng cờ khởi nghĩa ở Hát Môn (Hà Nội)",
                    StageID = 1,
                    TimeStop = 250
                },
                new Question
                {
                    QuestionID = 25,
                    QuestionContent = "Nhà Đông Hán cử tướng nào sang đàn áp cuộc khởi nghĩa Hai Bà Trưng ?",
                    KeyA = "Mã Viện",
                    KeyB = "Lục Dận",
                    KeyC = "Trần Bá Tiên",
                    KeyD = "Đoàn Chí",
                    Answer = "Mã Viện",
                    StageID = 1,
                    TimeStop = 250
                },
                new Question
                {
                    QuestionID = 26,
                    QuestionContent = "Nhà Đông Hán đàn áp cuộc khởi nghĩa Hai Bà Trưng vào năm nào?",
                    KeyA = "Năm 40 trước công nguyên",
                    KeyB = "Năm 40 sau công nguyên",
                    KeyC = "Năm 42 trước công nguyên",
                    KeyD = "Năm 42 sau công nguyên",
                    Answer = "Năm 42 sau công nguyên",
                    StageID = 1,
                    TimeStop = 250
                },
                new Question
                {
                    QuestionID = 27,
                    QuestionContent = "Bình Khôi công chúa là ai ?",
                    KeyA = "Trưng Trắc",
                    KeyB = "Trưng Nhị",
                    KeyC = "Cả Hai Bà Trưng",
                    KeyD = "Tất cả đều sai",
                    Answer = "Trưng Nhị",
                    StageID = 1,
                    TimeStop = 600
                },
                new Question
                {
                    QuestionID = 28,
                    QuestionContent = "Mã Viện chỉ huy một lực lượng bao nhiêu quân tân công nước ta vào tháng 4 năm 42 ?",
                    KeyA = "Mười vạn quân, hai nghìn xe thuyền các loại",
                    KeyB = "Hai vạn quân, hai nghìn xe thuyền các loại",
                    KeyC = "Ba vạn quân, hai nghìn xe thuyền các loại",
                    KeyD = "Bốn vạn quân, hai nghìn xe thuyền các loại",
                    Answer = "Hai vạn quân, hai nghìn xe thuyền các loại",
                    StageID = 1,
                    TimeStop = 600
                },
                new Question
                {
                    QuestionID = 29,
                    QuestionContent = "Lãng Bạc nằm phía đông Cổ Loa là nơi như thế nào?",
                    KeyA = "Địa thế hiếm trở",
                    KeyB = "Vùng đồi cao",
                    KeyC = "Nghênh chiến quyết liệt của quân Hai Bà với quân xâm lược",
                    KeyD = "Cả A, B, C đúng",
                    Answer = "Cả A, B, C đúng",
                    StageID = 1,
                    TimeStop = 600
                },
                new Question
                {
                    QuestionID = 30,
                    QuestionContent = "Hai Bà Trưng kéo quân đến vùng nào để nghênh chiến với quân nhà Hán ?",
                    KeyA = "Hai Bà Trưng kéo quân đến Hợp Phố để nghênh chiến",
                    KeyB = "Hai Bà Trưng kéo quân đến Lục Đầu để nghênh chiến",
                    KeyC = "Hai Bà Trưng kéo quân đến Lãng Bạc để nghênh chiến",
                    KeyD = "Hai Bà Trưng kéo quân đến Quỷ Môn Quan để nghênh chiến",
                    Answer = "Hai Bà Trưng kéo quân đến Lãng Bạc để nghênh chiến",
                    StageID = 1,
                    TimeStop = 250
                },
                new Question
                {
                    QuestionID = 31,
                    QuestionContent = "Tình hình của quân Hán thế nào khi đánh nhau với quân ta ở Lãng Bạc ?",
                    KeyA = "Lương thực sắp hết",
                    KeyB = "Quân sĩ không hợp thủy thổ phương Nam, nhiều người ngã bệnh và chết",
                    KeyC = "Tinh thần quân sĩ rệu rã",
                    KeyD = "Cả A,B,C đúng",
                    Answer = "Cả A,B,C đúng",
                    StageID = 1,
                    TimeStop = 1910
                },
                new Question
                {
                    QuestionID = 32,
                    QuestionContent = "Nguyên nhân khiến quân ta thất bại ở Lãng Bạc ?",
                    KeyA = "Quân ta chủ quan khinh địch nên thất bại",
                    KeyB = "Giao chiến lâu ngày, quân Hai Bà Trưng thiếu trang bị và kinh nghiệm, không địch nổi đạo quân thiện chiến của Mã Viện",
                    KeyC = "Quân ta có nội gián do Mã Viện cử sang",
                    KeyD = "Tinh thần chiến đấu của quân ta quá yếu kém nên thất bại",
                    Answer = "Giao chiến lâu ngày, quân Hai Bà Trưng thiếu trang bị và kinh nghiệm, không địch nổi đạo quân thiện chiến của Mã Viện",
                    StageID = 1,
                    TimeStop = 1910
                },
                new Question
                {
                    QuestionID = 33,
                    QuestionContent = "Sau trận Lãng Bạc, Hai Bà Trưng rút quân về đâu ?",
                    KeyA = "Hợp Phố",
                    KeyB = "Cổ Loa",
                    KeyC = "Mê Linh",
                    KeyD = "Cấm Khê",
                    Answer = "Cổ Loa",
                    StageID = 1,
                    TimeStop = 1910
                },
                new Question
                {
                    QuestionID = 34,
                    QuestionContent = "Quân ta dùng kế sách gì để đẩy lùi giặc ở Mê Linh ?",
                    KeyA = "Đào hố thật sâu",
                    KeyB = "Cho quân ta nấp Sẵn dưới hố",
                    KeyC = "Cho một lực lượng mỏng sang khiêu chiến địch",
                    KeyD = "Cả A,B,C đúng",
                    Answer = "Cả A,B,C đúng",
                    StageID = 1,
                    TimeStop = 3720
                },
                new Question
                {
                    QuestionID = 35,
                    QuestionContent = "Trưng Vương đã dùng kế sách gì để chống lại kế mai phục của Mã Viện ?",
                    KeyA = "Giả vờ như không biết gì, cho quân từ trong thành ra ứng chiến",
                    KeyB = "Cho tướng Hùng Lệ Nương đưa quân ra sau lưng địch để đánh úp phía sau",
                    KeyC = "Đợi quân Mã Viện toả ra vây bắt thì cánh quân Hùng Lệ Nương kết hợp với quân ở phía trước đánh mạnh cả 2 phía",
                    KeyD = "Cả A,B,C đúng",
                    Answer = "Cả A,B,C đúng",
                    StageID = 1,
                    TimeStop = 3720
                },
                new Question
                {
                    QuestionID = 36,
                    QuestionContent = "Trước sự chống trả quyết liệt của quân Hai Bà Trưng, Mã Viện phải làm gì ?",
                    KeyA = "Rút quân về nước",
                    KeyB = "Tiếp tục trấn thủ",
                    KeyC = "Xin thêm viện binh từ nhà Hán",
                    KeyD = "Tất cả đều sai",
                    Answer = "Xin thêm viện binh từ nhà Hán",
                    StageID = 1,
                    TimeStop = 3720
                },
                new Question
                {
                    QuestionID = 37,
                    QuestionContent = "Trước sự bao vây quyết liệt của quân Mã Viện ở Mê Linh, Trưng Nhị đã làm gì ?",
                    KeyA = "Cử tướng Lũ Luỹ và Hùng Thiên Bảo đem quân sang giải vây",
                    KeyB = "Bản thân cũng tiến quân chia thành các đạo hẹn nơi hội quân",
                    KeyC = "Kết hợp quân từ 3 phía nhằm đánh tan quân địch",
                    KeyD = "Cả A,B,C đúng",
                    Answer = "Cả A,B,C đúng",
                    StageID = 1,
                    TimeStop = 4850
                },
                new Question
                {
                    QuestionID = 38,
                    QuestionContent = "Sau khi thất bại ở Mê Linh, quân ta đã làm gì ?",
                    KeyA = "Tiếp tục tử chiến",
                    KeyB = "Rút quân về Cấm Khê để trấn thủ",
                    KeyC = "Xin hàng quân địch",
                    KeyD = "Rút quân về Hát Môn",
                    Answer = "Rút quân về Cấm Khê để trấn thủ",
                    StageID = 1,
                    TimeStop = 6810
                },
                new Question
                {
                    QuestionID = 39,
                    QuestionContent = "Nguyên nhân khiến quân ta thất bại ở Mê Linh ?",
                    KeyA = "Quân địch quân đông binh mạnh",
                    KeyB = "Quân ta binh yếu, kiệt sức do trận chiến kéo dài",
                    KeyC = "Quân ta thiếu nguồn tiếp tế lương thực",
                    KeyD = "A,B,C đều đúng",
                    Answer = "A,B,C đều đúng",
                    StageID = 1,
                    TimeStop = 1910
                },
                new Question
                {
                    QuestionID = 40,
                    QuestionContent = "Cuộc kháng chiến chống quân xâm lược Hán (42 - 43) không mang ý nghĩa nào sau đây ?",
                    KeyA = "Củng cố vững mạnh chính quyền tự chủ của nhân dân ta",
                    KeyB = "Khẳng định vai trò của người phụ nữa trong lịch sử dân tộc ta",
                    KeyC = "Thể hiện tinh thần đoàn kết, ý chí chống giặc của nhân dân ta",
                    KeyD = "Để lại nhiều bại học kinh nghiệm quý báu",
                    Answer = "Củng cố vững mạnh chính quyền tự chủ của nhân dân ta",
                    StageID = 1,
                    TimeStop = 7130
                },
                new Question
                {
                    QuestionID = 41,
                    QuestionContent = "Cuộc kháng chiến chống quân xâm lược Hán (42 – 43) thất bại xuất phát từ nguyên nhân chủ yếu nào ?",
                    KeyA = "So sánh lực lượng chênh lệch giữa ta và địch",
                    KeyB = "Nhân dân chưa triệt để chống giặc",
                    KeyC = "Chưa có đường lối kháng chiến đúng",
                    KeyD = "Người lãnh đạo không có tài năng",
                    Answer = "So sánh lực lượng chênh lệch giữa ta và địch",
                    StageID = 1,
                    TimeStop = 7130
                },
                new Question
                {
                    QuestionID = 42,
                    QuestionContent = "Địa danh nào gắn liền với sự hi sinh của Hai Bà Trưng ?",
                    KeyA = "Hợp Phố",
                    KeyB = "Cẩm Khê",
                    KeyC = "Hát Môn",
                    KeyD = "Mê Linh",
                    Answer = "Cẩm Khê",
                    StageID = 1,
                    TimeStop = 7130
                },
                new Question
                {
                    QuestionID = 43,
                    QuestionContent = "Sông Hát còn có tên gọi là gì ?",
                    KeyA = "Sông Đáy",
                    KeyB = "Sông Hồng ",
                    KeyC = "Sông Hương",
                    KeyD = "Sông Tô Lịch",
                    Answer = "Sông Đáy",
                    StageID = 1,
                    TimeStop = 7130
                },
                //Màn 3
                new Question
                {
                    QuestionID = 44,
                    QuestionContent = "Cánh quân bộ của quân Tống tiến sang Ðại Việt do ai chỉ huy ?",
                    KeyA = "Quách Quỳ, Triệu Tiết",
                    KeyB = "Hòa Mâu, Ô Mã Nhi",
                    KeyC = "Liễu Thăng, Triệu Tiết",
                    KeyD = "Hầu Nhân Bảo, Vương Thông",
                    Answer = "Quách Quỳ, Triệu Tiết",
                    StageID = 3,
                    TimeStop = 1290
                },
                new Question
                {
                    QuestionID = 45,
                    QuestionContent = "Quân Tống cử bao nhiêu quân sang xâm lược nước ta ?",
                    KeyA = "10 vạn quân, 20 vạn dân phu",
                    KeyB = "20 vạn quân, 10 vạn dân phu",
                    KeyC = "10 vạn quân, 10 vạn dân phu",
                    KeyD = "10 vạn quân và không có dân phu",
                    Answer = "10 vạn quân, 20 vạn dân phu",
                    StageID = 3,
                    TimeStop = 1290
                },
                new Question
                {
                    QuestionID = 46,
                    QuestionContent = "Vị tuớng chỉ huy quân ta trong cuộc kháng chiến chống Tống lần này là ai ?",
                    KeyA = "Lý Công Uẩn",
                    KeyB = "Lý Thường Kiệt",
                    KeyC = "Trần Thủ Độ",
                    KeyD = "Trần Cảnh",
                    Answer = "Lý Thường Kiệt",
                    StageID = 3,
                    TimeStop = 1290
                },
                new Question
                {
                    QuestionID = 47,
                    QuestionContent = "Lý Thường Kiệt đánh vào Ung Châu với mục đích gì ?",
                    KeyA = "Tiêu diệt Bộ chỉ huy của quân Tống",
                    KeyB = "Ðánh vào nơi tập trung lực lượng của quân Tống",
                    KeyC = "Đánh vào đồn quân Tống gần biên giới của Đại Việt",
                    KeyD = "Ðánh vào kho luong thực và khí giới của quân Tống",
                    Answer = "Ðánh vào kho luong thực và khí giới của quân Tống",
                    StageID = 3,
                    TimeStop = 1290
                },
                new Question
                {
                    QuestionID = 48,
                    QuestionContent = "Sau khi rút quân về nuớc, Lý Thường Kiệt cho xây dựng hệ thống phòng ngự trên sông nào ?",
                    KeyA = "Bạch Ðằng",
                    KeyB = "Mã",
                    KeyC = "Như Nguyệt",
                    KeyD = "Thao",
                    Answer = "Như Nguyệt",
                    StageID = 3,
                    TimeStop = 2610
                },
                new Question
                {
                    QuestionID = 49,
                    QuestionContent = "Tuớng nào của nhà Tống đã hiến kế cho Quách Quỳ bắc cầu phao vuợt sông ?",
                    KeyA = "Triệt Tiết",
                    KeyB = "Vương Thông",
                    KeyC = "Miêu Lý",
                    KeyD = "Hoà Mâu",
                    Answer = "Miêu Lý",
                    StageID = 3,
                    TimeStop = 2610
                },
                new Question
                {
                    QuestionID = 50,
                    QuestionContent = "Vì sao Quách Quỳ đợi mãi mà thuỷ binh vẫn chưa tới ?",
                    KeyA = "Thuỷ binh của Quách Quỳ di chuyển quá chậm",
                    KeyB = "Thuỷ binh của Quách Quỳ bị quân nhà Lý chặn đánh nên chưa thể tới được",
                    KeyC = "Thuỷ binh của Quách Quỳ gặp tai nạn trên đường hành quân",
                    KeyD = "Tất cả đều sai",
                    Answer = "Thuỷ binh của Quách Quỳ bị quân nhà Lý chặn đánh nên chưa thể tới được",
                    StageID = 3,
                    TimeStop = 2610
                },
                new Question
                {
                    QuestionID = 51,
                    QuestionContent = "Lý Thường Kiệt đã cử tướng nào đi chặn đánh thuỷ binh nhà Tống ?",
                    KeyA = "Lý Triện",
                    KeyB = "Lý Kế Nguyên",
                    KeyC = "Chiêu Văn",
                    KeyD = "Hoằng Chân",
                    Answer = "Lý Kế Nguyên",
                    StageID = 3,
                    TimeStop = 2610
                },
                new Question
                {
                    QuestionID = 52,
                    QuestionContent = "Sau khi nhận tin thuỷ quân chưa thể tới kịp Quách Quỳ đã làm gì ?",
                    KeyA = "Tiếp tục đợi thuỷ quân tới để cùng tiến công",
                    KeyB = "Tiến hành đóng bè lớn vượt sông",
                    KeyC = "Gọi viện trợ từ nhà Tống",
                    KeyD = "Tất cả đều sai",
                    Answer = "Tiến hành đóng bè lớn vượt sông",
                    StageID = 3,
                    TimeStop = 3470
                },
                new Question
                {
                    QuestionID = 53,
                    QuestionContent = "Sức chứa của mỗi bè lớn là bao nhiêu ?",
                    KeyA = "200 quân",
                    KeyB = "500 quân",
                    KeyC = "1000 quân",
                    KeyD = "2000 quân",
                    Answer = "500 quân",
                    StageID = 3,
                    TimeStop = 3470
                },
                new Question
                {
                    QuestionID = 54,
                    QuestionContent = "Nguyên nhân nào khiến quân Tống thất bại ở cuộc tấn công lần thứ hai này ?",
                    KeyA = "Quân Tống vừa sang sông phải tốn sức phá huỷ lớp hàng rào tre cho nhà Lý bố trí",
                    KeyB = "Quân Tống phải chống lại các đợt phản công mãnh liệt của quân nhà Lý",
                    KeyC = "Do sức chứa của các bè lớn quá ít nên quân tiếp viện không qua kịp",
                    KeyD = "Tất cả đều đúng",
                    Answer = "Tất cả đều đúng",
                    StageID = 3,
                    TimeStop = 3470
                },
                new Question
                {
                    QuestionID = 55,
                    QuestionContent = "Quách Quỳ phải đối mặt những khó khăn nào trong tình thế hiện nay ?",
                    KeyA = "Tiến công không được vì không có thuỷ quân để vượt sông",
                    KeyB = "Lùi không được vì phải chịu khiển trách của vua Tống",
                    KeyC = "Tình cảnh ba quân đang lâm vào dịch bệnh phương Nam",
                    KeyD = "Tất cả đều đúng",
                    Answer = "Tất cả đều đúng",
                    StageID = 3,
                    TimeStop = 3820
                },
                new Question
                {
                    QuestionID = 56,
                    QuestionContent = "Lý Thường Kiệt đã cử tướng nào tập kích doanh trại quân Tống trong đêm ?",
                    KeyA = "Hoằng Chân, Lý Kế Nguyên",
                    KeyB = "Lý Triện, Nguyễn Xí",
                    KeyC = "Nguyễn Xí, Chiêu Văn",
                    KeyD = "Tất cả đều sai",
                    Answer = "Tất cả đều sai",
                    StageID = 3,
                    TimeStop = 5400
                },
                new Question
                {
                    QuestionID = 57,
                    QuestionContent = "Kết cục của Hoằng Chân và Chiêu Văn sau cuộc tấn công tấn công doanh trại quân Tống:",
                    KeyA = "Hoằng Chân bị bắt sống còn Chiêu Văn hi sinh",
                    KeyB = "Cả hai ông đều hi sinh",
                    KeyC = "Cả hai ông may mắn thoát được và rút về doanh trại nhà Lý",
                    KeyD = "Tất cả đều sai",
                    Answer = "Cả hai ông đều hi sinh",
                    StageID = 3,
                    TimeStop = 5400
                },
                new Question
                {
                    QuestionID = 58,
                    QuestionContent = "Lý Thường Kiệt đã dùng kế gì để đánh bại quân Tống ?",
                    KeyA = "Tẩu vi thượng sách",
                    KeyB = "Dương đông kích tây",
                    KeyC = "Liên hoàn kế",
                    KeyD = "Không thành kế",
                    Answer = "Dương đông kích tây",
                    StageID = 3,
                    TimeStop = 6730
                },
                new Question
                {
                    QuestionID = 59,
                    QuestionContent = "Vì sao Lý Thường Kiệt cử hai tướng Hoằng Chân và Chiêu Văn đi đánh Quách Quỳ ?",
                    KeyA = "Nhằm mục đích tập kích bất ngờ gây khó khăn cho quân Tống",
                    KeyB = "Nhằm thu hút lực lượng quân Tống để Lý Thường Kiệt rảnh tay đi đánh Triệu Tiết",
                    KeyC = "Triệu Tiết sẽ cử quân viện trợ Quách Quỳ từ đó quân ở doanh trại Quách Quỳ càng thưa thớt",
                    KeyD = "Cả B và C đúng",
                    Answer = "Cả B và C đúng",
                    StageID = 3,
                    TimeStop = 6730
                },
                new Question
                {
                    QuestionID = 60,
                    QuestionContent = "Khi hai tướng Hoằng Chân và Chiêu Văn đánh doanh trại Quách Quỳ, Lý Thường Kiệt đã làm gì ?",
                    KeyA = "Đem quân viện trợ cho Hoằng Chân và Chiêu Văn",
                    KeyB = "Đem quân sang tấn công doanh trại Triệu Tiết ở phía bắc sông Như Nguyệt",
                    KeyC = "Không làm gì cả",
                    KeyD = "Tất cả đều sai",
                    Answer = "Đem quân sang tấn công doanh trại Triệu Tiết ở phía bắc sông Như Nguyệt",
                    StageID = 3,
                    TimeStop = 6730
                },
                new Question
                {
                    QuestionID = 61,
                    QuestionContent = "Lý Thường Kiệt chủ động kết thúc chiến tranh bằng cách nào ?",
                    KeyA = "Tổng tiến công, truy kích kẻ thù đến cùng",
                    KeyB = "Thương lượng, đề nghị giảng hòa",
                    KeyC = "Kí hòa ước, kết thúc chiến tranh",
                    KeyD = "Đề nghị “giảng hòa” củng cố lực lượng, chờ thời cơ",
                    Answer = "Thương lượng, đề nghị giảng hòa",
                    StageID = 3,
                    TimeStop = 7550
                },
                new Question
                {
                    QuestionID = 62,
                    QuestionContent = "Tại sao Lý Thường Kiệt lại chủ động giảng hòa ?",
                    KeyA = "Lý Thường Kiệt sợ mất lòng vua Tống",
                    KeyB = "Để bảo toàn lực lượng và tài sản của nhân dân",
                    KeyC = "Để đảm bảo mối quan hệ hòa hiếu giữa hai nước và là truyền thống nhân đạo của dân tộc",
                    KeyD = "Lý Thường Kiệt muốn kết thúc chiến tranh nhanh chóng",
                    Answer = "Để đảm bảo mối quan hệ hòa hiếu giữa hai nước và là truyền thống nhân đạo của dân tộc",
                    StageID = 3,
                    TimeStop = 7550
                },
                new Question
                {
                    QuestionID = 63,
                    QuestionContent = "Tư tưởng xuyên suốt của Nhà Lý trong diễn biến cuộc kháng chiến chống Tống là gì ?",
                    KeyA = "Nhân đạo",
                    KeyB = "Nhân văn",
                    KeyC = "Chủ động",
                    KeyD = "Bị động",
                    Answer = "Chủ động",
                    StageID = 3,
                    TimeStop = 7950
                },
                new Question
                {
                    QuestionID = 64,
                    QuestionContent = "Tước vị cao nhất của Lý Thường Kiệt vào năm 1075 là gì ?",
                    KeyA = "Vua",
                    KeyB = "Thái úy",
                    KeyC = "Thái sư",
                    KeyD = "Tể tướng",
                    Answer = "Thái úy",
                    StageID = 3,
                    TimeStop = 7950
                },
                new Question
                {
                    QuestionID = 65,
                    QuestionContent = "Thiệt hại về người của Nhà Tống trong cuộc kháng chiến này là :",
                    KeyA = "10 vạn quân, 20 vạn dân phu",
                    KeyB = "10 vạn quân, 8 vạn dân phu",
                    KeyC = "8 vạn quân, 8 vạn dân phu",
                    KeyD = "8 vạn quân, 10 vạn dân phu",
                    Answer = "8 vạn quân, 8 vạn dân phu",
                    StageID = 3,
                    TimeStop = 7950
                },
                //Màn 4
                new Question
                {
                    QuestionID = 66,
                    QuestionContent = "Quân Minh xâm lược nước ta vào thế kỉ nào ?",
                    KeyA = "Thế kỷ XIV",
                    KeyB = "Thế kỷ XV",
                    KeyC = "Thế kỷ XVI",
                    KeyD = "Thế kỷ XVII",
                    Answer = "Thế kỷ XV",
                    StageID = 4,
                    TimeStop = 1250
                },
                new Question
                {
                    QuestionID = 67,
                    QuestionContent = "Lê Lợi trước khi dựng cờ khởi nghĩa đã làm đến chức gì ?",
                    KeyA = "Bình Ngô Tướng quân",
                    KeyB = "Kim Ngô Tướng quân",
                    KeyC = "Thổ quan Tuần kiểm",
                    KeyD = "Không làm chức gì cả",
                    Answer = "Kim Ngô Tướng quân",
                    StageID = 4,
                    TimeStop = 1250
                },
                new Question
                {
                    QuestionID = 68,
                    QuestionContent = "Lê Lợi bắt đầu chiêu nạp anh hùng hào kiệt vào năm nào ?",
                    KeyA = "1412",
                    KeyB = "1413",
                    KeyC = "1414",
                    KeyD = "1415",
                    Answer = "1414",
                    StageID = 4,
                    TimeStop = 1250
                },
                new Question
                {
                    QuestionID = 69,
                    QuestionContent = "Hội thề Lũng Nhai diễn ra vào năm nào ?",
                    KeyA = "1414",
                    KeyB = "1416",
                    KeyC = "1418",
                    KeyD = "1420",
                    Answer = "1416",
                    StageID = 4,
                    TimeStop = 2050
                },
                new Question
                {
                    QuestionID = 70,
                    QuestionContent = "Hội thề Lũng Nhai có bao nhiêu người tham dự ?",
                    KeyA = "16",
                    KeyB = "17",
                    KeyC = "18",
                    KeyD = "19",
                    Answer = "19",
                    StageID = 4,
                    TimeStop = 2050
                },
                new Question
                {
                    QuestionID = 71,
                    QuestionContent = "Lê Lợi dựng cờ khởi nghĩa vào năm nào ?",
                    KeyA = "1416",
                    KeyB = "1417",
                    KeyC = "1418",
                    KeyD = "Tất cả đều sai",
                    Answer = "1418",
                    StageID = 4,
                    TimeStop = 2050
                },
                new Question
                {
                    QuestionID = 72,
                    QuestionContent = "Thành phần của nghĩa quân Lam Sơn ở những buổi đầu khởi nghĩa là:",
                    KeyA = "100 thiết kỵ, 14 thớt voi, 2000 người",
                    KeyB = "200 thiết kỵ, 10 thớt voi, 1000 người",
                    KeyC = "200 thiết kỵ, 14 thớt voi, 2000 người",
                    KeyD = "Tất cả đều sai",
                    Answer = "200 thiết kỵ, 14 thớt voi, 2000 người",
                    StageID = 4,
                    TimeStop = 3240
                },
                new Question
                {
                    QuestionID = 73,
                    QuestionContent = "Những ngày đầu khởi nghĩa, lực lượng nghĩa quân Lam Sơn như thế nào ?",
                    KeyA = "Rất mạnh, quân sĩ đông, vũ khí đầy đủ",
                    KeyB = "Còn yếu",
                    KeyC = "Gặp nhiều khó khăn, gian nan",
                    KeyD = "Cả B và C đúng",
                    Answer = "Cả B và C đúng",
                    StageID = 4,
                    TimeStop = 3240
                },
                new Question
                {
                    QuestionID = 74,
                    QuestionContent = "Trong lúc nguy khốn, Lê Lai đã làm gì để cứu Lê Lợi ?",
                    KeyA = "Thay Lê Lợi lãnh đạo kháng chiến",
                    KeyB = "Giúp Lê Lợi rút quân an toàn",
                    KeyC = "Đóng giả Lê Lợi và hi sinh thay chủ tướng",
                    KeyD = "Tất cả đều đúng",
                    Answer = "Đóng giả Lê Lợi và hi sinh thay chủ tướng",
                    StageID = 4,
                    TimeStop = 3240
                },
                new Question
                {
                    QuestionID = 75,
                    QuestionContent = "Khi quân Minh tấn công căn cứ Lam Sơn, trước thế mạnh của giặc nghĩa quân đã làm gì ?",
                    KeyA = "Rút lên núi Chí Linh (Thanh Hóa)",
                    KeyB = "Rút lên núi Núi Do (Thanh Hóa)",
                    KeyC = "Rút vào Nghệ An",
                    KeyD = "Không hề rút lui, cầm cự đến cùng",
                    Answer = "Rút lên núi Chí Linh (Thanh Hóa)",
                    StageID = 4,
                    TimeStop = 3240
                },
                new Question
                {
                    QuestionID = 76,
                    QuestionContent = "Trước tình hình quân Minh tấn công nghĩa quân, ai là người đã đề nghị tạm rời núi rừng Thanh Hóa, chuyển quân vào Nghệ An ?",
                    KeyA = "Nguyễn Trãi",
                    KeyB = "Lê Lợi",
                    KeyC = "Nguyễn Chích",
                    KeyD = "Trần Nguyên Hãn",
                    Answer = "Nguyễn Chích",
                    StageID = 4,
                    TimeStop = 5230
                },
                new Question
                {
                    QuestionID = 77,
                    QuestionContent = "Lê Lợi đã cử ai sang đánh thành Tây Đô ?",
                    KeyA = "Lý Triện",
                    KeyB = "Nguyễn Xí",
                    KeyC = "Đinh Lễ",
                    KeyD = "Lê Ngân",
                    Answer = "Đinh Lễ",
                    StageID = 4,
                    TimeStop = 5230
                },
                new Question
                {
                    QuestionID = 78,
                    QuestionContent = "Đến cuối năm 1425, nghĩa quân Lê Lợi đã làm chủ những vùng đất nào ?",
                    KeyA = "Từ Nghệ An vào đến Thuận Hóa",
                    KeyB = "Từ Thanh Hóa vào đến đèo Hải Vân",
                    KeyC = "Từ Thanh Hóa vào đến Thuận Hoá",
                    KeyD = "Từ Nghệ An vào đến Quảng Bình",
                    Answer = "Từ Thanh Hóa vào đến Thuận Hoá",
                    StageID = 4,
                    TimeStop = 5230
                },
                new Question
                {
                    QuestionID = 79,
                    QuestionContent = "Tháng 9 năm 1426, Lê Lợi và bộ chỉ huy quyết định mở cuộc tiến quân đến đâu ?",
                    KeyA = "Vào Miền Trung",
                    KeyB = "Vào Miền Nam",
                    KeyC = "Ra Miền Bắc",
                    KeyD = "Đánh thẳng ra Thăng Long",
                    Answer = "Ra Miền Bắc",
                    StageID = 4,
                    TimeStop = 6320
                },
                new Question
                {
                    QuestionID = 80,
                    QuestionContent = "Nhiệm vụ của các cánh quân ra đánh phía Bắc là gì ?",
                    KeyA = "Giải phóng đất đai, giành thêm dân",
                    KeyB = "Bao vây uy hiếp thành, chặn viện binh địch",
                    KeyC = "Tiêu diệt sinh lực địch trong thành",
                    KeyD = "A và B đúng",
                    Answer = "A và B đúng",
                    StageID = 4,
                    TimeStop = 6320
                },
                new Question
                {
                    QuestionID = 81,
                    QuestionContent = "Hướng tiến công của cánh quân do Đinh Lễ và Nguyễn Xí chỉ huy là:",
                    KeyA = "Đánh phía Tây Bắc",
                    KeyB = "Đánh phía Đông Bắc",
                    KeyC = "Đánh thành Đông Quan",
                    KeyD = "Đánh phía Đông Nam",
                    Answer = "Đánh thành Đông Quan",
                    StageID = 4,
                    TimeStop = 6320
                },
                new Question
                {
                    QuestionID = 82,
                    QuestionContent = "Tháng 11 năm 1426, 5 vạn viện binh của giặc do tướng nào chỉ huy kéo vào Đông Quan ?",
                    KeyA = "Trương Phụ",
                    KeyB = "Liễu Thăng",
                    KeyC = "Mộc Thạnh",
                    KeyD = "Vương Thông",
                    Answer = "Vương Thông",
                    StageID = 4,
                    TimeStop = 7350
                },
                new Question
                {
                    QuestionID = 83,
                    QuestionContent = "Vương Thông đã quyết định mở cuộc phản công đánh vào chủ lực của nghĩa quân Lam Sơn ở đâu ?",
                    KeyA = "Cao Bộ (Chương Mi, Hà Tây)",
                    KeyB = "Đông Quan",
                    KeyC = "Đào Đặng (Hưng Yên)",
                    KeyD = "Tất cả các vùng trên",
                    Answer = "Cao Bộ (Chương Mi, Hà Tây)",
                    StageID = 4,
                    TimeStop = 7350
                },
                new Question
                {
                    QuestionID = 84,
                    QuestionContent = "Chiến thắng nào của nghĩa quân đã làm cho 5 vạn quân Minh bị tử thương ?",
                    KeyA = "Cao Bộ",
                    KeyB = "Đông Quan",
                    KeyC = "Chúc Động – Tốt Động",
                    KeyD = "Chi Lăng – Xương Giang",
                    Answer = "Chúc Động – Tốt Động",
                    StageID = 4,
                    TimeStop = 7350
                },
                new Question
                {
                    QuestionID = 85,
                    QuestionContent = "Vào thời gian nào 15 vạn quân viện binh của Trung Quốc chia làm hai đạo kéo vào nước ta ?",
                    KeyA = "Tháng 10 năm 1426",
                    KeyB = "Tháng 10 năm 1427",
                    KeyC = "Tháng 11 năm 1427",
                    KeyD = "Tháng 12 năm 1427",
                    Answer = "Tháng 10 năm 1427",
                    StageID = 4,
                    TimeStop = 8520
                },
                new Question
                {
                    QuestionID = 86,
                    QuestionContent = "Khi Liễu Thăng hùng hổ dẫn quân ào ạt tiến vào biên giới nước ta, chúng đã bị nghĩa quân phục kích và giết ở đâu ?",
                    KeyA = "Ở Nam Quan",
                    KeyB = "Ở Đông Quan",
                    KeyC = "Ở Vân Nam",
                    KeyD = "Ở Chi Lăng",
                    Answer = "Ở Chi Lăng",
                    StageID = 4,
                    TimeStop = 8520
                },
                new Question
                {
                    QuestionID = 87,
                    QuestionContent = "Chiến thắng Xương Giang, nghĩa quân Lam Sơn đã tiêu diệt bao nhiêu tên địch ?",
                    KeyA = "5 vạn",
                    KeyB = "10 vạn",
                    KeyC = "15 vạn",
                    KeyD = "20 vạn",
                    Answer = "5 vạn",
                    StageID = 4,
                    TimeStop = 8520
                },
                new Question
                {
                    QuestionID = 88,
                    QuestionContent = "Sau thất bại ở Chi Lăng – Xương Giang, tình hình quân Minh ở Đông Quan như thế nào ?",
                    KeyA = "Vô cùng khiếp đảm, vội vàng xin hòa và chấp nhận mở hội thề Đông Quan rút quân về nước",
                    KeyB = "Bỏ vũ khí ra hàng",
                    KeyC = "Liều chết phá vòng vây rút chạy về nước",
                    KeyD = "Rơi vào thế bị động, liên lạc về nước cầu cứu viện binh",
                    Answer = "Vô cùng khiếp đảm, vội vàng xin hòa và chấp nhận mở hội thề Đông Quan rút quân về nước",
                    StageID = 4,
                    TimeStop = 9280
                },
                new Question
                {
                    QuestionID = 89,
                    QuestionContent = "Bình Ngô đại cáo được coi như bản tuyên ngôn độc lập thứ mấy của nước ta ?",
                    KeyA = "Thứ nhất",
                    KeyB = "Thứ hai",
                    KeyC = "Thứ ba",
                    KeyD = "Bình Ngô đại cáo không được coi như một bản tuyên ngôn độc lập",
                    Answer = "Thứ hai",
                    StageID = 4,
                    TimeStop = 9280
                },
                new Question
                {
                    QuestionID = 90,
                    QuestionContent = "Lê Lợi lên ngôi hoàng đế vào ngày tháng năm nào ?",
                    KeyA = "Ngày 25/4/1428",
                    KeyB = "Ngày 29/4/1428",
                    KeyC = "Ngày 30/4/1428",
                    KeyD = "Ngày 1/5/1428",
                    Answer = "Ngày 29/4/1428",
                    StageID = 4,
                    TimeStop = 9280
                }






            );
            context.SaveChanges();
            
            
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
