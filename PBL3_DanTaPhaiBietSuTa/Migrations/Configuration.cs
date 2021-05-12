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
                    VideoID = 3,VideoName = "Quang Trung Đại Phá Quân Thanh",VideoLink = "C:/1234.txt"
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
                }
                



            );
            context.SaveChanges();
            
            
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
