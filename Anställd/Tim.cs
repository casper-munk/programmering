using System;

namespace Anstalld1
{
    class Tim : Anstalld
    {
        private double timlön;
        private double antaltimmar;

         public Tim(string namnet, double timlön, double antaltimmar):base(namnet)
        {
           this.timlön = timlön;
           this.antaltimmar = antaltimmar;
        }
        public override double BeräknaLön()
        {
            return timlön * antaltimmar;
        }
          public override String ToString()
       {
           return "olof: " + 
                Environment.NewLine + "timanställd" + 
                Environment.NewLine + "timlön: " +timlön + 
                Environment.NewLine + "antaltimmar:" +antaltimmar + 
                Environment.NewLine + "lön:" + BeräknaLön() +
                Environment.NewLine;

       }
       
    }

}
