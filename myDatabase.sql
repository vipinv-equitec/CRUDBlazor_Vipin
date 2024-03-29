USE [master]
GO
/****** Object:  Database [Student]    Script Date: 08-01-2024 19:43:43 ******/
CREATE DATABASE [Student]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Student.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Student_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Student] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student] SET RECOVERY FULL 
GO
ALTER DATABASE [Student] SET  MULTI_USER 
GO
ALTER DATABASE [Student] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Student] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Student', N'ON'
GO
ALTER DATABASE [Student] SET QUERY_STORE = ON
GO
ALTER DATABASE [Student] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Student]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudName] [varchar](50) NULL,
	[StudAge] [int] NULL,
	[StudEmail] [varchar](50) NULL,
	[StudDepartment] [varchar](50) NULL,
	[Skills] [varchar](50) NULL,
	[IsActive] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (16, N'vipin', 22, N'vipin@123', N'IT', N'Asp.Net', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (17, N'sam', 34, N'sam@7654', N'it', N'Autocad', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (22, N'cvfghjn', 40, N'yhjuk@456', N'IT', N'C#', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (19, N'say', 43, N'say@4567', N'cs', N'html', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (26, N'hey', 54, N'42', N'Mech', N'designer', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (27, N'hey', 54, N'42', N'Mech', N'java', 0)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (28, N'hey', 42, N'this@321', N'CS', N'reactjs', 0)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (23, N'nayak', 54, N'nayak@456', N'it', N'SQL', 0)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (24, N'jay', 45, N'jay@654', N'CS', N'reactjs', 0)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (25, N'vikram', 54, N'vikram@458', N'civil', N'Autocad', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (29, N'raghav', 29, N'raghav@769', N'civil', N'autocad', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (30, N'vijay', 20, N'vijay@769', N'civil', N'autocad', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (31, N'john', 40, N'john@563', N'Electrical', N'cs', 1)
INSERT [dbo].[Student] ([StudentId], [StudName], [StudAge], [StudEmail], [StudDepartment], [Skills], [IsActive]) VALUES (32, N'rahul', 26, N'rahul@123', N'CS', N'C#, Java, SQL', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  StoredProcedure [dbo].[BackStudent]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BackStudent]
@StudentId int
as
begin
set nocount on;
	update Student
	set IsActive = 1
	where StudentId = @StudentId;
end;
GO
/****** Object:  StoredProcedure [dbo].[DeleteSoft]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteSoft]
@StudentId int
as
begin
set nocount on;
	update Student
	set IsActive = 0
	where StudentId = @StudentId;
end;
GO
/****** Object:  StoredProcedure [dbo].[RestoreStudent]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RestoreStudent]
as
begin
 select * from Student
 where IsActive = 0;
end;
GO
/****** Object:  StoredProcedure [dbo].[StudentDeleteById]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[StudentDeleteById]
@StudentId int
as
	select * from Student
	where StudentId = @StudentId
GO
/****** Object:  StoredProcedure [dbo].[StudentDeleteByyId]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[StudentDeleteByyId]
@StudentId int
as
	delete from Student
	where StudentId = @StudentId
GO
/****** Object:  StoredProcedure [dbo].[StudentEdit]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[StudentEdit]
@StudentId int,
@StudName varchar(50),
@StudAge int,
@StudEmail varchar(50),
@StudDepartment varchar(50),
@Skills nvarchar(max)
AS
	IF @StudentId = 0
		insert into Student(StudName,StudAge,StudEmail,StudDepartment,Skills)
		values(@StudName,@StudAge,@StudEmail,@StudDepartment,@Skills)
	ELSE
		update Student
		set 
		StudName = @StudName,
		StudAge = @StudAge,
		StudEmail = @StudEmail,
		StudDepartment = @StudDepartment,
		Skills = @Skills
		where StudentId = @StudentId
GO
/****** Object:  StoredProcedure [dbo].[StudentViewAll]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[StudentViewAll]
as
	select * from Student
	where IsActive = 1;
GO
/****** Object:  StoredProcedure [dbo].[StudentViewById]    Script Date: 08-01-2024 19:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[StudentViewById]
@StudentId int
as
	select * from Student
	where StudentId = @StudentId
GO
USE [master]
GO
ALTER DATABASE [Student] SET  READ_WRITE 
GO
