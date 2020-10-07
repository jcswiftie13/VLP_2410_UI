using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    public partial class Form1 : Form
    {
        private PortControl comport = new PortControl();
        public Form1()
        {
            InitializeComponent();
            comport.Connect();
        }

        private void SetLight_Click(object sender, EventArgs e)
        {
            string light = Convert.ToInt32(Intensity.Value).ToString();
            int sum = 0;
            string command = "@00F";
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
            Display.Text = $"Set light intensity to {light}";
            comport.SendData(command);
        }

        private void On_CheckedChanged(object sender, EventArgs e)
        {
            if (On.Checked)
            {
                Display.Text = "Light on";
                comport.SendData("@00L1007DCRLF");
            }
        }

        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            if (Off.Checked)
            {
                Display.Text = "Light off";
                comport.SendData("@00L0007CCRLF");
            }
        }
    }
}
