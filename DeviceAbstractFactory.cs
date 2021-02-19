using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class DeviceAbstractFactory
    {
        public abstract Kettle createKettle(string name);
        public abstract Lighting createLighting(string name);
    }

    class XiaomiDeviceAbstractFactory : DeviceAbstractFactory
    {
        public override Kettle createKettle(string name)
        {
            return new XiaomiKettle($"{name} - Xiaomi Kettle");
        }

        public override Lighting createLighting(string name)
        {
            return new XiaomiLamp($"{name} - Xiaomi Lamp");
        }
    }

    class NoSmartDeviceAbstractFactory : DeviceAbstractFactory
    {
        public override Kettle createKettle(string name)
        {
            return new NoSmartKettle($"{name} - No Smart Kettle");
        }

        public override Lighting createLighting(string name)
        {
            return new Chandelier($"{name} - Chandelier");
        }
    }
}