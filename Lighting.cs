using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{    
    abstract class Lighting : Device
    {
        private PowerBehavior powerBehavior;
        private BrightnessBehavior brightnessBehavior;

        public Lighting(string name) : base(name)
        {            
        }

        public void SetPowerBehavior(PowerBehavior powerBehavior)
        {
            this.powerBehavior = powerBehavior;
        }

        public void SetBrightnessBehavior(BrightnessBehavior brightnessBehavior)
        {
            this.brightnessBehavior = brightnessBehavior;
        }


        public void PowerSwitch(bool value)
        {
            powerBehavior.PowerSwitch(value);            
        }

        public void ChangeBrightness(int value)
        {
            brightnessBehavior.ChangeBrightness(value);           
        }
    }

    
    class Chandelier : Lighting
    {
        public Chandelier(string name) : base(name)
        {            
            SetPowerBehavior(new DefaultLightingPowerBehavior());
            SetBrightnessBehavior(new NoChangedBrightnessBehavior());
        }
    }

    class XiaomiLamp : Lighting
    {
        public XiaomiLamp(string name) : base(name)
        {
            SetPowerBehavior(new DefaultLightingPowerBehavior());
            SetBrightnessBehavior(new ChangedBrightnessBehavior());
        }
    }
}