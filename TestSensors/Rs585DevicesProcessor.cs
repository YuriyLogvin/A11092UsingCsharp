using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmKit.ProtocolEngine;
using System.IO.Ports;
using EmKit.DevicesEngine;
using EmKit.DevicesEngine.InterfaceMetods;

namespace TestSensors
{
    class Rs585DevicesProcessor
    {
        SerialPortProcessor _SerialPortProcessor;
        SerialPort _ComPort;
        //protected AsyncOperation AsyncOp;
        public Rs585DevicesProcessor(SerialPort comPort)
        {
            _ComPort = comPort;

            _SerialPortProcessor = new SerialPortProcessor(_ComPort, 1);

            //AsyncOp = AsyncOperationManager.CreateOperation(null);
        }

        public bool Ping(EmkAddr addr)
        {
            _SerialPortProcessor.DestAddress = (byte)(addr);
            _SerialPortProcessor.Invoke((byte)EmkMetods.Ping);
            byte metodNumber;
            var res = _SerialPortProcessor.WaitAnswer(out metodNumber);
            if (res == null)
                return false;

            if (res.Length < 1 || !(res[0] is bool))
                return false;//throw new InvalidOperationException();

            return (bool)res[0];
        }

        public void PingAll()
        {
        }

        public void Test()
        {
            _SerialPortProcessor.DestAddress = (byte)(20 + 1);
            _SerialPortProcessor.Invoke(3);
        }

        public int GetVoltage(EmkAddr addr)
        {
            _SerialPortProcessor.DestAddress = (byte)addr;
            _SerialPortProcessor.Invoke(3);
            byte metodNumber;
            var res = _SerialPortProcessor.WaitAnswer(out metodNumber);
            if (res == null)
                return 0;

            if (res.Length < 1 || !(res[0] is short))
                throw new InvalidOperationException();

            return (short)res[0];
                        
        }

        public void GetCurrent(EmkAddr addr, out short current, out short temp)
        {
            _SerialPortProcessor.DestAddress = (byte)addr;
            _SerialPortProcessor.Invoke((byte)InterfaceMetodsCurrSens.CurrentGet);
            byte metodNumber;
            var res = _SerialPortProcessor.WaitAnswer(out metodNumber);
            if (res == null)
                throw new InvalidOperationException();

            if (res.Length < 2 || !(res[0] is short) || !(res[1] is short))
                throw new InvalidOperationException();

            current = (short)res[0];
            temp = (short)res[1];
        }

    }
}
