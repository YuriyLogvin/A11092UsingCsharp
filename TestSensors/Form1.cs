using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using EmKit.ProtocolEngine;

namespace TestSensors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Thread _UpdateDataThread = null;

        public void UpdateDataThread()
        { 
        }

        Rs585DevicesProcessor _Rs585DevicesProcessor = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                return;
            }

            _Rs585DevicesProcessor = new Rs585DevicesProcessor(_CreateSerialPort(comboBox1.Text));

            _UpdateDataThread = new Thread(new ThreadStart(UpdateDataThread));
            button1.Enabled = false;
        }

        static SerialBusSerialPort _CreateSerialPort(string comPort)
        {
            var bus = new SerialBusSerialPort(comPort, 19200, Parity.None, 8, StopBits.Two);
            bus.ReadTimeout = 1000;
            bus.WriteTimeout = 500;
            bus.Open();
            bus.ReceivedBytesThreshold = 1;
            return bus;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void timerPollingDevices_Tick(object sender, EventArgs e)
        {

        }

        private void buttonPoll_Click(object sender, EventArgs e)
        {
            PollDevices();
        }

        private void PollDevices()
        {
            bool pingRes = false;
            pingRes = _Rs585DevicesProcessor.Ping(EmkAddr.CurrentSensor);
            checkBoxCurrSens1Have.Checked = pingRes;
            if (pingRes)
            { 
                short current = 0;
                short temp = 0;
                try
                {
                    _Rs585DevicesProcessor.GetCurrent(EmkAddr.CurrentSensor, out current, out temp);
                }
                catch {};
                textBoxCurrSens1Curr.Text = current.ToString();
                textBoxCurrSens1Temp.Text = temp.ToString();
            }
        }
    }
}
