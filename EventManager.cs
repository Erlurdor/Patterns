using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    class EventManager
    {
        private List<EventListener> eventListeners;

        public EventManager()
        {
            eventListeners = new List<EventListener>();
        }

        public void Subscribe(EventListener eventListener)
        {
            this.eventListeners.Add(eventListener);
        }

        public void Unsubscribe(EventListener eventListener)
        {
            this.eventListeners.Remove(eventListener);
        }
        
        public void Notify(Device device)
        {
            foreach (var listeners in eventListeners)
            {
                listeners.Update(device);
            }
        }
    }
}
