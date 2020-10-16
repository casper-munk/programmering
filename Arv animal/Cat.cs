using System;

namespace animal
{
    class Cat : Animal
    {
       
      public Cat(int age1)
      {
          age = age1;
          sound = "mjau" + age;

      }
     
    }
}