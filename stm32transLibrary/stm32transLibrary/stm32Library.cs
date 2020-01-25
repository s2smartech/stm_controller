using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace stm32transLibrary
{
    public class Stm32Library
    {
        SerialPort mainSerialPort;
        public void initializeSerialPort(SerialPort serialPort1)
        {
            mainSerialPort = serialPort1;
            /*Connect*/
            if (!serialPort1.IsOpen)
            {
                if (Serial_port_config())
                {
                    //try
                    //{
                    serialPort1.Open();
                    //}
                    /*catch
                    {
                        alert("Can't open " + serialPort1.PortName + " port, it might be used in another program");
                        return;
                    }*/

                    /*if (datalogger_checkbox.Checked)
                    {
                        try
                        {
                            out_file = new System.IO.StreamWriter(datalogger_checkbox.Text, datalogger_append_radiobutton.Checked);
                        }
                        catch
                        {
                            alert("Can't open " + datalogger_checkbox.Text + " file, it might be used in another program");
                            return;
                        }
                    }*/
                }
            }

            /*Disconnect*/
            else if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
                catch {/*ignore*/}

                //if (datalogger_checkbox.Checked)
                //    try { out_file.Dispose(); }
                //    catch {/*ignore*/ }

                //try { in_file.Dispose(); }
                //catch {/*ignore*/ }
            }
        }

        private bool Serial_port_config()
        {
            //try
            //{
            mainSerialPort.PortName = "COM4";
            //}
            /*catch
            {
                alert("There are no available ports");
                return false;
            }*/
            mainSerialPort.BaudRate = 9600;
            mainSerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (1).ToString(), true);
            mainSerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None", true);
            mainSerialPort.DataBits = 8;
            mainSerialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None", true);

            return true;
        }

        public int Add(int a, String b)
        {
            mainSerialPort.Write(b);
            return a;
        }
    }
}
