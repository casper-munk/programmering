using System;

namespace Anstalld1
{
    class BasProvision : Provision
    {
        private double fastlön;

        public BasProvision(string namnet, double provision, double försäljning, double fastlön):base(namnet, provision, försäljning)
       {
           this.provision = provision;
           this.försäljning = försäljning;
           this.fastlön = fastlön;

       }
        public override double BeräknaLön()
        {
             return försäljning / 100 * provision + fastlön;
        }
         public override String ToString()
       {
           return "sumpen: " + 
                Environment.NewLine + "bas och provisionsanställd" + 
                Environment.NewLine + "provision: " +provision + 
                Environment.NewLine + "försäljning:" +försäljning + 
                Environment.NewLine + "fastlön:" +fastlön +
                Environment.NewLine + "lön:" + BeräknaLön() +
                Environment.NewLine;

       }
        
    }

}    
