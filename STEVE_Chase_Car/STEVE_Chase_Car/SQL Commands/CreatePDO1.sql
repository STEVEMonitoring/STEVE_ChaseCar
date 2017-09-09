USE [STEVE_database]


/****** Object:  Table [dbo].[BMS_PDO1]    Script Date: 09/09/2017 13:54:48 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[BMS_PDO1](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[minVolt] [tinyint] NULL,
	[minVoltID] [tinyint] NULL,
	[maxVolt] [tinyint] NULL,
	[maxVoltID] [tinyint] NULL,
	[volt] [int] NULL,
	[current] [int] NULL,
 CONSTRAINT [PK_BMA_PDO1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


