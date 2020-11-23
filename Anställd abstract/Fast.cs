using System;

namespace Anstalld1
{
    class Fast : Anstalld
    {
        private double Lön;

        public Fast(string namnet, double Lön):base(namnet)
        {
           this.Lön = Lön;
        }
        public override double BeräknaLön()
        {
            return Lön;
        }
        public override String ToString()
        {
            return "billy: " + 
                Environment.NewLine + "fastanställd" +
                Environment.NewLine + "Lön:" + BeräknaLön() +
                Environment.NewLine;
        }
        
    }
}    
