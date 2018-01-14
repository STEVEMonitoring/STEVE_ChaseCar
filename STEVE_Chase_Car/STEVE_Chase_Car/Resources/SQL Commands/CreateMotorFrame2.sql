USE [STEVE_database]


/****** Object:  Table [dbo].[MotorFrame2]    Script Date: 09/09/2017 14:37:47 ******/
SET ANSI_NULLS ON


SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[MotorFrame2](
	[ID] [int] NOT NULL,
	[Time] [datetime] NULL,
	[AnalogSensorError] [bit] NULL,
	[MotorCurrentSensorUError] [bit] NULL,
	[MotorCurrentSensorWError] [bit] NULL,
	[FETTermistorError] [bit] NULL,
	[BatteryVoltageSensorError] [bit] NULL,
	[BatteryCurrentSensorError] [bit] NULL,
	[BatteryCurrentSensorAdjustError] [bit] NULL,
	[MotorCurrentSensorAdjustError] [bit] NULL,
	[AcceleratorPositionError] [bit] NULL,
	[ControllerVoltageSensorError] [bit] NULL,
	[PowerSystemError] [bit] NULL,
	[OverCurrentError] [bit] NULL,
	[OverVoltageError] [bit] NULL,
	[OverCurrentLimit] [bit] NULL,
	[MotorSystemError] [bit] NULL,
	[MotorLock] [bit] NULL,
	[HallSensorUshort] [bit] NULL,
	[HallSensorOpen] [bit] NULL,
	[OverHeatLevel] [tinyint] NULL,
 CONSTRAINT [PK_MotorFrame2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


