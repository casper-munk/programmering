using System;
using System.Collections.Generic;


namespace Anstalld1
{
    class Test
    {
        List<Anstalld> anställda;
        public Test()
        {
          anställda = new List<Anstalld>();
          Provision ada = new Provision("Ada", 5, 200000);
          anställda.Add(ada);
          Fast billy = new Fast("billy", 32000);
          anställda.Add(billy);
          Tim olof = new Tim("olof", 73, 145);
          anställda.Add(olof);
          BasProvision sumpen = new BasProvision("sumpen", 3, 100000, 15000);
          anställda.Add(sumpen);

        }
        public void Run()
        {
          foreach( Anstalld gobbe in anställda)
          {
              
              Console.WriteLine(gobbe.ToString());
          }
        }
    }
}    
