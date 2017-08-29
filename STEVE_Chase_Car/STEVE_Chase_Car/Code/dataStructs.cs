/*
 * Copy and paste the following consts in the file where you need the id:s
 * When creating the structs do as follows
 *
 * struct CANidSend SendIds = CANidSend_defaults;
 * struct CANidReceive ReceiveIds = CANidReceive_defaults;
 *
 * this will init the structs to their correct id values for you
 *
const struct CANidReceive CANidReceive_defaults =  {0x779, 0x200, 0x300, 0x400, 0x08850245, 0x08950245, 0x08A50245};
const struct CANidSend CANidSend_defaults = {0x719, 0x180, 0x08F91540};
*/


struct CANidSend
{
    ushort MPPT;
    ushort BMS;
    ulong motorControler;
};



struct CANidReceive
{
    ushort MPPT;
    ushort BMSPDO1;
    ushort BMSPDO2;
    ushort BMSPDO3;
    ulong motorFrame0;
    ulong motorFrame1;
    ulong motorFrame2;
};


struct PDO1
{
    byte minVolt; //0,01V/bit
    byte minVoltID;
    byte maxVolt; //0,01V/bit
    byte maxVoltID;
    ushort volt; //0,01V/bit
    short current; // 0,1A/bit
};

struct PDO2
{
    ushort SOC; //0,1%/bit
    ushort minTemp; //0,1%/bit
    ushort maxTemp; //0,1%/bit
    byte minTempID;
    byte maxTempID;
};

struct PDO3
{
    // todo?
};

struct MPPT
{
    byte flags;
    byte uinLSB;
    byte linMSBtbd; //LinMSB & TBD
    byte linLSB;
    byte uoutMSBtbd; //UoutMSB & TBD
    byte uoutLSB;
    byte tamb;
};


/* TODO fix this code to collect all motor frames in one struct if possible */
//struct Motor
//{
//    struct MotorFrame0 frame0;
//	struct MotorFrame0 frame1;
//	struct MotorFrame0 frame2;
//};

struct MotorFrame0
{
    ushort batteryVoltage; //0,5V/LSB
    ushort batteryCurrent; //1A/LSB
    byte batteryCurrentDirection;
    ushort motorCurrentPeakAvrage; //1/LSB
    byte fetTemp; //5°C/LSB
    ushort motorRotationgSpeed; //1rpm/LSB
    ushort PWMduty; //0,5%/LSB
    byte leadAngle; //0,5°/LSB
};

struct MotorFrame1
{
    byte status; // Power mode, motor control mode, drive action status, regneration status.
    ushort acceleratorPos; //0,5%/LSB
    ushort regnerationVrPos; //0,5%/LSB
    byte digitSwPos;
    ushort outputTargetVal; //0,5%/LSB
};

struct MotorFrame2
{
    /**
	 * @Analog Sensor Error 				bit 0
	 * Motor Current Sensor U Error			bit 1
	 * Motor Current Sensor W Error			bit 2
	 * FET Thermistor Error					bit 3
	 * TBD									bit 4
	 * Battery Voltage Sensor Error			bit 5
	 * Battery Current Sensor Error			bit 6
	 * Battery Current Sensor Adjust Error	bit 7
	 * Motor Current Sensor Adjust Error	bit 8
	 * Accelerator Position Error			bit 9
	 * TBD									bit 10
	 * Controller Voltage Sensor Error		bit 11
	 * TBD									bit 12-15
	 * Power System Error					bit 16
	 * Over Current Error					bit 17
	 * TBD									bit 18
	 * Over Voltage Error					bit 19
	 * TBD									bit 20
	 * Over Current Limit					bit 21
	 * TBD									bit 22-23
	 * Motor System Error					bit 24
	 * Motor Lock							bit 25
	 * Hall Sensor ushort					bit 26
	 * Hall Sensor Open						bit 27
	 * TBD									bit 28-31
	 * Over Heat Level						bit 32-33
	 */
    ulong flags;
};
