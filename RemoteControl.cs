using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class RemoteControl : Device
    {
        private TV tv;

        public RemoteControl(string name, TV tv) : base(name)
        {
            this.tv = tv;
        }


        public void On()
        {
            tv.On();
        }

        public void Off()
        {
            tv.Off();
        }

        public void SetChannel(int channel)
        {
            tv.TuneChannel(channel);
        }

        public void Info()
        {
            tv.GetInfo();
        }
    }


    class RemoteController : RemoteControl
    {
        private int currentStation;

        public RemoteController(string name, TV tv) : base(name, tv)
        {
            currentStation = 1;
        }

        public void NextChannel()
        {
            SetChannel(currentStation + 1);
            currentStation = currentStation + 1;
        }

        public void PreviousChannel()
        {
            SetChannel(currentStation - 1);
            currentStation = currentStation - 1;
        }
    }
}