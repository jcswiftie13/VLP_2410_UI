using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net.Configuration;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    class PortControl
    {
        private SerialPort port;
        public PortControl(string com, int baud)
        {
            port = new SerialPort(com, baud, Parity.None, 8, StopBits.One);
            Connect();
        }

        public void Connect()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
                else
                {
                    port.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Close()
        {
            try
            {
                port.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SendData(string command)
        {
            if (port.IsOpen)
            {
                port.WriteLine(command);
            }
        }

        public string GetData()
        {
            string indata = null;
            byte[] buf = new byte[16];

            port.Read(buf, 0, port.BytesToRead);

            if (buf != null)
            {
                indata = Encoding.ASCII.GetString(buf);
            }
            return indata;
        }
    }
}