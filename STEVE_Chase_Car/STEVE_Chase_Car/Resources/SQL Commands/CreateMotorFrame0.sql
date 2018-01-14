USE [STEVE_database]


/****** Object:  Table [dbo].[MotorFrame0]    Script Date: 09/09/2017 14:37:23 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[MotorFrame0](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[batteryVoltage] [int] NULL,
	[batteryCurrent] [int] NULL,
	[batteryCurrentDirection] [tinyint] NULL,
	[motorCurrentPeakAvrage] [int] NULL,
	[fetTemp] [tinyint] NULL,
	[motorRotationSpeed] [int] NULL,
	[PWMduty] [int] NULL,
	[leadAngle] [tinyint] NULL,
 CONSTRAINT [PK_MotorFrame0] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


