using System;

namespace Patt3_v2
{    
    class ProxyKettle : Kettle
    {
        private Kettle kettle;

        private void Log()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Current date: " + DateTime.Now);
            Console.WriteLine("Kettle name: " + kettle.GetName());
            Console.WriteLine("Kettle ID: " + kettle.GetID());
        }
        

        public ProxyKettle(Kettle kettle) : base(kettle.GetName())
        {
            this.kettle = kettle;
        }


        public override string SetTemperature(int value)
        {            
            Log();
            Console.WriteLine("Temperature setting on value " + value + "...");
            Console.WriteLine(kettle.SetTemperature(value));
            Console.WriteLine("\n");
            return "";
        }

        public override string PowerSwitch(bool value)
        {
            Log();            
            if (value == true)            
                Console.WriteLine("Set power on...");            
            else            
                Console.WriteLine("Set power off...");
            
            Console.WriteLine(kettle.PowerSwitch(value));
            Console.WriteLine("\n");
            return "";
        }

        public override bool GetPower()
        {
            Log();
            Console.WriteLine("Getting state power...");
            return kettle.GetPower();
        }

        public override int GetTemperature()
        {
            Log();
            Console.WriteLine("Getting curreunt temperature...");
            return kettle.GetTemperature();
        }

        public override int GetID()
        {
            return this.kettle.GetID();
        }

        public override string GetName()
        {
            return this.kettle.GetName();
        }

        public override void SetID(int Id)
        {
            this.kettle.SetID(Id);
        }
    }   
}