using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Dvd : Sak
    {
      protected String regissör; 
        public Dvd(String titel1, String regissör1)
        {
            titel = titel1;
            regissör = regissör1;
        }

        public override void Act()
        {
            Console.WriteLine(titel + ", " + regissör);
        }
        

    }
        
}
