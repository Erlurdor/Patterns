using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    interface TemperatureBehavior
    {
        public const int maxTemperature = 100;
        public const int minTemperature = 0;

        public string SetTemperature(int value);
        public int GetTemperature();
    }

    class InstallableTemperatureBehavior : TemperatureBehavior
    {
        int temperature = TemperatureBehavior.maxTemperature;

        public int GetTemperature()
        {
            return temperature;
        }

        public string SetTemperature(int value)
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
        public int GetTemperature()
        {            
            return -1;
        }

        public string SetTemperature(int value)
        {
            return "Temperature cannot be set!";
        }
    }
}