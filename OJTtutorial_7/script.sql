USE [staffTest]
GO
/****** Object:  Table [dbo].[staffInfo]    Script Date: 3/18/2024 11:05:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffInfo](
	[ID] [int] NOT NULL,
	[staffNo] [varchar](20) NOT NULL,
	[staffName] [nvarchar](50) NOT NULL,
	[staffDob] [datetime] NOT NULL,
	[staffJoin] [datetime] NOT NULL,
	[staffType] [smallint] NOT NULL,
	[staffNRC] [varchar](20) NOT NULL,
	[staffGender] [smallint] NOT NULL,
	[staffPhone1] [varchar](20) NOT NULL,
	[staffPhone2] [varchar](20) NULL,
	[staffAddress] [varchar](200) NULL,
	[photo] [varchar](500) NULL,
	[is_deleted] [smallint] NOT NULL,
	[password] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
