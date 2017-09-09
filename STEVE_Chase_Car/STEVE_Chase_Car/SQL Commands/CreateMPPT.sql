USE [STEVE_database]


/****** Object:  Table [dbo].[MPPT]    Script Date: 09/09/2017 14:38:07 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[MPPT](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[flags] [tinyint] NULL,
	[uinLSB] [tinyint] NULL,
	[linMSBtbd] [tinyint] NULL,
	[linLSB] [tinyint] NULL,
	[uoutMSBtbd] [tinyint] NULL,
	[uoutLSB] [tinyint] NULL,
	[tamb] [tinyint] NULL,
 CONSTRAINT [PK_MPPT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

