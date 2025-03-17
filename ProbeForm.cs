using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SoilProbeConfig
{
    public partial class ProbeForm : Form
    {
        public ProbeForm()
        {
            InitializeComponent();
        }

        private void StartupRS485()
        {
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPort.Items.Contains("COM7"))
            {
                comboBoxPort.Text = "COM7";
            }
            else if (comboBoxPort.Items.Count > 0)
            {
                comboBoxPort.Text = comboBoxPort.Items[0].ToString();
            }
        }

        // SERIAL PORT PAGE
        private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureSerialPort();
        }

        private void ComboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureSerialPort();
        }

        private void ConfigureSerialPort()
        {
            // try to open the selected serial port
            openLabel.Text = "CLOSED";
            openLabel.ForeColor = Color.Red;
            if (rs485Port.IsOpen)
            {
                rs485Port.Close();
            }

            if (comboBoxPort.Text != "")
            {
                rs485Port.PortName = comboBoxPort.Text;
                try
                {
                    rs485Port.Open();
                    rs485Port.NewLine = "\r";
                    openLabel.Text = "OPEN";
                    openLabel.ForeColor = Color.Green;
                    rs485Port.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                }
                catch (Exception ex)
                {
                    listBox.Items.Add("Communication Error - " + ex.Message);
                }
            }
        }

        private void ProbeForm_Load(object sender, EventArgs e)
        {
            StartupRS485();
        }

        private void TestLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Device should be address 0 and baud 9600
            // Send a command to get the temperature and moisture.
            listBox.Items.Clear();
            comboBoxBaud.SelectedIndex = 3;
            listBox.Items.Add(SoilMoistureValues(0));
            string reply = ReadAddr(0, "0200");
            if (reply.Contains("Error"))
            {
                listBox.Items.Add("Error reading from the device");
                return;
            }

            addrLabel.Text = reply;
            string newBaud = ReadAddr(0, "0201");
            int indx = Convert.ToInt32(newBaud);
            baudLabel.Text = comboBoxBaud.Items[indx].ToString();
        }

        private void UpdateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send codes to update address and baud rate
            //newAddrUpDown
            int newValue = (int)newAddrUpDown.Value;
            // Write the new address to register 0200
            WriteValue(newValue, "0200");
            // read the value at register 
            string newaddr = ReadAddr(0, "0200");
            if (newaddr.Contains("Error"))
            {
                listBox.Items.Add("Error reading from the device");
                return;
            }
            listBox.Items.Add("New Address: " + newaddr);
            // write the new baud rate to 0201
            string newBaud = ReadAddr(0, "0201");
            WriteValue(7, "0201");
            listBox.Items.Add("New Baud: " + newBaud);
            newAddrLabel.Text = newaddr;
            int indx = Convert.ToInt32(newBaud);
            newBaudLabel.Text = comboBoxBaud.Items[indx].ToString();

        }

        private void ConfirmLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the serial port baud rate and send a message to the new address.
            //      comboBoxBaud.SelectedIndex = 7;
            listBox.Items.Clear();
            int addr = (int)newAddrUpDown.Value;
 //           for (addr = 0; addr < 32; addr++)
 //           {
                listBox.Items.Add(addr.ToString() + ": " + SoilMoistureValues(addr));
                listBox.Refresh();
 //           }
        }

        private void WriteValue(int newAddr, string register)
        {
            byte address = Convert.ToByte(0);
            //Function 3  response buffer:
            byte function = 6;
            ushort start = Convert.ToUInt16(register, 16);
            byte value = Convert.ToByte(newAddr);
            byte[] message = new byte[8];
            //Build outgoing modbus message:
            BuildMessage(address, function, start, value, ref message);

            byte[] response = new byte[8];

            try
            {
                rs485Port.Write(message, 0, message.Length);
                System.Threading.Thread.Sleep(100);
                int nBytes = rs485Port.BytesToRead;
                byte[] resp = new byte[nBytes];
                rs485Port.Read(resp, 0, nBytes);//  ReadExisting();
            }                 //     string reply = rs485Port.ReadExisting();                }
            catch (Exception err)
            {
                string status = "Error in read event: " + err.Message;
            }
        }
        private string ReadAddr(int newAddr, string register)
        {
            //// modbus
            ///// 0x0000 - SW, 0x0200 - Address, 0x0201 Baud

            byte address = Convert.ToByte(newAddr);
            //Function 3  response buffer:
            byte function = 3;
            ushort start = Convert.ToUInt16(register, 16);
            byte registers = 1;
            byte[] message = new byte[8];
            //Build outgoing modbus message:
            BuildMessage(address, function, start, registers, ref message);

            string reply;
            byte[] response = new byte[5 + 2 * registers];

            try
            {
                rs485Port.Write(message, 0, message.Length);
                System.Threading.Thread.Sleep(100);
                int nBytes = rs485Port.BytesToRead;
                byte[] resp = new byte[nBytes];
                rs485Port.Read(resp, 0, nBytes);

                int value = resp[3] * 256 + resp[4];
                reply = value.ToString();
            }
            catch (Exception err)
            {
                reply = "Error in read event: " + err.Message;
            }
            return reply;
        }

        private string SoilMoistureValues(int addr)
        {
            // read a soil moisture probe at the address
            byte address = Convert.ToByte(addr);
            byte function = 3;
            byte start = 0;
            byte registers = 2;
            byte[] message = new byte[8];

            //Build outgoing modbus message:
            BuildMessage(address, function, start, registers, ref message);

            string transmit = "";
            foreach (byte b in message)
            {
                transmit += b.ToString("X2") + " ";
            }

            //Function 3 response buffer:
            byte[] response = new byte[5 + 2 * registers];

            //Send modbus message to Serial Port:
            string reply;
            try
            {
                rs485Port.Write(message, 0, message.Length);
                System.Threading.Thread.Sleep(100);

                int nBytes = rs485Port.BytesToRead;
                byte[] resp = new byte[nBytes];
                rs485Port.Read(resp, 0, nBytes);//  
                if (nBytes == 9)
                {

                    double temperature = (resp[3] * 256.0 + resp[4]) / 100.0;
                    double soilMoisture = (resp[5] * 256.0 + resp[6]) / 100.0;
                    reply = " Temp: " + temperature.ToString("F2") + " Moisture: " + soilMoisture.ToString("F2") + "%";
                }
                else
                {
                    reply = "Problem getting data. Bytes read: " + nBytes.ToString();
                }
            }
            catch (Exception err)
            {
                reply = "Error in read event: " + err.Message;
            }
            return reply;
        }

        #region Build Message
        private void BuildMessage(byte address, byte type, ushort start, ushort registers, ref byte[] message)
        {
            //Array to receive CRC bytes:
            byte[] CRC = new byte[2];

            byte[] values = BitConverter.GetBytes(start);
            message[0] = address;
            message[1] = type;
            message[2] = values[1];
            message[3] = values[0];
            values = BitConverter.GetBytes(registers);
            message[4] = values[1];
            message[5] = values[0];
            GetCRC(message, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
        }
        #endregion
        #region CRC Computation

        private void GetCRC(byte[] message, ref byte[] CRC)
        {
            //Function expects a modbus message of any length as well as a 2 byte CRC array in which to 
            //return the CRC values:

            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                    {
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                    }
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }
        #endregion

    }
}
