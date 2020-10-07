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
        public PortControl()
        {
            port = new SerialPort("COM1", 38400, Parity.None, 8, StopBits.One);
        }

        public string CalChecksum(string light, string header)
        {
            int sum = 0;
            string command = header;
            if (light.Length < 3)
            {
                for (int j = 0; j < (3 - light.Length); j++)
                {
                    command += "0";
                }
            }
            command += light;
            byte[] ascii = Encoding.ASCII.GetBytes(command);
            for (int i = 0; i < ascii.Length; i++)
            {
                sum += ascii[i];
            }
            string hex = sum.ToString("X");
            hex = hex.Substring(hex.Length - 2);
            command += hex;
            command += "CRLF";
            return command;
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
            string indata = null, content = null;
            byte[] buf = new byte[1024];

            port.Read(buf, 0, port.BytesToRead);

            if (buf != null)
            {
                indata = Encoding.ASCII.GetString(buf);
            }
            if (indata[3] == 'N')
            {
                string error = indata.Substring(4, 2);
                switch (error)
                {
                    case "01":
                        content = "Command error";
                        break;
                    case "02":
                        content = "Checksum error";
                        break;
                    case "03":
                        content = "Set value out of range error";
                        break;
                }
            }
            else
            {
                content = "OK";
            }
            return content;
        }
    }
}
