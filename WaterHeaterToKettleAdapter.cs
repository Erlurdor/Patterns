using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class WaterHeaterToKettleAdapter : Kettle
    {
        WaterHeater waterHeater;

        public WaterHeaterToKettleAdapter(string name, WaterHeater waterHeater) : base(name)
        {
            this.waterHeater = waterHeater;
        }

        public override bool GetPower()
        {
            return waterHeater.GetPowerStatus();
        }

        public override int GetTemperature()
        {
            return waterHeater.GetTemperatureStatus();
        }

        public override string PowerSwitch(bool value)
        {
            waterHeater.SetPowerStatus(value);
            return "Succesfully";
        }

        public override string SetTemperature(int value)
        {
            waterHeater.SetLimitTemperature(value);
            return "Succesfully";
        }
    }
}