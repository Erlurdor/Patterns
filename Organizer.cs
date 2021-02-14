using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class Organizer : Device
    {
        protected DateTime dateTime;
        protected string Message;

        public Organizer(string name) : base(name)
        {
        }

        abstract public string getMessage();
    }

    class XiaomiOrganizer : Organizer
    {
        public XiaomiOrganizer(string name) : base(name)
        {            
            dateTime = DateTime.Now;
            Message = "Hello, MI fan!";
        }

        public override string getMessage()
        {
            return Message;
        }
    }
}