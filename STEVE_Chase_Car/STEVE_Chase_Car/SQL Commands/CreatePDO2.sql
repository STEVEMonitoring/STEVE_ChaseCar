USE [STEVE_database]


/****** Object:  Table [dbo].[BMS_PDO2]    Script Date: 09/09/2017 14:37:04 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[BMS_PDO2](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[SOC] [int] NULL,
	[minTemp] [int] NULL,
	[maxTemp] [int] NULL,
	[minTempID] [tinyint] NULL,
	[maxTempID] [tinyint] NULL,
 CONSTRAINT [PK_BMA_PDO2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


