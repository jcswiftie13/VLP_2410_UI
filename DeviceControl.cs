using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    class DeviceControl
    {
        private PortControl comport;
        public void ConnectDevice(string com, int baud)
        {
            comport = new PortControl(com, baud);
        }

        public string ConcatIntensity(int intensity)
        {
            string light = intensity.ToString();
            string command = "@00F";
            if (light.Length < 3)
            {
                for (int j = 0; j < (3 - light.Length); j++)
                {
                    command += "0";
                }
            }
            command += light;
            command += "00";
            return command;
        }

        public string CalChecksum(string command)
        {
            int sum = 0;
            byte[] ascii = Encoding.ASCII.GetBytes(command);
            for (int i = 0; i < ascii.Length; i++)
            {
                sum += ascii[i];
            }
            string hex = sum.ToString("X");
            hex = hex.Substring(hex.Length - 2);
            return hex;
        }

        public string SetIntensity(int intensity)
        {
            string command = ConcatIntensity(intensity);
            command += CalChecksum(command);
            command += "\r\n";
            string respond = HandleCommand(command);
            return respond;
        }

        public string LightOn()
        {
            string respond = HandleCommand("@00L1007D\r\n");
            return respond;
        }

        public string LightOff()
        {
            string respond = HandleCommand("@00L0007C\r\n");
            return respond;
        }

        public string HandleCommand(string command)
        {
            comport.SendData(command);
            string ret = Interpret(comport.GetData());
            return ret;
        }

        public string Interpret(string indata)
        {
            string content = null;
            if (indata[3] == 'N')
            {
                string error = indata.Substring(4, 2);
                switch (error)
                {
                    case "01":
                        content = "Command error";
                        return content;
                    case "02":
                        content = "Checksum error";
                        return content;
                    case "03":
                        content = "Set value out of range error";
                        return content;
                }
            }
            else if (indata[3] == 'O')
            {
                content = "OK";
                return content;
            }
            return null;
        }
    }
}