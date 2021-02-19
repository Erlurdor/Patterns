using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class PowerBehavior
    {
        public abstract string PowerSwitch(bool value);
        public abstract bool GetPower();
    }


    class DefaultLightingPowerBehavior : PowerBehavior
    {
        bool isEnable = false;

        public override bool GetPower()
        {
            return isEnable;
        }

        public override string PowerSwitch(bool value)
        {
            isEnable = value;
            return "Succesfully";
        }
    }

    class KettlePowerBehavior : PowerBehavior
    {
        bool isEnable = false;

        public override bool GetPower()
        {
            return isEnable;
        }

        public override string PowerSwitch(bool value)
        {
            isEnable = value;
            return "Succesfully";
        }
    }
}