using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class TemperatureBehavior
    {
        public const int maxTemperature = 100;
        public const int minTemperature = 0;

        public abstract string SetTemperature(int value);
        public abstract int GetTemperature();
    }

    class InstallableTemperatureBehavior : TemperatureBehavior
    {
        int temperature = TemperatureBehavior.maxTemperature;

        public override int GetTemperature()
        {
            return temperature;
        }

        public override string SetTemperature(int value)
        {
            if (value <= TemperatureBehavior.maxTemperature && value >= TemperatureBehavior.minTemperature)
            {
                temperature = value;
                return "Succesfully";
            }
            else
            {
                return "Not in range: " + TemperatureBehavior.minTemperature + " - " + TemperatureBehavior.maxTemperature;
            }
        }
    }

    class NoInstallableTemperatureBehavior : TemperatureBehavior
    {
        public override int GetTemperature()
        {            
            return -1;
        }

        public override string SetTemperature(int value)
        {
            return "Temperature cannot be set!";
        }
    }
}