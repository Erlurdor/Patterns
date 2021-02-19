using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class EventListener
    {
        public abstract void Update(Device device);
    }


    class LoggingEventListener : EventListener
    {
        private string message;

        public LoggingEventListener()
        {
            message = "has been added!";
        }

        public override void Update(Device device)
        {
            Console.WriteLine($"{device.GetName()} {message}");
        }
    }

    class DataLoggingEventListener : EventListener
    {
        private string message;

        public DataLoggingEventListener()
        {
            message = "Current time: ";
        }
        public override void Update(Device device)
        {
            Console.WriteLine($"{message}{DateTime.Now}");
        }
    }
}
