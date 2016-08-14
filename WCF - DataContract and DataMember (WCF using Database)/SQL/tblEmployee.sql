USE [Sample]
GO

/****** Object:  Table [dbo].[tblEmployee]    Script Date: 8/13/2016 11:16:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEmployee](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL
) ON [PRIMARY]

GO


