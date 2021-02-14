using System;
using System.Collections.Generic;
using System.Text;

namespace Patt3_v2
{
    abstract class OrganizerDecorator : Organizer
    {
        protected Organizer organizer;

        public OrganizerDecorator(string name, Organizer Organizer) : base(name)
        {
            organizer = Organizer;
        }

        public override string getMessage()
        {
            return organizer.getMessage();
        }
    }


    class MorningOrganizer : OrganizerDecorator
    {
        public MorningOrganizer(string name, Organizer Organizer) : base(name, Organizer)
        {
        }

        public override string getMessage()
        {
            return base.getMessage() + " Good morning!";
        }
    }

    class EveningOrganizer : OrganizerDecorator
    {
        public EveningOrganizer(string name, Organizer Organizer) : base(name, Organizer)
        {            
        }

        public override string getMessage()
        {
            return base.getMessage() + " Good evening!";
        }
    }
}