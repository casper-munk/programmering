using System;

namespace animal
{
    class Cow : Animal
    {
       
      public Cow(int age1)
      {
          age = age1;
          sound = "muu" + age;

      }
     
    }
}