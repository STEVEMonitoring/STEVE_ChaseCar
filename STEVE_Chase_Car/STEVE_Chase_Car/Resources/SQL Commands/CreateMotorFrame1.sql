USE [STEVE_database]


/****** Object:  Table [dbo].[MotorFrame1]    Script Date: 09/09/2017 14:37:33 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[MotorFrame1](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[status] [tinyint] NULL,
	[accelerationPos] [int] NULL,
	[regnerationVrPos] [int] NULL,
	[digitSwPos] [tinyint] NULL,
	[outputTargetVal] [int] NULL,
 CONSTRAINT [PK_MotorFrame1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


