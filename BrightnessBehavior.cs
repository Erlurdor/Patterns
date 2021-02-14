using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    interface BrightnessBehavior
    {
        public void ChangeBrightness(int value);
        public int GetBrightness();
        public const int maxLight = 100;
        public const int minLight = 0;
    }

    class ChangedBrightnessBehavior : BrightnessBehavior
    {
        int brightness = BrightnessBehavior.maxLight;

        public void ChangeBrightness(int value)
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

        public int GetBrightness()
        {
            return brightness;
        }
    }
    class NoChangedBrightnessBehavior : BrightnessBehavior
    {
        public void ChangeBrightness(int value)
        {
            Console.WriteLine("Brightness cannot be changed!\n");
        }

        public int GetBrightness()
        {
            return -1;
        }
    }
}