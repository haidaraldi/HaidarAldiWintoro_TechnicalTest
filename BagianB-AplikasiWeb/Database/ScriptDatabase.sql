USE [master]
GO
/****** Object:  Database [TechnicalTest]    Script Date: 10/29/2021 10:57:36 AM ******/
CREATE DATABASE [TechnicalTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechnicalTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TechnicalTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechnicalTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TechnicalTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TechnicalTest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechnicalTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechnicalTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechnicalTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechnicalTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechnicalTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechnicalTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechnicalTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechnicalTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechnicalTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechnicalTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechnicalTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechnicalTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechnicalTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechnicalTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechnicalTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechnicalTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechnicalTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechnicalTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechnicalTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechnicalTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechnicalTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechnicalTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechnicalTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechnicalTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TechnicalTest] SET  MULTI_USER 
GO
ALTER DATABASE [TechnicalTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechnicalTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechnicalTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechnicalTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechnicalTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechnicalTest] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TechnicalTest] SET QUERY_STORE = OFF
GO
USE [TechnicalTest]
GO
/****** Object:  Table [dbo].[DataPelanggan]    Script Date: 10/29/2021 10:57:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataPelanggan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [varchar](100) NULL,
	[Alamat] [varchar](max) NOT NULL,
	[NoTelp] [varchar](15) NULL,
 CONSTRAINT [PK_DataPelanggan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataProduct]    Script Date: 10/29/2021 10:57:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [varchar](100) NULL,
	[Harga] [float] NULL,
	[Deskripsi] [varchar](max) NULL,
 CONSTRAINT [PK_DataProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataTransaksi]    Script Date: 10/29/2021 10:57:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataTransaksi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KodeTransaksi] [varchar](100) NOT NULL,
	[Tanggal] [date] NULL,
	[Pelanggan] [varchar](50) NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_DataTransaksi_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailProductPelanggan]    Script Date: 10/29/2021 10:57:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailProductPelanggan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pelanggan] [varchar](50) NULL,
	[IdProduk] [int] NULL,
	[Jumlah] [float] NULL,
 CONSTRAINT [PK_DetailProductPelanggan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DataPelanggan] ON 

INSERT [dbo].[DataPelanggan] ([Id], [Nama], [Alamat], [NoTelp]) VALUES (1, N'Haidar', N'PCI', N'0838938392')
INSERT [dbo].[DataPelanggan] ([Id], [Nama], [Alamat], [NoTelp]) VALUES (2, N'Aldi', N'PCI', N'93898')
SET IDENTITY_INSERT [dbo].[DataPelanggan] OFF
GO
SET IDENTITY_INSERT [dbo].[DataProduct] ON 

INSERT [dbo].[DataProduct] ([Id], [Nama], [Harga], [Deskripsi]) VALUES (2, N'HDD', 1000000, N'Barang baru')
SET IDENTITY_INSERT [dbo].[DataProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[DataTransaksi] ON 

INSERT [dbo].[DataTransaksi] ([Id], [KodeTransaksi], [Tanggal], [Pelanggan], [Total]) VALUES (1, N'TR001/2810/21', CAST(N'2021-10-28' AS Date), N'Haidar', 100000)
INSERT [dbo].[DataTransaksi] ([Id], [KodeTransaksi], [Tanggal], [Pelanggan], [Total]) VALUES (2, N'TR002/2910/21', CAST(N'2021-10-29' AS Date), N'Aldi', 100000)
INSERT [dbo].[DataTransaksi] ([Id], [KodeTransaksi], [Tanggal], [Pelanggan], [Total]) VALUES (3, N'TR003/3010/21', CAST(N'2021-10-30' AS Date), N'Wintoro', 100000)
INSERT [dbo].[DataTransaksi] ([Id], [KodeTransaksi], [Tanggal], [Pelanggan], [Total]) VALUES (4, N'TR004/2910/21', CAST(N'2021-10-29' AS Date), N'Aldi', 200000)
SET IDENTITY_INSERT [dbo].[DataTransaksi] OFF
GO
SET IDENTITY_INSERT [dbo].[DetailProductPelanggan] ON 

INSERT [dbo].[DetailProductPelanggan] ([Id], [Pelanggan], [IdProduk], [Jumlah]) VALUES (1, N'Haidar', 2, 1)
INSERT [dbo].[DetailProductPelanggan] ([Id], [Pelanggan], [IdProduk], [Jumlah]) VALUES (2, N'Aldi', 2, 2)
SET IDENTITY_INSERT [dbo].[DetailProductPelanggan] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDataTransaksi]    Script Date: 10/29/2021 10:57:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [dbo].[SP_InsertDataTransaksi] 	
	@Tanggal date,
	@Pelanggan varchar(50),
	@Total float,
	@IDProduk int,
	@Jumlah float
AS
BEGIN
DECLARE @day varchar(10)
DECLARE @month varchar(10)
DECLARE @year varchar(10)
DECLARE @number int
SET @number = 0

SELECT @number = max(Id) from DataTransaksi

IF(@number IS NULL)
BEGIN
SET @number = 0
END
	SET NOCOUNT ON;    	
	
	SELECT @day = DATEPART(day,@Tanggal), @month = DATEPART(month, @Tanggal) , @year = ( YEAR( @Tanggal ) % 100 )

		INSERT INTO DataTransaksi(KodeTransaksi, Tanggal, Pelanggan, Total)
		VALUES ('TR00' + CAST((@number+1) AS varchar) + '/' +  CAST((@day+@month) AS varchar) + '/' + CAST((@year) AS varchar), @Tanggal, @Pelanggan, @Total)

		INSERT INTO DetailProductPelanggan (Pelanggan, IdProduk, Jumlah) 
		VALUES (@Pelanggan, @IDProduk, @Jumlah)
END
GO
USE [master]
GO
ALTER DATABASE [TechnicalTest] SET  READ_WRITE 
GO
