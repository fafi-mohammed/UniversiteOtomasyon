USE [universiteOtomasyon]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 17/06/2025 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[DersID] [int] NOT NULL,
	[DersAdi] [nvarchar](100) NOT NULL,
	[Kredi] [int] NOT NULL,
	[OgretimUyesiID] [int] NOT NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotGiris]    Script Date: 17/06/2025 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotGiris](
	[NotGirisID] [int] NOT NULL,
	[Vize] [float] NOT NULL,
	[Final] [float] NOT NULL,
	[Ortalama] [float] NOT NULL,
	[OgrenciID] [int] NOT NULL,
	[OgretimUyesiID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NotGirisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 17/06/2025 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](100) NOT NULL,
	[Bolum] [nvarchar](100) NULL,
	[Sinif] [int] NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgretimUyesi]    Script Date: 17/06/2025 00:23:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgretimUyesi](
	[OgretimUyesiID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](100) NOT NULL,
	[Unvan] [nvarchar](50) NULL,
 CONSTRAINT [PK_OgretimUyesi] PRIMARY KEY CLUSTERED 
(
	[OgretimUyesiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (1, N'Bilgisayar Aglari', 4, 1)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (2, N'Muhasebe', 5, 3)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (3, N'Dinamik ', 5, 2)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (4, N'Dahiliye', 5, 5)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (5, N'Biokimya', 4, 7)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (6, N'Teknik Cizim', 5, 6)
INSERT [dbo].[Ders] ([DersID], [DersAdi], [Kredi], [OgretimUyesiID]) VALUES (7, N'Programlama 1', 5, 1)
GO
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (1, 80, 80, 80, 6, 3)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (2, 70, 80, 76, 1, 1)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (3, 68, 75, 72.2, 2, 1)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (4, 60, 85, 75, 3, 2)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (5, 90, 85, 87, 5, 2)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (6, 65, 80, 74, 4, 4)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (7, 70, 65, 67, 7, 5)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (8, 85, 90, 88, 8, 5)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (9, 100, 100, 100, 9, 6)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (10, 60, 60, 60, 10, 7)
INSERT [dbo].[NotGiris] ([NotGirisID], [Vize], [Final], [Ortalama], [OgrenciID], [OgretimUyesiID]) VALUES (11, 60, 70, 66, 11, 4)
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (1, N'Ali Demir', N'Bilgisayar Muhendisligi', 2)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (2, N'Berk Yilmaz', N'insaat Muhendisligi', 1)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (3, N'Burak Ozdemir', N'insaat Muhendisligi', 3)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (4, N'Fatma Ates', N'Mimarlik', 4)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (5, N'Gokce Can', N'Mimarlik', 3)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (6, N'Esmanur Oncu', N'Hemsirelik', 3)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (7, N'Esra Aksoy', N'Bilgisayar Muhendisligi', 4)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (8, N'Sedanur Ozbek', N'Biomedikal Muhendisligi', 2)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (9, N'Zehra Kocabas', N'Bankacilik', 1)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (10, N'Mustafa Furkan', N'Mekine Muhendisligi', 2)
INSERT [dbo].[Ogrenci] ([OgrenciID], [AdSoyad], [Bolum], [Sinif]) VALUES (11, N'Zeynep Ozkan', N'Uluslararasi Ticaret', 4)
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[OgretimUyesi] ON 

INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (1, N'Osman Ozdemir', N'Doc')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (2, N'Semih Ektas', N'Prof')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (3, N'Seda Mericelli', N'Prof')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (4, N'Mehmet Demir', N'Prof')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (5, N'Ece Kaplan', N'Prof')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (6, N'Saban Cebecioglu', N'Doc')
INSERT [dbo].[OgretimUyesi] ([OgretimUyesiID], [AdSoyad], [Unvan]) VALUES (7, N'Ahmet Yilmaz', N'Doc')
SET IDENTITY_INSERT [dbo].[OgretimUyesi] OFF
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_OgretimUyesi] FOREIGN KEY([OgretimUyesiID])
REFERENCES [dbo].[OgretimUyesi] ([OgretimUyesiID])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_OgretimUyesi]
GO
ALTER TABLE [dbo].[NotGiris]  WITH CHECK ADD FOREIGN KEY([OgretimUyesiID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[NotGiris]  WITH CHECK ADD FOREIGN KEY([OgretimUyesiID])
REFERENCES [dbo].[OgretimUyesi] ([OgretimUyesiID])
GO
