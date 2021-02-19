using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class BrightnessBehavior
    {
        public abstract void ChangeBrightness(int value);
        public abstract int GetBrightness();
        public const int maxLight = 100;
        public const int minLight = 0;
    }

    class ChangedBrightnessBehavior : BrightnessBehavior
    {
        int brightness = BrightnessBehavior.maxLight;

        public override void ChangeBrightness(int value)
        {
            if (value > BrightnessBehavior.maxLight || value < BrightnessBehavior.minLight)
            {
                Console.WriteLine("Value out of range!");
            }
            else
            {
                brightness = value;

                Console.WriteLine("Brightness changed...");
                Console.WriteLine("Current state: " + brightness + "\n");
            }
        }

        public override int GetBrightness()
        {
            return brightness;
        }
    }
    class NoChangedBrightnessBehavior : BrightnessBehavior
    {
        public override void ChangeBrightness(int value)
        {
            Console.WriteLine("Brightness cannot be changed!\n");
        }

        public override int GetBrightness()
        {
            return -1;
        }
    }
}