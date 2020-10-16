using System;

namespace animal
{
    class Dog
    {
        private int age;

        public Dog(int age1) 
        {
            age = age1;
        }
        public void Act()
        {
            Console.WriteLine("woof" + age);

        }
        
    }
}

       