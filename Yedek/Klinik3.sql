USE [master]
GO
/****** Object:  Database [KlinikDB]    Script Date: 26.01.2020 16:11:04 ******/
CREATE DATABASE [KlinikDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KlinikDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KlinikDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KlinikDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\KlinikDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KlinikDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KlinikDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KlinikDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KlinikDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KlinikDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KlinikDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KlinikDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KlinikDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KlinikDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KlinikDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KlinikDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KlinikDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KlinikDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KlinikDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KlinikDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KlinikDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KlinikDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KlinikDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KlinikDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KlinikDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KlinikDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KlinikDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KlinikDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KlinikDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KlinikDB] SET RECOVERY FULL 
GO
ALTER DATABASE [KlinikDB] SET  MULTI_USER 
GO
ALTER DATABASE [KlinikDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KlinikDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KlinikDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KlinikDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KlinikDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KlinikDB', N'ON'
GO
ALTER DATABASE [KlinikDB] SET QUERY_STORE = OFF
GO
USE [KlinikDB]
GO
/****** Object:  Table [dbo].[Cinsiyet]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cinsiyet](
	[C_ID] [tinyint] NOT NULL,
	[Cinsiyet] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hasta]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hasta](
	[H_ID] [int] IDENTITY(1,1) NOT NULL,
	[H_AD] [varchar](50) NULL,
	[H_SOYAD] [varchar](50) NULL,
	[H_DTARIH] [date] NULL,
	[H_TC] [char](11) NULL,
	[H_TEL] [varchar](13) NULL,
	[H_ADRES] [nvarchar](255) NULL,
	[H_CID] [tinyint] NULL,
	[H_DURUM] [bit] NULL,
	[H_EMAIL] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[H_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hizmet]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hizmet](
	[H_ID] [int] IDENTITY(1,1) NOT NULL,
	[H_AD] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[H_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_AD] [varchar](50) NULL,
	[P_SOYAD] [varchar](50) NULL,
	[P_DTARIH] [date] NULL,
	[P_TC] [char](11) NULL,
	[P_TEL] [varchar](13) NULL,
	[P_ADRES] [varchar](255) NULL,
	[P_EMAIL] [varchar](50) NULL,
	[P_SIFRE] [nvarchar](50) NULL,
	[P_CID] [tinyint] NULL,
	[P_POZISYONID] [tinyint] NULL,
	[P_DURUM] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pozisyon]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pozisyon](
	[P_ID] [tinyint] NOT NULL,
	[P_AD] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevu]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevu](
	[R_ID] [int] IDENTITY(1,1) NOT NULL,
	[R_PERSONELID] [int] NULL,
	[R_HASTAID] [int] NULL,
	[R_HIZMETID] [int] NULL,
	[R_DURUMID] [tinyint] NULL,
	[R_TARIH] [smalldatetime] NULL,
	[R_ACIKLAMA] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[R_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RDurum]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RDurum](
	[D_ID] [tinyint] NOT NULL,
	[D_AD] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RSonuc]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RSonuc](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_RANDEVUID] [int] NULL,
	[S_TURID] [tinyint] NULL,
	[S_ACIKLAMA] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RSTur]    Script Date: 26.01.2020 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RSTur](
	[T_ID] [tinyint] NOT NULL,
	[T_AD] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cinsiyet] ([C_ID], [Cinsiyet]) VALUES (0, N'Erkek')
INSERT [dbo].[Cinsiyet] ([C_ID], [Cinsiyet]) VALUES (1, N'Kadın')
INSERT [dbo].[Cinsiyet] ([C_ID], [Cinsiyet]) VALUES (2, N'Belirsiz')
SET IDENTITY_INSERT [dbo].[Hasta] ON 

INSERT [dbo].[Hasta] ([H_ID], [H_AD], [H_SOYAD], [H_DTARIH], [H_TC], [H_TEL], [H_ADRES], [H_CID], [H_DURUM], [H_EMAIL]) VALUES (1, N'Osman', N'Hamdi', CAST(N'1998-08-03' AS Date), N'14776865432', N'05532581953', N'pendik', 0, 1, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_AD], [H_SOYAD], [H_DTARIH], [H_TC], [H_TEL], [H_ADRES], [H_CID], [H_DURUM], [H_EMAIL]) VALUES (2, N'Kazım', N'Karabekir', CAST(N'1990-07-02' AS Date), N'12345678911', N'05529548888', N'maltepe', 0, 0, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_AD], [H_SOYAD], [H_DTARIH], [H_TC], [H_TEL], [H_ADRES], [H_CID], [H_DURUM], [H_EMAIL]) VALUES (3, N'Elmas', N'Koç', CAST(N'2020-01-17' AS Date), N'14778568445', N'05532581566', N'Aydınlı mah. koçtaş. sk. İstanbul Pendik', 1, 1, N'elmaas@gmail.com')
INSERT [dbo].[Hasta] ([H_ID], [H_AD], [H_SOYAD], [H_DTARIH], [H_TC], [H_TEL], [H_ADRES], [H_CID], [H_DURUM], [H_EMAIL]) VALUES (4, N'Nalan', N'Tunç', CAST(N'1990-08-12' AS Date), N'14776525889', N'05523581955', N'Erciyes bulvarı, yenişehir mah. Koçtaş sokak No: 24 D:90 Kat:20 
Pendik/ İstanbul', 1, 1, N'gizemtunc@gmail.com')
SET IDENTITY_INSERT [dbo].[Hasta] OFF
SET IDENTITY_INSERT [dbo].[Hizmet] ON 

INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (1, N'Diyetisyenlik')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (2, N'Bütünsel Sağlık Paketi')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (3, N'Hekimlik Hizmeti')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (4, N'Ozon Tedavi')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (5, N'Ozon Sauna')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (6, N'Kuru İğne')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (7, N'PRP (Tedavi Amaçlı)')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (8, N'PRP (Estetik Amaçlı)')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (9, N'Botoks')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (10, N'Dolgu')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (11, N'Mezoterapi')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (12, N'İp Askı (Fransız Askısı)')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (13, N'Cilt Bakımı')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (14, N'Maske Uygulaması')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (15, N'Masaj')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (16, N'Glutatyon')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (17, N'C Vitamini + Magnezyum')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (18, N'Prokain')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (19, N'Kurumsal Hizmet')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (20, N'Saç Ekimi')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (21, N'Yoga')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (22, N'Ayak Terapisi')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (23, N'Psikolojik Danışmanlık')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (24, N'Emdr')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (25, N'Fitoterapik Uygulamalar')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (26, N'Aromaterapik Uygulamalar')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (27, N'65 Uygulaması')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (28, N'Ek Hekimlik Uygulaması')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (29, N'Laboratuvar Hizmetleri')
INSERT [dbo].[Hizmet] ([H_ID], [H_AD]) VALUES (30, N'Ürün Satışı')
SET IDENTITY_INSERT [dbo].[Hizmet] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([P_ID], [P_AD], [P_SOYAD], [P_DTARIH], [P_TC], [P_TEL], [P_ADRES], [P_EMAIL], [P_SIFRE], [P_CID], [P_POZISYONID], [P_DURUM]) VALUES (1, N'Admin', N'Yönetim', CAST(N'1998-08-12' AS Date), N'14768665424', N'05525895542', N'Göztepe', N'atanur@gmail.com', N'445566', 0, 1, 1)
SET IDENTITY_INSERT [dbo].[Personel] OFF
INSERT [dbo].[Pozisyon] ([P_ID], [P_AD]) VALUES (1, N'Yönetici')
INSERT [dbo].[Pozisyon] ([P_ID], [P_AD]) VALUES (2, N'Danışman')
INSERT [dbo].[Pozisyon] ([P_ID], [P_AD]) VALUES (3, N'Diyetisyen')
INSERT [dbo].[Pozisyon] ([P_ID], [P_AD]) VALUES (4, N'Doktor')
SET IDENTITY_INSERT [dbo].[Randevu] ON 

INSERT [dbo].[Randevu] ([R_ID], [R_PERSONELID], [R_HASTAID], [R_HIZMETID], [R_DURUMID], [R_TARIH], [R_ACIKLAMA]) VALUES (3, 1, 1, 1, 1, CAST(N'2018-08-19T12:48:00' AS SmallDateTime), N'Lorem ipsum dolor sitamet. Lorem ipsum dolor sit amet bi')
SET IDENTITY_INSERT [dbo].[Randevu] OFF
INSERT [dbo].[RDurum] ([D_ID], [D_AD]) VALUES (1, N'Alındı')
INSERT [dbo].[RDurum] ([D_ID], [D_AD]) VALUES (2, N'Alındı')
INSERT [dbo].[RDurum] ([D_ID], [D_AD]) VALUES (3, N'Tamamlandı')
INSERT [dbo].[RDurum] ([D_ID], [D_AD]) VALUES (4, N'Düzenlendi')
SET IDENTITY_INSERT [dbo].[RSonuc] ON 

INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (5, 3, 1, N'Hikaye Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (6, 3, 2, N'Aile Öyküsü Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (7, 3, 12, N'Not Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (8, 3, 2, N'Aile Öyküsü 2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (9, 3, 2, N'Aile Öyküsü 3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (10, 3, 2, N'Aile Öyküsü 4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (11, 3, 2, N'Aile Öyküsü 5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
INSERT [dbo].[RSonuc] ([S_ID], [S_RANDEVUID], [S_TURID], [S_ACIKLAMA]) VALUES (12, 3, 2, N'Aile Öyküsü 6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras vitae pulvinar nisl. Curabitur pretium laoreet leo eget facilisis. Quisque sodales dui vel porttitor venenatis. In pulvinar diam eget risus fringilla, eu mattis nisl auctor. Duis sodales sem id posuere ornare. Vivamus elementum libero metus, ut molestie leo venenatis vitae. Fusce vitae commodo tellus, quis blandit neque. Proin tristique sollicitudin pharetra. Donec euismod posuere hendrerit.')
SET IDENTITY_INSERT [dbo].[RSonuc] OFF
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (0, N'Şikayet')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (1, N'Hikaye')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (2, N'Aile Öyküsü')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (3, N'Geçirdiği Hastalık')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (4, N'Ameliyat')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (5, N'Fizik Muayene Uygulamaları')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (6, N'Kullandığı İlaçlar')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (7, N'Bilinen Alerjiler')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (8, N'Laboratuvar Sonuçları')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (9, N'Tanı')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (10, N'Tedavi')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (11, N'Öneriler')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (12, N'Not')
INSERT [dbo].[RSTur] ([T_ID], [T_AD]) VALUES (13, N'Genel Bilgiler')
ALTER TABLE [dbo].[Hasta]  WITH CHECK ADD  CONSTRAINT [FK_Hasta_Cinsiyet_CID] FOREIGN KEY([H_CID])
REFERENCES [dbo].[Cinsiyet] ([C_ID])
GO
ALTER TABLE [dbo].[Hasta] CHECK CONSTRAINT [FK_Hasta_Cinsiyet_CID]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Cinsiyet_CID] FOREIGN KEY([P_CID])
REFERENCES [dbo].[Cinsiyet] ([C_ID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Cinsiyet_CID]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Pozisyon_PozisyonID] FOREIGN KEY([P_POZISYONID])
REFERENCES [dbo].[Pozisyon] ([P_ID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Pozisyon_PozisyonID]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Hasta_HastaID] FOREIGN KEY([R_HASTAID])
REFERENCES [dbo].[Hasta] ([H_ID])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Hasta_HastaID]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Hizmet_HizmetID] FOREIGN KEY([R_HIZMETID])
REFERENCES [dbo].[Hizmet] ([H_ID])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Hizmet_HizmetID]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Personel_PersonelID] FOREIGN KEY([R_PERSONELID])
REFERENCES [dbo].[Personel] ([P_ID])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Personel_PersonelID]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_RDurum_DurumID] FOREIGN KEY([R_DURUMID])
REFERENCES [dbo].[RDurum] ([D_ID])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_RDurum_DurumID]
GO
ALTER TABLE [dbo].[RSonuc]  WITH CHECK ADD  CONSTRAINT [FK_RSonuc_Randevu_RandevuID] FOREIGN KEY([S_RANDEVUID])
REFERENCES [dbo].[Randevu] ([R_ID])
GO
ALTER TABLE [dbo].[RSonuc] CHECK CONSTRAINT [FK_RSonuc_Randevu_RandevuID]
GO
ALTER TABLE [dbo].[RSonuc]  WITH CHECK ADD  CONSTRAINT [FK_RSonuc_RSTur_TurID] FOREIGN KEY([S_TURID])
REFERENCES [dbo].[RSTur] ([T_ID])
GO
ALTER TABLE [dbo].[RSonuc] CHECK CONSTRAINT [FK_RSonuc_RSTur_TurID]
GO
USE [master]
GO
ALTER DATABASE [KlinikDB] SET  READ_WRITE 
GO
