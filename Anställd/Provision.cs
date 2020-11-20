using System;

namespace Anstalld1
{
    class Provision : Anstalld
    {
        private double provision;
        private double försäljning;
       
       public Provision(string namnet, double provision, double försäljning):base(namnet)
       {
           this.provision = provision;
           this.försäljning = försäljning;

       }
       public override double BeräknaLön()
       {
           return försäljning / 100 * provision;

       }
       public override String ToString()
       {
           return "Ada: " + 
                Environment.NewLine + "provisionsanställd" + 
                Environment.NewLine + "provision: " +provision + 
                Environment.NewLine + "försäljning:" +försäljning + 
                Environment.NewLine + "lön:" + BeräknaLön();

       }
    }
}