/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [QuizMaker]    Script Date: 05/02/2019 02:02:03 ******/
CREATE DATABASE [QuizMaker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuizMaker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuizMaker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuizMaker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuizMaker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuizMaker] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuizMaker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuizMaker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuizMaker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuizMaker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuizMaker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuizMaker] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuizMaker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuizMaker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuizMaker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuizMaker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuizMaker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuizMaker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuizMaker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuizMaker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuizMaker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuizMaker] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuizMaker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuizMaker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuizMaker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuizMaker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuizMaker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuizMaker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuizMaker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuizMaker] SET RECOVERY FULL 
GO
ALTER DATABASE [QuizMaker] SET  MULTI_USER 
GO
ALTER DATABASE [QuizMaker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuizMaker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuizMaker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuizMaker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuizMaker] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuizMaker', N'ON'
GO
ALTER DATABASE [QuizMaker] SET QUERY_STORE = OFF
GO
USE [QuizMaker]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuizMaker]
GO
/****** Object:  Table [dbo].[QuestionQuiz]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionQuiz](
	[QuestionQuizId] [int] IDENTITY(1,1) NOT NULL,
	[QuizId] [int] NOT NULL,
	[QuestionId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionQuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionTitle] [nvarchar](max) NOT NULL,
	[AnswerA] [nvarchar](max) NOT NULL,
	[AnswerB] [nvarchar](max) NOT NULL,
	[AnswerC] [nvarchar](max) NOT NULL,
	[AnswerD] [nvarchar](max) NOT NULL,
	[RightAnswer] [nvarchar](max) NOT NULL,
	[QuestionTypeId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionType]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](max) NOT NULL,
	[TypePoint] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quiz]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz](
	[QuizId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[QuizName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogs]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogs](
	[LogId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BeginDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserFullName] [nvarchar](max) NOT NULL,
	[UserEmail] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](50) NOT NULL,
	[UserTypeId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersQuiz]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersQuiz](
	[UserQuizId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[QuizId] [int] NOT NULL,
	[QuizPoint] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserQuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 05/02/2019 02:02:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[StatusType] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 05/02/2019 02:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[UserTypeId] [int] IDENTITY(1,1) NOT NULL,
	[UserTypeName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QuestionQuiz]  WITH CHECK ADD  CONSTRAINT [const06] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([QuestionId])
GO
ALTER TABLE [dbo].[QuestionQuiz] CHECK CONSTRAINT [const06]
GO
ALTER TABLE [dbo].[QuestionQuiz]  WITH CHECK ADD  CONSTRAINT [const07] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quiz] ([QuizId])
GO
ALTER TABLE [dbo].[QuestionQuiz] CHECK CONSTRAINT [const07]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [const05] FOREIGN KEY([QuestionTypeId])
REFERENCES [dbo].[QuestionType] ([TypeId])
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [const05]
GO
ALTER TABLE [dbo].[Quiz]  WITH CHECK ADD  CONSTRAINT [const09] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Quiz] CHECK CONSTRAINT [const09]
GO
ALTER TABLE [dbo].[UserLogs]  WITH CHECK ADD  CONSTRAINT [const03] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserLogs] CHECK CONSTRAINT [const03]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [const01] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserType] ([UserTypeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [const01]
GO
ALTER TABLE [dbo].[UsersQuiz]  WITH CHECK ADD  CONSTRAINT [const04] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UsersQuiz] CHECK CONSTRAINT [const04]
GO
ALTER TABLE [dbo].[UsersQuiz]  WITH CHECK ADD  CONSTRAINT [const08] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quiz] ([QuizId])
GO
ALTER TABLE [dbo].[UsersQuiz] CHECK CONSTRAINT [const08]
GO
ALTER TABLE [dbo].[UserStatus]  WITH CHECK ADD  CONSTRAINT [const02] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserStatus] CHECK CONSTRAINT [const02]
GO
USE [master]
GO
ALTER DATABASE [QuizMaker] SET  READ_WRITE 
GO
