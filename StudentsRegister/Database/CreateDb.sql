
USE [master]
GO

/****** Object:  Database [RegisteredStudents]    Script Date: 8.4.2016 ã. 16:24:43 ******/
CREATE DATABASE [RegisteredStudents]

USE [RegisteredStudents]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 8.4.2016 ã. 16:24:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Course] [int] NOT NULL,
	[Speciality] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


