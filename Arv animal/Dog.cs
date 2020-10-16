using System;

namespace animal
{
    class Dog : Animal
    {
      

        public Dog(int age1) 
        {
            age = age1;
            sound = "Woof" + age;
        }
        
        
    }
}