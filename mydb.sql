USE [master]
GO
/****** Object:  Database [mydb]    Script Date: 2023/4/26 上午 03:46:40 ******/
CREATE DATABASE [mydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mydb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\mydb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mydb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\mydb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [mydb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [mydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mydb] SET RECOVERY FULL 
GO
ALTER DATABASE [mydb] SET  MULTI_USER 
GO
ALTER DATABASE [mydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mydb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mydb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mydb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mydb', N'ON'
GO
ALTER DATABASE [mydb] SET QUERY_STORE = ON
GO
ALTER DATABASE [mydb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [mydb]
GO
/****** Object:  Table [dbo].[productimage]    Script Date: 2023/4/26 上午 03:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productimage](
	[productid] [int] NULL,
	[image] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productinfo]    Script Date: 2023/4/26 上午 03:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productinfo](
	[productid] [int] IDENTITY(1,1) NOT NULL,
	[productname] [nvarchar](50) NULL,
	[productprice] [int] NULL,
	[productstock] [int] NULL,
	[productdescribe] [nvarchar](1000) NULL,
 CONSTRAINT [PK_productinfo] PRIMARY KEY CLUSTERED 
(
	[productid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test1]    Script Date: 2023/4/26 上午 03:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[地址] [nvarchar](50) NULL,
 CONSTRAINT [PK_test1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 2023/4/26 上午 03:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userinfo](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[user姓名] [nvarchar](50) NULL,
	[user電話] [nvarchar](50) NULL,
	[user電子郵件] [nvarchar](50) NULL,
	[user出生日期] [date] NULL,
	[user性別] [char](1) NULL,
	[user身分] [int] NULL,
 CONSTRAINT [PK_userinfo] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User登入]    Script Date: 2023/4/26 上午 03:46:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User登入](
	[userid] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User登入] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[productimage] ([productid], [image]) VALUES (1, N'2304260036264337.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (3, N'橙蜜佳人1.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (2, N'天堂玫瑰1.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (4, N'2304260106201418.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (5, N'2304260118382112.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (6, N'2304260122214889.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (7, N'2304260132035199.jpg')
INSERT [dbo].[productimage] ([productid], [image]) VALUES (8, N'2304260134487104.jpg')
GO
SET IDENTITY_INSERT [dbo].[productinfo] ON 

INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (1, N'哥斯大黎加 音樂家系列', 395, 51, N'卡內特位於哥斯大黎加Tarrazu咖啡種植的最高海拔區域。此區為哥斯大黎加水果種植最密集的區域，莊園主以種植百香果為主，咖啡數量則相當稀少，只有再一個特定的區域種植咖啡，採取了特殊的照顧，只摘採成熟的紅櫻桃果實。葡萄乾蜜處理算是一種雙重發酵蜜處理的方式，先將咖啡果曬成葡萄乾的狀態，再脫果皮蜜處理發酵，在風味上發酵氣息會更濃郁，而且果膠保存上比其他蜜處理更高，100%果膠蜜處理真的很有葡萄乾風味。這是一款相當甜的處理法，有著白葡萄酒的口感和平衡的酸味，在風味上發酵氣息會更濃郁，而且果膠保存上比其他蜜處理更高。')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (2, N'衣索比亞 古吉 / 天堂玫瑰日曬', 320, 35, N'甜美的水蜜桃帶有藍莓、佛手柑香氣。入口同樣以藍莓、水蜜桃為主軸，伴隨著紅茶香氣，餘韻悠長，風味飽滿')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (3, N'衣索比亞 / 橙蜜佳人 G1水洗', 395, 20, N'入口為香甜細緻的水蜜桃、檸檬皮、佛手柑、檸檬及茉莉花香，中後段浮現桃子及烏龍茶韻，扎實飽滿')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (4, N'衣索比亞 / 露西藝伎 G1水洗', 395, 20, N'露西處理廠就位在衣索比亞班奇馬吉的GEISHA ( 瑰夏 ) 地區，且與大名鼎鼎的藝妓村比鄰而居，無論是巴拿馬藝伎、瓜地馬拉藝伎、台灣藝伎，全世界範圍內的藝伎品種咖啡皆來自於此，這也正是該處理站命名為「LUCY」的原因，如同其普遍被認為是人類起源的化石名稱，露西處理站希望能同樣肩負發揚藝妓咖啡的使命，將世界上最好喝、純正的藝妓咖啡分享到全世界。

露西處理站相當年輕，雖然離正式啟用僅不到10年的時間，卻已能生產出風味完全不遜中南美洲藝伎的風味，這除了得益於在地品種的生長優勢外，GEISHA 地區的土壤養份及氣候風土環境完完全全就是為了藝伎咖啡量身打造，恰如其分的溫度變化及降雨量不斷的孕育出風味迷人的咖啡果實。')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (5, N'巴拿馬 / 阿波羅日曬', 395, 10, N'巴拿馬咖啡起源於1780年，由歐洲移民引進第一批Typica樹種開始。地處中美洲，擁有陽光、土地、高山的自然優勢條件，加上與充足勞動人口，讓該地區成為種植生產高品質精緻咖啡的絕佳地區，正是孕育咖啡的天堂。尤其產自巴拿馬的藝伎種咖啡更帶動全球關注精品咖啡潮流，成功吸引全球市場對於巴拿馬咖啡的興趣。波魁特地區(Boquete)是巴拿馬最古老且最著名的咖啡產區，位於巴魯火山東側，海拔約1000~2000公尺的高原。其中「巴魯火山國家公園」(Volcan Baru National Park)，為生態保育區，生物多樣性非常豐富，擁有7種微氣候，加上終年籠罩於薄霧之中，雨量豐沛，造就當地的很好的栽植條件，讓波魁特咖啡具有獨特香氣，為巴拿馬咖啡產量最多，品質最佳的產區。每到採收季節時期，咖啡農民會以水洗式精緻法，與日曬進行乾燥，讓咖啡生豆飽滿又風味純正。

巴魯火山不僅是巴拿馬全國最高山脈，早期火山活動與噴發造就的沉積物質帶來大量且很肥沃的土壤，這些土壤富含物質，火山灰尤其含有豐富的磷和硫與黏土混合後，加上獨特的氣候模式，讓本區域形成一個適合優質咖啡生長的環境，蓊密的森林與甚多物種更造成生物的多樣性。

這裡的咖啡農約有50名組成一個小型合作社，都是採用波奎特傳統的方式來生產咖啡—讓咖啡在接近天然的環境中成長。雖然產量不高，但可以維持豐富的生態環境，土壤質量可以保持甚至改善。天然種植方式不只有利環境，由於咖啡果實生長緩慢，因此更容易生長出質優而風味佳的咖啡豆。農民人工採收下完熟的咖啡漿果，送至鄰近的Café de Eleta S.A.做後製的處理，處理工廠距離農場約4公里的路程，並且附設了一座現代化的實驗室用以杯測品管及人工篩選。')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (6, N'哥倫比亞 阿道夫莊園 / 葡萄特殊發酵', 395, 22, N'風味丨葡萄飛壘口香糖、藍莓果醬濃郁香氣，入口同樣藍莓果醬、葡萄汁、深色莓果及葡萄芬達汽水香氣，強勁飽滿
烘焙度丨淺中焙
處理法丨葡萄特殊發酵 厭氧處理
產區丨哥惀比亞 薇拉省 聖阿道夫莊園
品種丨原生種')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (7, N'嚴選藍山風味拿鐵配方', 200, 100, N'風味｜烤堅果、奶油、核桃、榛果、焦糖、柑橘、淡淡茉莉花香。口感圓潤滑順、甜感高
烘焙度｜中、深焙
混豆產區｜ 莊園級哥倫比亞混合 (100%阿拉比卡豆)
處理法｜水洗
適合｜義式品項、拿鐵、Espresso、美式咖啡、手沖')
INSERT [dbo].[productinfo] ([productid], [productname], [productprice], [productstock], [productdescribe]) VALUES (8, N'私藏配方豆 / 清爽配方', 220, 100, N'【口感特色】
焙度｜淺、中焙
風味｜柑橘、檸檬為酸值的主調性，並由些許莓果和蔗糖風味做陪襯，口感清爽滑順
混豆產區｜莊園級哥倫比亞、伊索比亞、肯亞混合
適合｜拿鐵、美式咖啡、手沖')
SET IDENTITY_INSERT [dbo].[productinfo] OFF
GO
SET IDENTITY_INSERT [dbo].[test1] ON 

INSERT [dbo].[test1] ([id], [姓名], [地址]) VALUES (1, N'test1', N'高雄市')
INSERT [dbo].[test1] ([id], [姓名], [地址]) VALUES (2, N'test2', N'台北市')
INSERT [dbo].[test1] ([id], [姓名], [地址]) VALUES (3, N'test3', N'台南市')
SET IDENTITY_INSERT [dbo].[test1] OFF
GO
SET IDENTITY_INSERT [dbo].[userinfo] ON 

INSERT [dbo].[userinfo] ([userid], [user姓名], [user電話], [user電子郵件], [user出生日期], [user性別], [user身分]) VALUES (1, N'王小明', N'0925100100', N'wewe@gmail.com', CAST(N'1998-02-01' AS Date), N'm', 0)
INSERT [dbo].[userinfo] ([userid], [user姓名], [user電話], [user電子郵件], [user出生日期], [user性別], [user身分]) VALUES (4, N'test', N'102555888', N'wewe', CAST(N'2023-04-20' AS Date), N'M', 0)
INSERT [dbo].[userinfo] ([userid], [user姓名], [user電話], [user電子郵件], [user出生日期], [user性別], [user身分]) VALUES (5, N'tes', N'092255555', N'wewe', CAST(N'2023-04-20' AS Date), N'M', 1)
INSERT [dbo].[userinfo] ([userid], [user姓名], [user電話], [user電子郵件], [user出生日期], [user性別], [user身分]) VALUES (6, N'test', N'0925555444', N'wewe', CAST(N'2023-04-20' AS Date), N'M', 1)
INSERT [dbo].[userinfo] ([userid], [user姓名], [user電話], [user電子郵件], [user出生日期], [user性別], [user身分]) VALUES (7, N'test', N'0925555444', N'wewe', CAST(N'2023-04-20' AS Date), N'M', 2)
SET IDENTITY_INSERT [dbo].[userinfo] OFF
GO
INSERT [dbo].[User登入] ([userid], [UserName], [Password]) VALUES (1, N'123', N'456')
INSERT [dbo].[User登入] ([userid], [UserName], [Password]) VALUES (7, N'wewe', N'741')
GO
ALTER TABLE [dbo].[productimage]  WITH CHECK ADD  CONSTRAINT [FK_productimage_productinfo] FOREIGN KEY([productid])
REFERENCES [dbo].[productinfo] ([productid])
GO
ALTER TABLE [dbo].[productimage] CHECK CONSTRAINT [FK_productimage_productinfo]
GO
ALTER TABLE [dbo].[User登入]  WITH CHECK ADD  CONSTRAINT [FK_User登入_userinfo] FOREIGN KEY([userid])
REFERENCES [dbo].[userinfo] ([userid])
GO
ALTER TABLE [dbo].[User登入] CHECK CONSTRAINT [FK_User登入_userinfo]
GO
USE [master]
GO
ALTER DATABASE [mydb] SET  READ_WRITE 
GO
