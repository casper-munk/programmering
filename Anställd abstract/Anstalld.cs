using System;

namespace Anstalld1
{
    abstract class Anstalld
    {
        private String namn;

     
        
        public Anstalld(String namn)
        {
            this.namn = namn;

        }
        public abstract double BeräknaLön();
        
        public override String ToString()
        {
            return namn;
        }
        
    }
}
   
