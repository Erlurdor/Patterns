using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class TV : Device
    {
        public TV(string name) : base(name)
        {
        }

        abstract public void On();
        abstract public void Off();
        abstract public void TuneChannel(int channel);
        abstract public void GetInfo();
    }


    class XiaomiTV : TV
    {
        private string info;

        public XiaomiTV(string name) : base(name)
        {
            info = "Xiaomi TV";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This is a {info}!");
        }

        public override void Off()
        {
            Console.WriteLine("Power off...");
        }

        public override void On()
        {
            Console.WriteLine("Power on...");
        }

        public override void TuneChannel(int channel)
        {
            Console.WriteLine($"Current channel of {info}: {channel}");
        }
    }

    class SonyTV : TV
    {
        private string info;

        public SonyTV(string name) : base(name)
        {
            info = "Sony TV";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"This is a {info}!");
        }

        public override void Off()
        {
            Console.WriteLine("Power off...");
        }

        public override void On()
        {
            Console.WriteLine("Power on...");
        }

        public override void TuneChannel(int channel)
        {
            Console.WriteLine($"Current channel of {info}: {channel}");
        }
    }
}