using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    // чайник
    abstract class Kettle : Device
    {
        protected PowerBehavior powerBehavior;
        protected TemperatureBehavior temperatureBehavior;


        public Kettle(string name) : base(name)
        {
        }


        public void SetPowerBehavior(PowerBehavior powerBehavior)
        {
            this.powerBehavior = powerBehavior;
        }

        public void SetTemperatureBehavior(TemperatureBehavior temperatureBehavior)
        {
            this.temperatureBehavior = temperatureBehavior;
        }


        abstract public string PowerSwitch(bool value);

        abstract public string SetTemperature(int value);

        abstract public bool GetPower();
        abstract public int GetTemperature();
    }

    // обычный чайник
    class NoSmartKettle : Kettle
    {
        public NoSmartKettle(string name) : base(name)
        {
            SetPowerBehavior(new KettlePowerBehavior());
            SetTemperatureBehavior(new NoInstallableTemperatureBehavior());
        }

        public override bool GetPower()
        {
            return powerBehavior.GetPower();
        }

        public override int GetTemperature()
        {
            return temperatureBehavior.GetTemperature();
        }

        public override string PowerSwitch(bool value)
        {
            return powerBehavior.PowerSwitch(value);
        }

        public override string SetTemperature(int value)
        {
            return temperatureBehavior.SetTemperature(value);
        }
    }

    // умный чайник
    class XiaomiKettle : Kettle
    {
        public XiaomiKettle(string name) : base(name)
        {
            SetPowerBehavior(new KettlePowerBehavior());
            SetTemperatureBehavior(new InstallableTemperatureBehavior());
        }

        public override bool GetPower()
        {
            return powerBehavior.GetPower();
        }

        public override int GetTemperature()
        {
            return temperatureBehavior.GetTemperature();
        }

        public override string PowerSwitch(bool value)
        {
            return powerBehavior.PowerSwitch(value);
        }

        public override string SetTemperature(int value)
        {
            return temperatureBehavior.SetTemperature(value);
        }
    }
}