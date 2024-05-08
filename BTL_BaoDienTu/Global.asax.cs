using System;
using System.Collections.Generic;

namespace BTL_BaoDienTu
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<News> newslist = new List<News>();
            newslist.Add(new News(1,
                "Elon Musk tuyên bố sắp trình làng taxi tự lái của Tesla",
                "Ngày 5-4, tỉ phú Elon Musk cho biết hãng xe Tesla sẽ ra mắt taxi tự lái (robotaxi) vào mùa hè 2024 này. " +
                "<br/>Tesla robotaxi sẽ ra mắt vào ngày 8-8, tỉ phú Elon Musk, giám đốc điều hành của Tesla, thông báo ngắn gọn trên X vào ngày 5-4 và không tiết lộ thêm chi tiết. Sau thông báo này, cổ phiếu của Tesla đã tăng hơn 3%. " +
                "Theo Đài CNN, từ lâu tỉ phú Elon Musk đã ấp ủ ý tưởng về xe hơi không cần người lái của Tesla. Ông tin rằng những chiếc xe Tesla sở hữu công nghệ tự lái hoàn toàn sẽ ngày càng được cải tiến qua các bản cập nhật phần mềm. " +
                "<br/>Năm 2019 Tesla cho biết họ sẽ vận hành dịch vụ taxi không người lái (robotaxi) vào năm 2020. Công ty dự đoán những chiếc xe tự lái này sẽ hoạt động được 11 năm và chạy được 1 triệu dặm (hơn 1,6 triệu km). " +
                "Chủ của những chiếc robotaxi trong tương lai có thể chỉ cần ngồi nhà mà vẫn có thể thu được khoản lợi nhuận 30.000 USD/năm (hơn 750 triệu đồng). " +
                "Tesla đến nay vẫn chưa cung cấp robotaxi, phương tiện tự hành hay công nghệ có thể biến ô tô của hãng trở thành phương tiện tự hành cấp 3. " +
                "<br/>Tuy nhiên, Tesla đang cung cấp các hệ thống hỗ trợ lái xe tiên tiến (ADAS), bao gồm tùy chọn autopilot tiêu chuẩn hoặc tùy chọn tự lái hoàn toàn (Full Self-Driving, hay FSD) cao cấp. " +
                "Hiện tại, chủ sở hữu có thể nâng cấp lên tính năng FSD trên mẫu xe Tesla Model 3 với giá 12.000 USD hoặc đăng ký thuê bao với giá 199 USD/tháng. " +
                "Để thúc đẩy doanh số bán hàng cuối quý, tỉ phú Musk gần đây đã yêu cầu các nhân viên bán hàng và nhân viên dịch vụ phải cài đặt và demo FSD cho khách hàng trước khi giao xe. " +
                "<br/>Đối với Tesla, ngày ra mắt không đồng nghĩa với ngày phát hành thương mại chính thức của sản phẩm mới trong tương lai gần. " +
                "Chẳng hạn Tesla đã ra mắt xe tải điện hạng nặng Semi vào năm 2017, nhưng mãi đến tháng 12 năm 2022 mới bắt đầu giao hàng. Cho đến nay, Tesla vẫn sản xuất và bán rất ít xe Semi.", 
                DateTime.Parse("2024-04-06"), "Khoa học & Công nghệ", "asset/images/kh1.jpg", "#"));
            newslist.Add(new News(2,
                "Ngàn người hâm mộ Hàn Quốc đội mưa tiễn gấu trúc Fu Bao về nước",
                "Giữa cơn mưa lớn, nhiều người vẫn mặc áo mưa đến công viên giải trí Everland để tạm biệt gấu trúc Fu Bao lên đường trở về quê hương. " +
                "<br/>Sáng 3-4, Fu Bao, chú gấu trúc khổng lồ sinh ra ở Everland, được Chính phủ Hàn Quốc trao trả lại Trung Quốc để tham gia chương trình nhân giống." +
                "Fu Bao rời Panda World lúc 10h40 sáng (theo giờ Hàn Quốc) trên một chiếc xe đặc biệt không rung, đi qua tuyến đường Everland Parade và nói lời tạm biệt cuối cùng với người hâm mộ trước đài phun nước lúc 11h sáng." +
                "<br/>Fu Bao sẽ được vận chuyển từ sân bay quốc tế Incheon đến căn cứ Wolong Shuping của Trung tâm Nghiên cứu bảo tồn gấu trúc khổng lồ Tứ Xuyên, bằng một chiếc máy bay thuê do phía Trung Quốc chuẩn bị. " +
                "<br/>Ông Kang, hay được gọi là 'ông ngoại Kangbao', xúc động và bật khóc khi tiễn Fu Bao về nước. Được biết, ông Kang là người đã chăm sóc Fu Bao ngay từ khi lọt lòng. 'Ông ngoại' sẽ đồng hành cùng Fu Bao trong suốt quá trình di chuyển đến nhà mới. " +
                "<br/>Trước giờ khởi hành, ông Kang đọc một bức thư gửi đến Fu Bao: 'Cảm ơn bạn đã yêu mến Fu Bao từ khi em ấy bắt đầu cuộc hành trình đến thế giới mới." +
                "Tôi rất tự hào khi thấy Fu Bao đã hoàn thành tất cả các quy trình để có thể trở thành một chú gấu trúc trưởng thành. " +
                "<br/>Tôi sẽ ở bên cạnh Fu Bao cho đến khi bạn ấy quen với ngôi nhà mới. Tôi tin rằng dù 10 năm hay 100 năm có trôi qua, Fu Bao vẫn là chú gấu trúc con vĩnh cửu của Everland. " +
                "Và xin mọi người hãy nhớ đến Fu Bao mãi mãi'.", DateTime.Parse("2024-04-03"), "Xã hội", "asset/images/xh1.jpg", "#"));
            newslist.Add(new News(3,
                "Tuyển thủ Đình Bắc khó gia nhập CLB Công an Hà Nội",
                "Trước đó, nhiều thông tin cho rằng Nguyễn Đình Bắc có thỏa thuận về việc gia nhập CLB CAHN. Nhưng theo tìm hiểu của phóng viên Dân trí, đôi bên chưa đi đến thỏa thuận này. Hiện tại, CLB CAHN có đến 4 cầu thủ thi đấu cùng vị trí với tiền đạo Nguyễn Đình Bắc, toàn những cầu thủ nổi tiếng. Danh sách này có Nguyễn Quang Hải, Phan Văn Đức, Jeferson Elias và Fialho De Aquino. Trong số đó, Phan Văn Đức vừa trở lại sau chấn thương. Ở vòng 14 V-League anh ghi được bàn thắng cho đội CAHN vào lưới đội Thanh Hóa, trên sân Thanh Hóa. Đấy chính là lý do mà đội đương kim vô địch V-League hiện không quá mặn mà trong việc săn đuổi chữ ký của tiền đạo Nguyễn Đình Bắc. Tiền đạo của đội tuyển quốc gia và đội tuyển U23 Việt Nam đang khoác áo CLB bóng đá Quảng Nam."+
                "<br/> Cách đây chỉ ít ngày, Nguyễn Đình Bắc vừa bị HLV Văn Sỹ Sơn của Quảng Nam góp ý:Đình Bắc có phần ảo tưởng về giá trị bản thân. Cậu ấy cần lắng nghe và học hỏi, cần được uốn nắn nhiều hơn."+
                "<br/>Hiện tại, CLB bóng đá Bình Định là đội bóng duy nhất công khai muốn có được chữ ký của tiền đạo Nguyễn Đình Bắc. Có thể trong thời gian tới, đội bóng đất võ sẽ đàm phán với đội bóng đất Quảng về vấn đề của Đình Bắc.",
                DateTime.Parse("2024-07-04"), "Thể thao", "asset/images/tt1.jpg", "#"));
            newslist.Add(new News(4,
                "Phải lòng Phú Quốc, phóng viên Hàn gọi nơi đây là 'Maldives của Việt Nam'",
                "Sau hành trình trải nghiệm Phú Quốc hồi tháng 2, phóng viên Kim Ji-won của tờ Chosun Ilbo - 1 trong 3 báo chính thống nhiều độc giả nhất Hàn Quốc - không tiếc lời ca ngợi đảo Ngọc của Việt Nam. Cô nói đây là chuyến du lịch thỏa mãn cả 5 giác quan."+
                "<br/>'Lâu lắm rồi tôi mới có chuyến bay đêm. Sau chuyến bay kéo dài 6 tiếng, chúng tôi đến Phú Quốc trong lúc bình minh tối mịt. Không có thời gian để cảm nhận sự phấn khích khi vừa đặt chân tới vùng đất mới, tôi đi thẳng về nơi ở của mình và leo lên giường. Tôi chưa bao giờ mơ rằng vài giờ sau, mình sẽ thức dậy trong ánh nắng lấp lánh phản chiếu trên mặt biển xanh ngọc trong vắt' - Kim Ji-won mở đầu bài viết của mình một cách đầy cảm xúc."+
                "<br/>Nữ phóng viên này khẳng định Phú Quốc cho đến nay vẫn là điểm đến 'hot' nhất của du khách nội vùng khi đến thăm Đông Nam Á sau đại dịch. Cô miêu tả: Chỉ trong vòng 10 năm, hòn đảo ở cực nam Việt Nam từ nơi chỉ có những trang trại tiêu và nhà máy sản xuất nước mắm, đã trở thành 'Maldives của Việt Nam'." +
                "<br/>Hơn một nửa hòn đảo vẫn được bảo vệ là khu bảo tồn sinh học của UNESCO, duy trì môi trường tự nhiên trong lành. Đặc biệt là khu vực phía nam Phú Quốc được phát triển dưới sự đầu tư của 'Sun Group' - nhà phát triển du lịch lớn nhất Việt Nam, mang đến cho du khách những giây phút thư giãn thoải mái trên bãi biển xinh đẹp và tham gia các hoạt động thú vị tại công viên giải trí khổng lồ. ",
                DateTime.Parse("2024-04-07"), "Xã hội", "asset/images/xh2.jpg", "#"));
            newslist.Add(new News(5,
                "'Nữ hoàng nước mắt' lập kỷ lục người xem, dọa soán ngôi 'Hạ cánh nơi anh'",
                " Bộ phim truyền hình Hàn Quốc 'Queen of tears' (Nữ hoàng nước mắt) tiếp tục có những thành tích đáng ngưỡng mộ và chứng tỏ sức hút mạnh mẽ của mình.." +
                "<br/>Tập 10 của Nữ hoàng nước mắt đạt con số kỷ lục về tỉ suất người xem 19%, tăng 4,6% so với tập phim trước đó. Con số 19% cũng là tỷ suất người xem cao nhất của bộ phim tính từ thời điểm phát sóng." +
                "Với con số 19%, tập 10 của Nữ hoàng nước mắt đã leo thẳng vị trí top 3 trong bảng xếp hạng những phim truyền hình có tỉ suất người xem cao nhất đài tvN, xếp sau Hạ cánh nơi anh (21,7%) và Yêu tinh (20,5%)." +
                "<br/>Tác phẩm đánh dấu sự trở lại màn ảnh nhỏ của tài tử Kim Soo Hyun sau vài năm nghỉ ngơi. Với nội dung hấp dẫn cùng dàn diễn viên trẻ, tài năng, Nữ hoàng nước mắt nhanh chóng tại cơn sốt tại châu Á. " +
                "Nhờ thành công của phim, tài tử Kim Soo Hyun nhanh chóng đứng đầu bảng xếp hạng nhân vật được tìm kiếm, có ảnh hưởng nhất trên mạng xã hội Instagram tại Hàn Quốc.",
                DateTime.Parse("2024-04-08"), "Xã hội", "asset/images/xh3.jpg", "#"));
            newslist.Add(new News(6,
                "Apple đưa ra yêu cầu cực khó với nhà cung cấp cho iPhone 16",
                "iPhone 16 sẽ có viền màn hình mỏng nhất từ trước đến nay, nhưng yêu cầu khó này của Apple có thể ảnh hưởng đến kế hoạch ra mắt iPhone mới và tăng giá thành sản phẩm."+
                "<br/>Theo AppleInsider, Apple đang yêu cầu các nhà cung cấp tấm nền iPhone 16 với viền mỏng hơn, sử dụng công nghệ BRS (Border Reduction Structure). Công nghệ BRS đòi hỏi độ chính xác cao và quy trình sản xuất phức tạp hơn, với việc bố trí các mạch điện tử bên dưới màn hình với độ khó rất cao." +
                "Đây cũng là công nghệ sẽ được sử dụng để giảm viền màn hình trên máy tính bảng iPad Pro (2024) 11 inch và 12,9 inch sắp ra mắt. iPad Pro 12,9 inch sẽ không chỉ là chiếc iPad đầu tiên được trang bị tấm nền OLED mà còn cho thấy màn hình sẽ trông như thế nào khi giảm kích thước của các viền. Với viền trên và cạnh bên của iPhone, kỹ thuật làm làm mỏng hơn không mấy khó khăn, nhưng việc thu nhỏ viền dưới lại gặp khó do vấn đề tản nhiệt." +
                "<br/>Do vấn đề về nhiệt, hệ thống dây điện ở phần dưới cùng của tấm nền sẽ phải được uốn cong xuống phía dưới. Điều này sẽ dẫn tới những thay đổi khác trong thiết kế do không gian trong iPhone bị hạn chế. Hiện tại, với những thay đổi này, không nhà cung cấp tấm nền nào có thể sản xuất màn hình iPhone 16 với năng suất đạt được yêu cầu của Apple. Ngoài ra, điều này cũng có thể làm chậm kế hoạch ra mắt và tăng giá thành iPhone mới. Báo cáo cũng cho biết thêm, LG Display, hãng cung cấp màn hình OLED iPhone cho Apple, đang thực hiện một số thay đổi trong chuỗi cung ứng với việc sử dụng chip DDI (Display Driver IC) của Novatech bên cạnh dòng chip của LX Semicon. Động thái này của LG Display được cho là nhằm cắt giảm chi phí vì nó tạo ra sự cạnh tranh giữa hai nhà cung cấp, từ đó sẽ giảm giá thành sản phẩm." +
                "Trước đó, nguồn tin của MacRumors cho biết, iPhone 16 Pro và iPhone 16 Pro Max ra mắt năm nay sẽ có màn hình lớn hơn. Cụ thể, iPhone 16 Pro sẽ có màn hình 6,3 inch (tăng so với iPhone 15 Pro từ 6,1 inch) và iPhone 16 Pro Max sẽ có màn hình 6,9 inch (tăng so với iPhone 15 Pro Max từ 6,7 inch).Cuối cùng, dòng iPhone 16 có thể sẽ được hỗ trợ AI tạo sinh, cho phép người dùng tương tác với chatbot hoặc tạo ảnh bằng văn bản ngay trên điện thoại. ",
                DateTime.Parse("2024-04-05"), "Khoa học & Công nghệ", "asset/images/kh2.jpg", "#"));
            newslist.Add(new News(7,
                "Cập nhật bảo mật Windows 10 sẽ có giá từ 1,5 triệu đồng",
                "Khách hàng sẽ có tuỳ chọn nâng cấp bảo mật mở rộng (ESU) Windows 10 với giá khởi điểm khoảng 1,5 triệu VNĐ (61 USD) cho năm đầu tiên." +
                "<br/>Nguyên nhân là do Microsoft sẽ chính thức ngừng hỗ trợ phiên bản Windows 10 vào ngày 14/10/2025. Sau thời điểm này, doanh nghiệp và người tiêu dùng sẽ cần mua giấy phép ESU cho mỗi thiết bị chạy Windows 10 mà họ dự định tiếp tục sử dụng." +
                "<br/>Với khối doanh nghiệp, 61 USD là giá áp dụng cho năm đầu tiên. Kể từ năm thứ hai, họ phải trả gấp đôi, 122 USD và tiếp tục gấp thếp lên 244 USD vào năm thứ ba. Trong trường hợp doanh nghiệp mua ESU vào năm thứ hai, họ cũng phải trả tiền cho năm thứ nhất do các bản nâng cấp bảo mật có giá trị tích luỹ." +
                "Thông thường Microsoft chỉ cung cấp những bản cập nhật mở rộng cho doanh nghiệp cần chạy phiên bản Windows cũ hơn. Song, lần này sẽ bao gồm cả đối tượng khách hàng cá nhân khi vẫn có một lượng lớn người sử dụng bản Win 10 - hệ điều hành đã 9 năm tuổi đời, được phát hành vào năm 2015." +
                "'Các bản cập nhật mở rộng không phải là một giải pháp lâu dài mà chỉ là một cầu nối tạm thời', Microsoft giải thích. “Khách hàng có thể mua giấy phép ESU cho các thiết bị Windows 10 bắt đầu từ tháng 10/2024, một năm trước khi chính thức kết thúc hỗ trợ”." +
                "<br/>Ngoài ra, những khách hàng sử dụng laptop hay PC chạy Windows 10 kết nối tới các PC đám mây chạy Windows 11 thông qua bộ Windows 365 sẽ không phải trả tiền cập nhật do chi phí đã bao gồm trong Windows 365." +
                "StatCounter cho hay Windows 10 vẫn chiếm 69% tổng số người dùng Windows, so với tỷ lệ chỉ 27% của Windows 11. Đây là một khoảng cách tương đối lớn mà Microsoft khó lòng thu hẹp trong vòng 18 tháng tới.",
                DateTime.Parse("2024-04-05"), "Khoa học & Công nghệ", "asset/images/kh3.jpg", "#"));
            newslist.Add(new News(8,
                "Google sẽ tính phí tính năng tìm kiếm bằng AI",
                "Google đang xem xét đưa một số tính năng tìm kiếm bằng AI vào danh sách dịch vụ tính phí, động thái chưa có tiền lệ với công ty kiếm tiền chủ yếu từ quảng cáo." +
                "<br/>Đề xuất này cho thấy Google vẫn vật lộn với công nghệ đang đe dọa mảng kinh doanh tìm kiếm cốt lõi của hãng. Nguồn tin của FT cho hay, các kỹ sư Google đã phát triển công nghệ cần thiết để triển khai dịch vụ nhưng các giám đốc điều hành vẫn chưa đưa ra quyết định cuối cùng về việc có nên ra mắt hay không và thời điểm ra mắt khi nào." +
                "Công cụ tìm kiếm truyền thống của công ty vẫn miễn phí, với việc quảng cáo tiếp tục xuất hiện cùng với kết quả tìm kiếm - ngay cả với những thuê bao trả phí. Việc tính phí tính năng tìm kiếm bằng AI phản ánh thay đổi lần đầu tiên trong nhiều năm của Google đối với sản phẩm cốt lõi của hãng, khi yêu cầu người dùng phải trả tiền cho những cải tiến đối với sản phẩm tìm kiếm." +
                "<br/>Google đã bắt đầu thử nghiệm dịch vụ tìm kiếm hỗ trợ bởi AI vào tháng 5/2023, với việc trả kết quả truy vấn chi tiết hơn, song song với việc cung cấp liên kết đến thông tin và quảng cáo. Tuy nhiên, việc đưa “trải nghiệm tìm kiếm tổng hợp” vào công cụ tìm kiếm của hãng vẫn còn chậm." +
                "<br/>Nhìn sang Microsoft, công ty có quan hệ đối tác với OpenAI, đã tích hợp AI dựa trên GPT, có tên Copilot vào trong công cụ tìm kiếm Bing từ hơn một năm trước. Dù vậy, tính năng AI hầu như không giúp tăng thị phần của Bing, vốn kém xa Google." +
                "<br/>Một số chuyên gia phân tích nhận định, hoạt động kinh doanh quảng cáo của Google sẽ bị tác động khi công cụ tìm kiếm AI trả lời truy vấn hoàn chỉnh mà không còn yêu cầu người dùng nhấp sang liên kết quảng cáo. Tiếp đó, nhiều nhà xuất bản trực tuyến phụ thuộc vào Google về lưu lượng truy cập bày tỏ lo ngại ít người click vào website của họ hơn nếu AI trích xuất thông tin từ trang web của họ và hiển thị trực tiếp cho người dùng. "+
                "Hiện Google đang cung cấp dịch vụ đăng ký tính phí Google One dành cho người dùng muốn truy cập chatbot Gemini tiên tiến nhất của hãng. Nền tảng AI này cũng được tích hợp vào bộ ứng dụng văn phòng Workspace gồm Gmail, Docs,…"+
                "Gã khổng lồ tìm kiếm cho biết họ loại trừ khả năng cung cấp trải nghiệm tìm kiếm không quảng cáo, nhưng sẽ 'tiếp tục phát triển các tính năng cao cấp để nâng cao dịch vụ trả phí'.",
                DateTime.Parse("2024-04-04"), "Khoa học & Công nghệ", "asset/images/kh4.jpg", "#"));
            newslist.Add(new News(9,
                "Man City có nguy cơ mất nhiều ngôi sao ở cuộc đấu với Real Madrid",
                "Trước cuộc so tài với Real Madrid ở tứ kết lượt đi Champions League trên sân Bernabeu ngày 10/4, Man City nhiều khả năng vắng mặt các trụ cột như Kyle Walker, Ederson, John Stones vì chấn thương. " +
                "<br/>Đội trưởng của Man City, Kyle Walker đã dính chấn thương trong trận giao hữu giữa đội tuyển Anh với Brazil hồi tháng 3. Kyle Walker không thể ra sân thi đấu ở Premier League trước Arsenal và Aston Villa, trong khi Man City rất cần sự phục vụ của hậu vệ tuyển Anh tại cuộc đua vô địch Premier League. " +
                "<br/>Kyle Walker đóng vai trò quan trọng trong đội hình của Man City, trong chiến thắng ở bán kết của The Citizens trước Real Madrid vào năm ngoái. Walker đã làm tốt nhiệm vụ ngăn cản Vinicius Jr và việc mất anh trong trận tứ kết Champions League sắp tới sẽ là một tổn thất nặng nề cho Man City." +
                "<br/>Điều này khiến Pep Guardiola và các trợ lý của ông rơi vào tình thế tiến thoái lưỡng nan về việc có nên mạo hiểm với hậu vệ này hay không." +
                "<br/>Trong khi đó, thủ thành số một của Man City, Ederson Moraes cũng vắng mặt trong cả hai trận đấu gần nhất ở Premier League. ",
                DateTime.Parse("2024-04-05"), "Thể thao", "asset/images/tt2.jpg", "#"));
            newslist.Add(new News(10,
                "AFC bình luận về U23 Việt Nam trước giải U23 châu Á",
                "Trong bài viết giới thiệu các đội bóng tham dự giải U23 châu Á, Liên đoàn bóng đá châu Á (AFC) đã đánh giá cao đội tuyển Việt Nam." +
                "<br/>AFC vừa có bài viết điểm qua từng đội bóng và những điểm nhấn đặc biệt trong lịch sử giải U23 châu Á. Trong đó, cơ quan quyền lực cao nhất của bóng đá châu Á đánh giá khá cao đội U23 Việt Nam." +
                "<br/>AFC viết: Ngoài những nhà cựu vô địch, U23 Việt Nam là đội duy nhất vào chung kết trong 5 kỳ giải trước, thua Uzbekistan trong trận chung kết năm 2018. Australia, Iraq, Nhật Bản, Jordan, Hàn Quốc, Saudi Arabia và Uzbekistan đều có cơ hội giương cao chức vô địch giải đấu. Họ vẫn là ứng cử viên sáng giá cho chức vô địch giải đấu ở Qatar năm 2024.Việc 3 đội giành vị trí cao nhất ở giải U23 châu Á 2024 sẽ giành quyền tham dự Olympic 2024 tạo động lực lớn cho các đội bóng. Do đó, giải đấu năm nay hứa hẹn vô cùng thú vị và căng thẳng ." +
                "<br/>Bình luận về hành trình của U23 Việt Nam ở giải U23 châu Á 2018, AFC viết: Thế hệ vàng của bóng đá Việt Nam, với Quang Hải là nhạc trưởng đã vươn lên ở giải đấu này Trên đường vào chung kết, U23 Việt Nam đã đánh bại hàng loạt đối thủ mạnh như Australia, Iraq và Qatar. Hàng nghìn người hâm mộ đã đổ xuống đường để ăn mừng chiến tích lịch sử của U23 Việt Nam. Dù U23 Uzbekistan đã giành chiến thắng nhưng siêu phẩm cầu vồng trong tuyết của Quang Hải đã khơi gợi ngọn lửa chiến đấu của U23 Việt Nam. Đáng ra, Quang Hải đã đặt dấu ấn mạnh mẽ hơn ở giải đấu năm đó nếu U23 Việt Nam giành chức vô địch." +
                "<br/>Ở giải U23 châu Á 2024, U23 Việt Nam sẽ nằm chung bảng với U23 Kuwait, U23 Uzbekistan và U23 Malaysia. Trong đó, đoàn quân của HLV Hoàng Anh Tuấn sẽ đá trận ra quân gặp U23 Kuwait vào ngày 17/4.",
                DateTime.Parse("2024-04-05"), "Thể thao", "asset/images/tt3.jpg", "#"));

            Application["newslist"] = newslist;

            List<User> users = new List<User>();
            users.Add(new User(1, "admin", "admin123", "admin" , "1234567a"));
            Application["Users"] = users;

            //Application["session_counter"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}