using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class Microwave : Device
    {
        protected MicrowaveState state;
        private bool power;  

        public Microwave(string name) : base(name)
        {
            MicrowaveState state = new OffState(this);
            this.state = state;

            power = false;
        }

        public void ChangeState(MicrowaveState state)
        {
            this.state = state;
        }

        public void On()
        {
            state.On();
        }

        public void Off()
        {
            state.Off();
        }

        public void ReheatFood(int second)
        {
            state.ReheatFood(second);
        }

        public bool Power { get => power; set => power = value; }
    }

    class DefaultMicrowave : Microwave
    {
        public DefaultMicrowave(string name) : base(name)
        {
        }
    }
}
