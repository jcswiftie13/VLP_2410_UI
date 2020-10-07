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
            int light = Convert.ToInt32(Intensity.Value);
            int sum = 0;
            bool zero = false;
            string command = "@00F";
            List<int> digits = new List<int>();
            while (light > 0)
            {
                digits.Add(light % 10);
                light /= 10;
            }
            digits.Reverse();
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits.Count < 3 && zero == false)
                {
                    for (int j = 0; j < (3 - digits.Count); i++)
                    {
                        command += "0";
                    }
                    zero = true;
                }
                command += Convert.ToString(digits[i]);
            }
            byte[] ascii = Encoding.ASCII.GetBytes(command);
            for (int i = 0; i < ascii.Length; i++)
            {
                sum += ascii[i];
            }
        }

        private void On_CheckedChanged(object sender, EventArgs e)
        {
            if (On.Checked)
            {
                comport.SendData("@00L1007DCRLF");
            }
        }

        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            if (Off.Checked)
            {
                comport.SendData("@00L0007CCRLF");
            }
        }
    }
}
