using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RGBLed
{
    public partial class Form1 : Form
    {
        SerialPort serial;
        public Form1()
        {
            InitializeComponent();
            serial = new SerialPort();
            serial.PortName = "COM5";
            serial.BaudRate = 9600;
            serial.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;
            color.AnyColor = true;
            color.ShowDialog();
            serial.Write(color.Color.R.ToString()+color.Color.G.ToString()+color.Color.B.ToString());
        }
    }
}
