using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stm_controller
{
    class ResponsePacket
    {
        //**************************************************************************
        //*                              DEFINES
        //**************************************************************************
        public const int RESPONSE_ERROR_NOT_A_PACKET = 100;
        public const int MAX_FAULTS = 21;

        public const byte DIAG_INVALID_CMD = (byte)0xFF; // Cmd 

        //**************************************************************************
        //*                              STRUCTURES
        //**************************************************************************
        public class packetData
        {
            public int resp_type = DIAG_INVALID_CMD;
            public byte address = 0;
            public PacketFlags flags = new PacketFlags();
            public responseDataType response = new responseDataType();
            public diagDatatype diag = new diagDatatype();
            public FaultDecodedData faultHistory = new FaultDecodedData();
            public LifetimeCounterData lifetimeCounters = new LifetimeCounterData();

            // constructor
            public packetData()
            {

            }
            // destructor
            ~packetData()
            {
            }

        }

        public class LifetimeCounterData
        {
            public UInt32 redWhite1OnTime = 0;
            public UInt32 greenWhite2OnTime = 0;
            public UInt32 blueAmberOnTime = 0;
            public UInt32 whiteOnTime = 0;
            public UInt32 powerCycleCount = 0;

            public LifetimeCounterData()
            {
            }
            ~LifetimeCounterData()
            {
            }
        }

        public class FaultDecodedData
        {
            public int version = 0;
            //public BitArray faultFlags    = new BitArray(MAX_FAULTS);
            public bool[] faultFlags = new bool[MAX_FAULTS];
            public int[] currentCycleCount = new int[MAX_FAULTS];
            public int[] previousCycleCount = new int[MAX_FAULTS];
            public int[] lifetimeCount = new int[MAX_FAULTS];
            public int redOnTime = 0;
            public int greenOnTime = 0;
            public int blueOnTime = 0;
            public int whiteOnTime = 0;
            public int OnTime = 0;
            public int powerCycleCount = 0;

            public FaultDecodedData()
            {
            }
            ~FaultDecodedData()
            {
            }
        }

        public class diagDatatype
        {
            public int resp_type = 0;
            public char error = '?';
            public UInt16 version = 0;
            public string revision = "";
            public UInt32 redTime = 0;
            public UInt32 grnTime = 0;
            public UInt32 bluTime = 0;
            public UInt32 whtTime = 0;
            public UInt32 totTime = 0;
            public UInt16 voltage = 0;
            public Int16 temperature = 0;
            public Int16 temperatureSF = 0;
            public Int16 temperatureTest = 0x00;
            public UInt32 code = 0;
            public UInt16 protocol = 0;
            public UInt16 testFlag = 0;
            public bool tokenActive = false;
            public string dataString = "";

            // constructor
            public diagDatatype()
            {
            }
            // destructor
            ~diagDatatype()
            {
            }

        }

        public class responseDataType
        {
            public byte address;
            public byte light_type = 0;
            public byte subtype = 0;
            public byte zone = 0;
            //public byte lampAddr = 0;
            public string part_number = "";
            public string firmware_rev = "";
            public string serial_number = "";

            // constructor
            public responseDataType()
            {
            }
            // destructor
            ~responseDataType()
            {
            }

        }

        public class PacketFlags
        {
            // constructor
            public PacketFlags(bool rspParam = false, bool crcParam = true)
            {
                rsp = rspParam;
                crc = crcParam;
                ack = false;
            }
            // destructor
            ~PacketFlags()
            {
            }
            // Properties. 
            public bool ack { get; set; }
            public bool crc { get; set; }
            public bool rsp { get; set; }
            // methods
            public byte getValue()
            {
                byte retval = 0x00;
                if (ack) retval |= 0x80;
                if (rsp) retval |= 0x08;
                if (crc) retval |= 0x04;

                return retval;
            }
            public string getValueText()
            {
                string retval = "";
                retval += (ack)?"A":"a";
                retval += (rsp)?"R":"r";
                retval += (crc)?"C":"c";
 
                return retval;
            }
            public string getValueTextAbrv()
            {
                string retval = "";
                retval += (ack) ? "ACK, " : "ack, ";
                retval += (rsp) ? "RSP, " : "rsp, ";
                retval += (crc) ? "CRC" : "crc";

                return retval;
            }

            public void setValue(byte value)
            {
                (ack) = (value & 0x80) != 0x00;
                (rsp) = (value & 0x08) != 0x00;
                (crc) = (value & 0x04) != 0x00;
            }
        }


        public int decodeResponse(ref string buffer, ref packetData decodeData)
        {
            int errorCode = RESPONSE_ERROR_NOT_A_PACKET;

            return errorCode;
        }

        public string decodeResponse(string buffer)
        {
            string response = "";

            if (buffer.Substring(0, 4) != "ZOOM")
            {
                response = "Zoom not found";
            }
            else
            {
                response = "Zoom found";
            }


            return response;
        }
    }
}
