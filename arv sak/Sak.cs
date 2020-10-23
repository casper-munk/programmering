using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Sak
    {
        protected String titel;


        public Sak()
        {
            
        }
        public virtual void Act()
        {
           Console.WriteLine(titel); 
        }

    }
        
}
