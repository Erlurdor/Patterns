using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class KettleSimpleFactory : Device
    {
        public KettleSimpleFactory(string name) : base(name)
        {
        }

        public Kettle createKettle(string typeTemperature, string name)
        {
            if (typeTemperature == "installable")
            {
                return new XiaomiKettle($"{name} - Xiaomi Kettle");
            }
            else if (typeTemperature == "noinstallable")
            {
                return new NoSmartKettle($"{name} - No Smart Kettle");
            }
            else
            {
                Console.WriteLine("Unknown type temperature...");
                throw new Exception();
            }            
        }
    }
}