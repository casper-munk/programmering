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
