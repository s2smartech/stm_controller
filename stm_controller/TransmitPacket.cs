using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stm_controller
{
    class TransmitPacket
    {
        //**************************************************************************
        //*                              DEFINES
        //**************************************************************************
        public const byte DEFAULT_SOT = 0x10; /* Start-of-Transmission */
        public const byte DEFAULT_EOT = 0x30; /* End-of-Transmission*/

        // Class Declaration
        txPktSettings txPktSet;

        public TransmitPacket()
        {
            txPktSet = new txPktSettings();
        }

            /*public string encodeCommand()
            {
                string data = string.Empty;
                return buildPacket();
            }*/

            public string encodeCommand(string tx_data)
        {
            string data = string.Empty;
            return buildPacket(tx_data);
        }

        string buildPacket(string tx_data)
        {
            string buffer = "";

            buffer += (char)(DEFAULT_SOT);
            buffer += tx_data;
            buffer += (char)(DEFAULT_EOT);

            /*buffer += (char)0x55;
            buffer += (char)0x00;
            buffer += (char)0x70;*/

            return buffer;
        }
    }
}
