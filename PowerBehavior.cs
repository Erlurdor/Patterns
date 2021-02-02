using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    interface PowerBehavior
    {
        public string PowerSwitch(bool value);
        public bool GetPower();
    }


    class DefaultLightingPowerBehavior : PowerBehavior
    {
        bool isEnable = false;

        public bool GetPower()
        {
            return isEnable;
        }

        public string PowerSwitch(bool value)
        {
            isEnable = value;
            return "Succesfully";
        }
    }

    class KettlePowerBehavior : PowerBehavior
    {
        bool isEnable = false;

        public bool GetPower()
        {
            return isEnable;
        }

        public string PowerSwitch(bool value)
        {
            isEnable = value;
            return "Succesfully";
        }
    }
}