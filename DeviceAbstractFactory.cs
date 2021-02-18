using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    interface DeviceAbstractFactory
    {
        public Kettle createKettle(string name);
        public Lighting createLighting(string name);
    }

    class XiaomiDeviceAbstractFactory : DeviceAbstractFactory
    {
        public Kettle createKettle(string name)
        {
            return new XiaomiKettle($"{name} - Xiaomi Kettle");
        }

        public Lighting createLighting(string name)
        {
            return new XiaomiLamp($"{name} - Xiaomi Lamp");
        }
    }

    class NoSmartDeviceAbstractFactory : DeviceAbstractFactory
    {
        public Kettle createKettle(string name)
        {
            return new NoSmartKettle($"{name} - No Smart Kettle");
        }

        public Lighting createLighting(string name)
        {
            return new Chandelier($"{name} - Chandelier");
        }
    }
}