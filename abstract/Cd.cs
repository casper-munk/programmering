using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Cd : Sak
    {
        protected String artist;
        public Cd(string titel2, String artist1)
        {
            titel = titel2;
            artist = artist1;
        }

        public override void Act()
        {
            Console.WriteLine(titel + ", " + artist);
        }

    }
        
}
