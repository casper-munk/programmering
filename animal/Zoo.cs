using System;
using System.Collections.Generic;
namespace animal
{
    class Zoo
    {
       List<Dog> dogs;
        List<Cat> cats;
       public Zoo()
       {
         dogs = new List<Dog>();
         Dog minhund = new Dog(4);
         dogs.Add(minhund);
         Dog minhund1 = new Dog(3);
         dogs.Add(minhund1);
         Dog minhund2 = new Dog(2);
         dogs.Add(minhund2);

         
         cats = new List<Cat>();
         Cat minkatt = new Cat(3);
         cats.Add(minkatt);
         Cat minkatt1 = new Cat(5);
         cats.Add(minkatt1);
         Cat minkatt2 = new Cat(2);
         cats.Add(minkatt2);

       }
       public void Run()
       {
           foreach(Dog minhund in dogs)
           {
               minhund.Act();
           }
           foreach(Cat minkatt in cats)
           {
               minkatt.Act();
           }
       }

       


    }
}