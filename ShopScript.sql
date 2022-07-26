USE [ShopPRN]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Category_ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](255) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK__Categori__6DB38D4EC88724F9] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Details]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[Status] [int] NOT NULL,
	[Created_Time] [date] NULL,
 CONSTRAINT [PK__Orders__F1E4639BA4E4D2F8] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [nvarchar](255) NULL,
	[Description] [ntext] NOT NULL,
	[Category_ID] [int] NOT NULL,
	[Price] [float] NULL,
	[Quantity] [int] NOT NULL,
	[Image] [varchar](255) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK__Products__9834FB9A9D59E333] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Role_ID] [int] IDENTITY(1,1) NOT NULL,
	[Role_Name] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Role_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/26/2022 11:14:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](255) NOT NULL,
	[Last_Name] [nvarchar](255) NOT NULL,
	[Role_ID] [int] NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Phone] [varchar](24) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[Status] [bit] NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Users__206D91908062DB47] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (1, N'Truyện Tranh', 1)
INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (2, N'Văn Học', 1)
INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (3, N'Sách Giáo Dục', 1)
INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (4, N'Sách Kinh Tế', 1)
INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (5, N'Sách Nấu ăn ', 1)
INSERT [dbo].[Categories] ([Category_ID], [Category_Name], [Status]) VALUES (6, N'Sách ngoại văn', 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_Details] ON 

INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (1, 3, 10, 1)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (2, 3, 6, 3)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (3, 4, 11, 3)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (4, 4, 13, 2)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (5, 3, 23, 3)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (6, 3, 11, 1)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (7, 3, 13, 2)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (8, 4, 13, 2)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (9, 4, 11, 1)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (10, 4, 17, 1)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (11, 5, 17, 2)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (12, 6, 6, 3)
INSERT [dbo].[Order_Details] ([Id], [Order_ID], [Product_ID], [Quantity]) VALUES (13, 6, 11, 1)
SET IDENTITY_INSERT [dbo].[Order_Details] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (3, 2, 76800, 1, CAST(N'2022-07-24' AS Date))
INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (4, 2, 308400, 1, CAST(N'2022-07-24' AS Date))
INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (5, 4, 1134480, 1, CAST(N'2022-07-25' AS Date))
INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (6, 5, 287900, 1, CAST(N'2022-07-25' AS Date))
INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (7, 5, 26200, 1, CAST(N'2022-07-25' AS Date))
INSERT [dbo].[Orders] ([Order_ID], [User_ID], [Total], [Status], [Created_Time]) VALUES (8, 5, 76800, 1, CAST(N'2022-07-25' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (6, N'Sách - Bí mật công  - Bí mật của Người Đẹp', N'Co gi ma phai de nhir', 1, 20000, 97, N'https://cf.shopee.vn/file/9e93998124be7f6e3d9cbbb0ce46dd87', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (10, N'Sách - Wild Life - Cuộc Sống Hoang Dã - Tập 12', N'Sau khi chuyển công tác từ R.E.D sang bệnh viện trực thuộc đại học Meio, Tessho đã phát hiện thú bệnh ở đây sau khi nhập viện thường bị viêm dạ dày cấp tính. Trưởng khoa Heinami chẩn đoán là do stress, nhưng Tessho lại cho rằng nguyên nhân chính là bị lây nhiễm trong bệnh viện! ', 1, 16800, 50, N'https://cf.shopee.vn/file/b7bf6d5000e2668dc01c9da416cd4969', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (11, N'Sách - Những câu chuyện về kiến thức an toàn trong cuộc sống - Phòng bếp “xì hơi”', N'Đứng trước những mối nguy hiểm tiềm tàng trong cuộc sống, các em không nên chỉ chờ đợi vào sự bảo vệ của người lớn, bởi người lớn không thể ở cạnh các em mọi lúc, mọi nơi, vì thế, các em phải tìm hiểu những phương pháp tự bảo vệ bản thân khi xảy ra sự cố bất ngờ. 
', 1, 16800, 24, N'https://cf.shopee.vn/file/ac019fa3c2ec25cadf653ed65cf97a0e', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (13, N'Sách - Phát triển tư duy sáng tạo giải nhanh BTTN Hóa học hữu cơ 12/2', N'Phát triển tư duy sáng tạo giải nhanh BTTN Hóa học hữu cơ 12/2Thầy viết cuốn sách này nhằm giúp các em ôn tập, củng cố kiến thức và vận dụng thành thạo phương pháp tư duy sáng tạo, để làm tốt các bài tập hóa hữu cơ 12 từ cơ bản đến nâng cao. ', 3, 129000, 194, N'https://cf.shopee.vn/file/e16b19eb1a54b9e49bce84844dbffff7', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (17, N'Sách - Bồi dưỡng Văn - Tiếng Việt 2/1', N'Môn Văn - Tiếng Việt là môn học rất cần thiết đối với các em. Học tốt môn Văn - Tiếng Việt là điều kiện thuận lợi để các em học tốt các môn học khác. Cuốn sách Bồi dưỡng Văn - Tiếng Việt 2 được biên soạn nhằm giúp các em có tư liệu học tập, phát triển tốt khả năng tìm hiểu văn thơ, mở rộng vốn từ, rèn luyện kĩ năng đặt câu và viết đoạn văn.
Bồi Dưỡng Văn - Tiếng Việt Lớp 2 (Tập 1) được biên soạn theo hướng dẫn thực hiện Chuẩn kiến thức, kĩ năng Bộ Giáo dục và Đào tạo  ban hành.
Mỗi bài học trong cuốn sách này đều có mục tiêu để các em xác định yêu cầu cần đạt, có hướng dẫn tìm hiểu bài và bài tập áp dụng.', 3, 13100, 297, N'https://cf.shopee.vn/file/34451b856b7cb5dbbd24953c0c834618', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (18, N'Sách - Bứt Phá Điểm Thi Môn Hóa Học Phần Vô Cơ - Phiên Bản Đặc Biệt 2019', N'Hóa học là một môn học khó, đòi hỏi các em phải nắm vững được những kiến thức cơ bản. Các em học sinh chủ yếu không biết bắt đầu giải bài tập từ đâu trong khi không có những kiến thức cơ bản, các công thức hóa học lại rất khó nhớ và luôn là “ác mộng” với các em. Học sinh học trước quên sau chẳng đọng lại được tí kiến thức nào.', 3, 117200, 50, N'https://cf.shopee.vn/file/a2d13823076a2b593f7ed21e012f3770', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (19, N'Sách - Giải Bài Tập Vật Lí 12 - Nâng Cao', N'Sách được biên soạn dựa trên chương trình Sách giáo khoa do Bộ GD&ĐT ban hành.
Nội dung cuốn sách gồm', 3, 41000, 0, N'https://cf.shopee.vn/file/923c0517ec3c2063232591f6f12371e5', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (20, N'Sách - 168 Món Ngon Dễ Làm', N'Chuẩn bị bữa ăn vừa nhanh gọn, tiết kiệm thời gian vừa hấp dẫn là điều băn khoăn thường trực của người nội trợ. Một thực đơn khoa học và hợp lý phải đảm bảo đầy đủ các yếu tố: tính dinh dưỡng, ngon miệng, đẹp mắt, sự hài hòa giữa các món ăn... Cuốn sách này sẽ cung cấp cho bạn bí quyết để trổ tài nấu những bữa ăn thật ngon và bổ dưỡng cho gia đình.', 5, 37000, 20, N'https://cf.shopee.vn/file/f951be467d82890179bb2699419751a6', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (21, N'Sách 155 Món ăn ngon miệng Ndbooks', N'Nấu ăn là một nghệ thuật. nhằm giúp người nội trợ có được thực đơn ngon, bổ dưỡng, phong phú cho bữa ăn hàng ngày, chúng tôi giới thiệu cuốn sách 155 Món Ăn Ngon Miệng được biên soạn từ những kinh nghiệm trong thực tế của người đầu bếp tài ba, cuốn sách là tập hợp những món ăn ngon, độc đáo, cách chế biến không quá cầu kỳ, nguyên liệu dễ tìm, vừa áp dụng được trong bữa ăn hàng ngày vừa phù hợp với các buổi liên hoan, đãi tiệc. Bạn có thể tìm thấy nhiều món mới lạ, cách nấu lạ, nhưng không đi ngược với khẩu vị truyền thống của người Việt, còn với nhiều món ăn quen thuộc, bạn sẽ thấy rằng chỉ cần thay đổi chút ít nguyên liệu, hương vị cũng khiến món ăn lạ miệng hơn rất nhiều. Chúng tôi tin rằng cuốn sách sẽ giúp bạn tự tin thể hiện tài nấu ăn của bản thân trước mặt bạn bè, gia đình…', 5, 24000, 20, N'https://cf.shopee.vn/file/80ee2f8420db63b48fed8b14e54e9f22', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (22, N'Sách - Cô gái cãi lời Thượng đế', N'"Tớ đã vì cậu mà tin vào tất cả những điều hoang đường nhất. Đã vì cậu mà lang thang năm châu bốn bể tìm cách về quá khứ. Đã vì cậu mà ngu ngốc làm hại bao nhiêu người. Đến cả cuộc sống của chính mình, bây giờ tớ chỉ có thể cắn răng mà chấp nhận những sứt mẻ. Vậy mà cậu chẳng hay chẳng biết gì hết… "


Trong cuộc đời này, đã có chàng trai hay cô gái nào khiến bạn yêu đến ngu muội, yêu đến thay đổi tâm tính, yêu đến cả bản thân cũng không màng, đến nỗi bạn có thể vứt bỏ tất cả vì người ấy chưa?', 2, 70850, 100, N'https://cf.shopee.vn/file/a39adbaa66fa32fdd0bacc4c9ece9d48', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (23, N'Sách - Combo 2 cuốn : Cách Để Đạt 1 Triệu Follow + Bán hàng, quảng cáo và kiếm tiền trên Facebook', N'Bạn có muốn nắm trong tay quyền lực không?
Nếu có thì đây chính là cuốn sách cho bạn đấy. One Million Followers là cuốn sách hướng dẫn cách tận dụng những nền tảng truyền thông xã hội như Facebook, Instagram, Youtube…để tạo ra ảnh hưởng, trở thành người của công chúng và nắm trong tay quyền lực. Những bí quyết mà tác giả Brendan Kane chia sẻ trong cuốn sách này tuy nhỏ mà có võ, đọc cái hiểu ngay nhưng nhiều khi ta không nhận ra.
Tuy là một cuốn sách rất THỰC DỤNG về marketing số, nhưng One Million Followers vẫn không quên nhắc bạn những vấn đề triết lý. Đó là suy cho cùng, có nhiều người theo dõi để làm gì? Có quyền lực để làm gì? Để cải biến thế giới, thay vì than thở, các bạn ạ!
', 4, 286560, 7, N'https://cf.shopee.vn/file/010a532f76be2d6b24fb9b54f9a7368a', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (24, N'Sách - Tư Duy Tích Cực - Bạn Chính Là Những Gì Bạn Nghĩ - First News', N'sdawewqejqwehiuqweq', 4, 46400, 200, N'https://cf.shopee.vn/file/aebf16bd1f1c4901cd3d9b78bf9b5acd', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (25, N'Sách - Doraemon Truyện Ngắn - Tập 7 (Tái Bản 2019)', N'Chuyện nổi tiếng về chú mèo máy thông minh Doraemon và các bạn.', 1, 17600, 55, N'https://cf.shopee.vn/file/86a677746c7d13fcd020c18c0745df3b', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (26, N'Sách - Thám Tử Lừng Danh Conan - Tập 97', N'Thám Tử Lừng Danh Conan - Tập 97 Conan, Mori Kogoro, Amuro Toru, và Wakita Kanenori. Bộ tứ kì lạ ấy cùng nhau đi tới một nhà thờ bỏ hoang ẩn mình trong núi sâu ở Nagano. Phải chăng chờ đợi họ ở đó là những án mạng và những mật mã bí ẩn!? Giữa lúc ấy, Conan cố gắng tìm kiếm gợi ý quan trọng liên quan tới chân tướng của “RUM” từ Amuro…!', 1, 15900, 400, N'https://cf.shopee.vn/file/c01840a2e7e65caa2bc77a3834a1e8ac', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (27, N'Sách - Nghệ thuật làm bánh và chụp ảnh (bìa mềm)', N'Đây chính là nơi số phận của chúng tôi bắt đầu.
Năm đó, tôi bắt đầu có nhiệt huyết với công việc nướng bánh, chụp ảnh những chiếc bánh ngọt của riêng tôi, kiên trì viết blog để ghi chép lại, và nhiều hình ảnh bánh ngọt của tôi đã được chụp bởi nhiếp ảnh gia này. Tôi ngưỡng mộ những bức ảnh ở trạng thái ngẫu nhiên của thực phẩm mà cô ấy có thể chụp được.
Nghệ Thuật Làm Bánh sẽ cung cấp cho các bạn cách thức để làm ra những chiếc bánh thật ngon. Bằng các nguyên liệu bạn chuẩn bị sẵn thì chỉ cần vào bếp với quyển sách hướng dẫn cách làm bánh này thì bạn có thể hoàn toàn yên tâm chất lượng bánh khi ra lò.
Bạn sẽ không còn tự ti khả năng làm bánh của mình nữa khi sở hữu cuốn sách này, bạn có thể dùng nó để làm ra những chiếc bánh cho người thân hoặc tặng cho người đặc biệt của mình.', 5, 112000, 200, N'https://cf.shopee.vn/file/5b7669c2c605eb6ba48a3383ed062e0b', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (28, N'Sách - Tâm lý học tội phạm tập 2', N'"Tâm lý học tội phạm" là bộ sách gồm 2 tập đề cập đến quyền lựa chọn, ý chí tự do, cái thiện và cái ác, phản ứng trước cám dỗ và sự thể hiện lòng dũng cảm hay hèn nhát khi đối mặt với nghịch cảnh của con người. Những cuốn sách thiêng liêng của các tôn giáo đều khuyên loài người không nên lừa dối, giận dữ và kiêu ngạo. Chúng ta nghĩ bản thân thế nào thì sẽ là như thế. Chúng ta không thể giúp một người từ bỏ tội ác và sống có trách nhiệm nếu không thể khiến anh ta thay đổi nhân tính, đó chính là "suy nghĩ".
Ấn bản đầu tiên của cuốn sách “Tâm lý học tội phạm” được xuất bản năm 1984, và ấn bản thứ hai xuất bản năm 2004. Sau một thập kỷ, và đã đến lúc bổ sung thêm các thông tin cho cuốn sách này. Trong ấn bản này, bạn sẽ hiểu chi tiết về các quá trình tư duy và chiến thuật phổ biến đối với những kẻ phạm tội, bất kể lý lịch hay tội ác của chúng.', 6, 89000, 150, N'https://cf.shopee.vn/file/18f0ac619eba8ae9b3b683795070f379', 1)
INSERT [dbo].[Products] ([Product_ID], [Product_Name], [Description], [Category_ID], [Price], [Quantity], [Image], [status]) VALUES (29, N'Sách - SỐNG SÓT: Những Câu Chuyện Thoát Hiểm Và Sinh Tồn Kỳ Thú [AZVietNam]', N'Một cậu phục vụ tàu lênh đênh 133 ngày trên Đại Tây Dương, hút máu cá mập uống thay nước
Một nữ sinh rơi từ máy bay, băng qua rừng rậm Amazon tìm đường sống
Một người phi công lao cả chiếc trực thăng xuống miệng núi lửa', 6, 129000, 30, N'https://cf.shopee.vn/file/4cb3998a1c4900ba572d72450c04df81', 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Role_ID], [Role_Name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([Role_ID], [Role_Name]) VALUES (2, N'Customer')
INSERT [dbo].[Roles] ([Role_ID], [Role_Name]) VALUES (3, N'Staff')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([User_ID], [First_Name], [Last_Name], [Role_ID], [Username], [Password], [Phone], [Address], [Status], [Email]) VALUES (1, N'Lê ', N'Phúc', 2, N'phuc123', N'123abc', N'0987462813', N'HXXA', 0, N'phuc@gmail.com')
INSERT [dbo].[Users] ([User_ID], [First_Name], [Last_Name], [Role_ID], [Username], [Password], [Phone], [Address], [Status], [Email]) VALUES (2, N'Kamisato', N'Ayaka', 2, N'ayaka', N'asdsm', N'0238481293', N'Inazuma', 0, N'ayaka@gmail.com')
INSERT [dbo].[Users] ([User_ID], [First_Name], [Last_Name], [Role_ID], [Username], [Password], [Phone], [Address], [Status], [Email]) VALUES (3, N'Nguyễn', N'Văn Rin', 1, N'rinadmin', N'admin', N'0987564737', N'SE1607', 1, N'rin@gmail.com')
INSERT [dbo].[Users] ([User_ID], [First_Name], [Last_Name], [Role_ID], [Username], [Password], [Phone], [Address], [Status], [Email]) VALUES (4, N'Thanh', N'Hien', 2, N'user', N'123', N'0988737489', N'1312', 1, N'123')
INSERT [dbo].[Users] ([User_ID], [First_Name], [Last_Name], [Role_ID], [Username], [Password], [Phone], [Address], [Status], [Email]) VALUES (5, N'Lê Hồng', N'Phúc', 2, N'phuc', N'123', N'0985754323', N'?eq21', 1, N'12314')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF__Products__Percen__2E1BDC42]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Status__2F10007B]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Email__300424B4]  DEFAULT ((1)) FOR [Email]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_OrderOrderDetail] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([Order_ID])
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_OrderOrderDetail]
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderDetail] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Products] ([Product_ID])
GO
ALTER TABLE [dbo].[Order_Details] CHECK CONSTRAINT [FK_ProductOrderDetail]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_UserOrder] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Users] ([User_ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_UserOrder]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProduct] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Categories] ([Category_ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_CategoryProduct]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_RoleUser] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Roles] ([Role_ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_RoleUser]
GO
