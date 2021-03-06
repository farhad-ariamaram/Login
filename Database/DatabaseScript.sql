USE [master]
GO
/****** Object:  Database [TestDB]    Script Date: 4/25/2021 8:34:10 AM ******/
CREATE DATABASE [TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TestDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\TestDB_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TestDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TestDB] SET  MULTI_USER 
GO
ALTER DATABASE [TestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TestDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestDB', N'ON'
GO
USE [TestDB]
GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Alert]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Alert](
	[Fld_Sitestyle_Alert_Id] [int] NOT NULL,
	[Fld_Sitestyle_Alert_Title] [nvarchar](max) NULL,
	[Fld_Sitestyle_Alert_Code] [nvarchar](max) NULL,
	[Fld_Sitestyle_Alert_AlerttypeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Alert] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Alert_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_AlertLanguage]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_AlertLanguage](
	[Fld_Sitestyle_AlertLanguage_Id] [int] NOT NULL,
	[Fld_Sitestyle_AlertLanguage_Text] [nvarchar](max) NULL,
	[Fld_Sitestyle_AlertLanguage_Title] [nvarchar](max) NULL,
	[Fld_Sitestyle_AlertLanguage_AlertId] [int] NOT NULL,
	[Fld_Sitestyle_AlertLanguage_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_AlertLanguage] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_AlertLanguage_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Alerttype]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Alerttype](
	[Fld_Sitestyle_Alerttype_Id] [int] NOT NULL,
	[Fld_Sitestyle_Alerttype_Name] [nvarchar](max) NULL,
	[Fld_Sitestyle_Alerttype_Icon] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Alerttype] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Alerttype_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Css]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Css](
	[Fld_Sitestyle_Css_Id] [int] NOT NULL,
	[Fld_Sitestyle_Css_Name] [nvarchar](max) NULL,
	[Fld_Sitestyle_Css_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Css] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Css_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Font]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Font](
	[Fld_Sitestyle_Font_Id] [int] NOT NULL,
	[Fld_Sitestyle_Font_Name] [nvarchar](max) NULL,
	[Fld_Sitestyle_Font_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Font] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Font_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Iso639_1]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Iso639_1](
	[Fld_Sitestyle_Iso639_1_Id] [int] NOT NULL,
	[Fld_Sitestyle_Iso639_1_Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Iso639_1] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Iso639_1_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Iso639_2]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Iso639_2](
	[Fld_Sitestyle_Iso639_2_Id] [int] NOT NULL,
	[Fld_Sitestyle_Iso639_2_Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Iso639_2] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Iso639_2_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Iso639_3]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Iso639_3](
	[Fld_Sitestyle_Iso639_3_Id] [int] NOT NULL,
	[Fld_Sitestyle_Iso639_3_Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Iso639_3] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Iso639_3_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Language]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Language](
	[Fld_Sitestyle_Language_Id] [int] NOT NULL,
	[Fld_Sitestyle_Language_Text] [nvarchar](max) NULL,
	[Fld_Sitestyle_Language_Direction] [nvarchar](max) NULL,
	[Fld_Sitestyle_Language_Iso639_1_Id] [int] NOT NULL,
	[Fld_Sitestyle_Language_Iso639_2_Id] [int] NOT NULL,
	[Fld_Sitestyle_Language_Iso639_3_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Language] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Language_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Menu]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Menu](
	[Fld_Sitestyle_Menu_Id] [int] NOT NULL,
	[Fld_Sitestyle_Menu_Text] [nvarchar](max) NULL,
	[Fld_Sitestyle_Menu_Hotkey] [nvarchar](max) NULL,
	[Fld_Sitestyle_Menu_FontIcon] [nvarchar](max) NULL,
	[Fld_Sitestyle_Menu_ImageIcon] [nvarchar](max) NULL,
	[Fld_Sitestyle_Menu_AccessId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Menu] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Menu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_MenuLanguage]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_MenuLanguage](
	[Fld_Sitestyle_MenuLanguage_Id] [int] NOT NULL,
	[Fld_Sitestyle_MenuLanguage_Title] [nvarchar](max) NULL,
	[Fld_Sitestyle_MenuLanguage_Tooltip] [nvarchar](max) NULL,
	[Fld_Sitestyle_MenuLanguage_MenuId] [int] NOT NULL,
	[Fld_Sitestyle_MenuLanguage_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_MenuLanguage] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_MenuLanguage_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Sitestyle_Metadata]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sitestyle_Metadata](
	[Fld_Sitestyle_Metadata_Id] [int] NOT NULL,
	[Fld_Sitestyle_Metadata_Text] [nvarchar](max) NULL,
	[Fld_Sitestyle_Metadata_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Sitestyle_Metadata] PRIMARY KEY CLUSTERED 
(
	[Fld_Sitestyle_Metadata_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Users_UsersActivityGroup]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Users_UsersActivityGroup](
	[Fld_Users_UsersActivityGroup_Id] [int] NOT NULL,
	[Fld_Users_UsersActivityGroup_Title] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Tbl_Users_UsersActivityGroup] PRIMARY KEY CLUSTERED 
(
	[Fld_Users_UsersActivityGroup_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Users_UsersActivityGroupLanguage]    Script Date: 4/25/2021 8:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Users_UsersActivityGroupLanguage](
	[Fld_Users_UsersActivityGroupLanguage_Id] [int] NOT NULL,
	[Fld_Users_UsersActivityGroupLanguage_Title] [nvarchar](max) NULL,
	[Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId] [int] NOT NULL,
	[Fld_Users_UsersActivityGroupLanguage_LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Users_UsersActivityGroupLanguage] PRIMARY KEY CLUSTERED 
(
	[Fld_Users_UsersActivityGroupLanguage_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Alert]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Alerttype_Tbl_Sitestyle_Alert] FOREIGN KEY([Fld_Sitestyle_Alert_AlerttypeId])
REFERENCES [dbo].[Tbl_Sitestyle_Alerttype] ([Fld_Sitestyle_Alerttype_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Alert] CHECK CONSTRAINT [Tbl_Sitestyle_Alerttype_Tbl_Sitestyle_Alert]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_AlertLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Alert_Tbl_Sitestyle_AlertLanguage] FOREIGN KEY([Fld_Sitestyle_AlertLanguage_AlertId])
REFERENCES [dbo].[Tbl_Sitestyle_Alert] ([Fld_Sitestyle_Alert_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_AlertLanguage] CHECK CONSTRAINT [Tbl_Sitestyle_Alert_Tbl_Sitestyle_AlertLanguage]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_AlertLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_AlertLanguage] FOREIGN KEY([Fld_Sitestyle_AlertLanguage_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_AlertLanguage] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_AlertLanguage]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Css]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Css] FOREIGN KEY([Fld_Sitestyle_Css_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Css] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Css]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Font]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Font] FOREIGN KEY([Fld_Sitestyle_Font_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Font] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Font]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Iso639_1_Tbl_Sitestyle_Language] FOREIGN KEY([Fld_Sitestyle_Language_Iso639_1_Id])
REFERENCES [dbo].[Tbl_Sitestyle_Iso639_1] ([Fld_Sitestyle_Iso639_1_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language] CHECK CONSTRAINT [Tbl_Sitestyle_Iso639_1_Tbl_Sitestyle_Language]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Iso639_2_Tbl_Sitestyle_Language] FOREIGN KEY([Fld_Sitestyle_Language_Iso639_2_Id])
REFERENCES [dbo].[Tbl_Sitestyle_Iso639_2] ([Fld_Sitestyle_Iso639_2_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language] CHECK CONSTRAINT [Tbl_Sitestyle_Iso639_2_Tbl_Sitestyle_Language]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Iso639_3_Tbl_Sitestyle_Language] FOREIGN KEY([Fld_Sitestyle_Language_Iso639_3_Id])
REFERENCES [dbo].[Tbl_Sitestyle_Iso639_3] ([Fld_Sitestyle_Iso639_3_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Language] CHECK CONSTRAINT [Tbl_Sitestyle_Iso639_3_Tbl_Sitestyle_Language]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_MenuLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_MenuLanguage] FOREIGN KEY([Fld_Sitestyle_MenuLanguage_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_MenuLanguage] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_MenuLanguage]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_MenuLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Menu_Tbl_Sitestyle_MenuLanguage] FOREIGN KEY([Fld_Sitestyle_MenuLanguage_MenuId])
REFERENCES [dbo].[Tbl_Sitestyle_Menu] ([Fld_Sitestyle_Menu_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_MenuLanguage] CHECK CONSTRAINT [Tbl_Sitestyle_Menu_Tbl_Sitestyle_MenuLanguage]
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Metadata]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Metadata] FOREIGN KEY([Fld_Sitestyle_Metadata_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Sitestyle_Metadata] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Sitestyle_Metadata]
GO
ALTER TABLE [dbo].[Tbl_Users_UsersActivityGroupLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Users_UsersActivityGroupLanguage] FOREIGN KEY([Fld_Users_UsersActivityGroupLanguage_LanguageId])
REFERENCES [dbo].[Tbl_Sitestyle_Language] ([Fld_Sitestyle_Language_Id])
GO
ALTER TABLE [dbo].[Tbl_Users_UsersActivityGroupLanguage] CHECK CONSTRAINT [Tbl_Sitestyle_Language_Tbl_Users_UsersActivityGroupLanguage]
GO
ALTER TABLE [dbo].[Tbl_Users_UsersActivityGroupLanguage]  WITH CHECK ADD  CONSTRAINT [Tbl_Users_UsersActivityGroup_Tbl_Users_UsersActivityGroupLanguage] FOREIGN KEY([Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId])
REFERENCES [dbo].[Tbl_Users_UsersActivityGroup] ([Fld_Users_UsersActivityGroup_Id])
GO
ALTER TABLE [dbo].[Tbl_Users_UsersActivityGroupLanguage] CHECK CONSTRAINT [Tbl_Users_UsersActivityGroup_Tbl_Users_UsersActivityGroupLanguage]
GO
USE [master]
GO
ALTER DATABASE [TestDB] SET  READ_WRITE 
GO
