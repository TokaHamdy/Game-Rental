USE [master]
GO

/****** Object:  Database [GameRental]    Script Date: 30/05/2022 22:06:33 ******/
CREATE DATABASE [GameRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GameRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GameRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GameRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [GameRental] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [GameRental] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [GameRental] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [GameRental] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [GameRental] SET ARITHABORT OFF 
GO

ALTER DATABASE [GameRental] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [GameRental] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [GameRental] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [GameRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [GameRental] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [GameRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [GameRental] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [GameRental] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [GameRental] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [GameRental] SET  ENABLE_BROKER 
GO

ALTER DATABASE [GameRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [GameRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [GameRental] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [GameRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [GameRental] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [GameRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [GameRental] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [GameRental] SET RECOVERY FULL 
GO

ALTER DATABASE [GameRental] SET  MULTI_USER 
GO

ALTER DATABASE [GameRental] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [GameRental] SET DB_CHAINING OFF 
GO

ALTER DATABASE [GameRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [GameRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [GameRental] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [GameRental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [GameRental] SET QUERY_STORE = OFF
GO

ALTER DATABASE [GameRental] SET  READ_WRITE 
GO




USE [GameRental]
GO

/****** Object:  Table [dbo].[Admin]    Script Date: 30/05/2022 22:08:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admin](
	[Fname] [varchar](30) NOT NULL,
	[Lname] [varchar](30) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[bdate] [date] NULL,
	[Admin_ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





USE [GameRental]
GO

/****** Object:  Table [dbo].[Client]    Script Date: 30/05/2022 22:11:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Client](
	[Fname] [varchar](30) NOT NULL,
	[Lname] [varchar](30) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[bdate] [date] NULL,
	[client_ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





USE [GameRental]
GO

/****** Object:  Table [dbo].[game]    Script Date: 30/05/2022 22:14:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[game](
	[game_ID] [int] IDENTITY(1,1) NOT NULL,
	[game_name] [varchar](30) NOT NULL,
	[category] [varchar](30) NOT NULL,
	[game_year] [int] NOT NULL,
	[game_month] [int] NOT NULL,
	[Admin_ID] [int] NOT NULL,
	[vendor_ID] [int] NOT NULL,
	[client_ID] [int] NULL,
	[Rent_value] [bit] NULL,
	[count_g] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[game_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[game_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[game] ADD  DEFAULT ((0)) FOR [Rent_value]
GO

ALTER TABLE [dbo].[game] ADD  DEFAULT ((0)) FOR [count_g]
GO

ALTER TABLE [dbo].[game]  WITH CHECK ADD FOREIGN KEY([Admin_ID])
REFERENCES [dbo].[Admin] ([Admin_ID])
GO

ALTER TABLE [dbo].[game]  WITH CHECK ADD FOREIGN KEY([client_ID])
REFERENCES [dbo].[Client] ([client_ID])
GO

ALTER TABLE [dbo].[game]  WITH CHECK ADD FOREIGN KEY([vendor_ID])
REFERENCES [dbo].[vendor] ([vendor_ID])
GO













USE [GameRental]
GO

/****** Object:  Table [dbo].[RentDate]    Script Date: 30/05/2022 22:14:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RentDate](
	[Client_ID] [int] NOT NULL,
	[Vendor_ID] [int] NOT NULL,
	[c_time] [date] NULL,
	[Game_name] [varchar](30) NULL
) ON [PRIMARY]
GO













USE [GameRental]
GO

/****** Object:  Table [dbo].[vendor]    Script Date: 30/05/2022 22:15:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[vendor](
	[Fname] [varchar](30) NOT NULL,
	[Lname] [varchar](30) NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[vendor_ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vendor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


