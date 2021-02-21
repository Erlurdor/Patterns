using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Patt3_v2
{
    abstract class MicrowaveState
    {
        protected Microwave microwave;

        protected MicrowaveState(Microwave microwave)
        {
            this.microwave = microwave;
        }

        public abstract void On();
        public abstract void Off();
        public abstract void ReheatFood(int second);
    }


    class OffState : MicrowaveState
    {
        public OffState(Microwave microwave) : base(microwave)
        {
        }

        public override void Off()
        {
            Console.WriteLine("Microwave is already off!");
        }

        public override void On()
        {
            Console.WriteLine("Turn on...");
            microwave.Power = true;
            microwave.ChangeState(new OnState(microwave));
        }

        public override void ReheatFood(int second)
        {
            Console.WriteLine("Microwave is off! Turn it on to reheat food!");
        }
    }

    class OnState : MicrowaveState
    {
        public OnState(Microwave microwave) : base(microwave)
        {
        }

        public override void Off()
        {
            Console.WriteLine("Turn off...");
            microwave.Power = false;
            microwave.ChangeState(new OffState(microwave));
        }

        public override void On()
        {
            Console.WriteLine("Microwave is already on!");
        }

        public override void ReheatFood(int second)
        {
            Console.WriteLine("Reheating food...");
            microwave.ChangeState(new ReheatFoodState(microwave, second));
        }
    }

    class ReheatFoodState : MicrowaveState
    {
        private int timeLeft;
        private Timer timer;
        private Timer timerTileLeft;

        public ReheatFoodState(Microwave microwave, int second) : base(microwave)
        {
            timeLeft = second;            

            // сообщения
            timerTileLeft = new Timer(999);
            timerTileLeft.Elapsed += TimeLeft;
            timerTileLeft.AutoReset = true;
            timerTileLeft.Enabled = true;

            // разогрев
            timer = new Timer(second * 1000);
            timer.Elapsed += CompleteReheat;
            timer.AutoReset = false;
            timer.Enabled = true;        
        }

        public override void Off()
        {
            Console.WriteLine("The food is reheating! Please wait!");            
        }

        public override void On()
        {
            Console.WriteLine("Microwave is already on and now the food is reheating!");
        }

        public override void ReheatFood(int second)
        {
            Console.WriteLine("Microwave is already reheating!");

        }

        private void CompleteReheat(Object source, ElapsedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();

            timerTileLeft.Stop();
            timerTileLeft.Dispose();

            Console.WriteLine("Reheat complete!");
            microwave.ChangeState(new OnState(microwave));
        }

        private void TimeLeft(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"{timeLeft} seconds left...");
            timeLeft -= 1;
        }
    }
}
