using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class WaterHeater
    {
        private bool PowerStatus;
        private int TemperatureStatus;

        public WaterHeater()
        {
            PowerStatus = false;
            TemperatureStatus = 0;
        }

        public void SetLimitTemperature(int temperature)
        {
            TemperatureStatus = temperature;
        }

        public void SetPowerStatus(bool powerStatus)
        {
            PowerStatus = powerStatus;
        }

        public bool GetPowerStatus()
        {
            return PowerStatus;
        }

        public int GetTemperatureStatus()
        {
            return TemperatureStatus;
        }
    }
}