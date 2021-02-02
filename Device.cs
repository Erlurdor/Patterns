using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class Device
    {
        protected string name;
        protected int ID;

        public Device(string name)
        {
            this.name = name;            
        }

        virtual public void SetID(int Id)
        {
            ID = Id;
        }

        virtual public string GetName()
        {
            return name;
        }
        
        virtual public int GetID()
        {
            return ID;
        }
    }
}