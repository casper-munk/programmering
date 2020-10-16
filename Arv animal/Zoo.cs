using System;
using System.Collections.Generic;
namespace animal
{
    class Zoo
    {
       List<Animal> djur;
        
       public Zoo()
       {
         djur = new List<Animal>();
         Dog minhund = new Dog(4);
         djur.Add(minhund);
         Dog minhund1 = new Dog(3);
         djur.Add(minhund1);
         Dog minhund2 = new Dog(2);
         djur.Add(minhund2);

         Cat minkatt = new Cat(3);
         djur.Add(minkatt);
         Cat minkatt1 = new Cat(5);
         djur.Add(minkatt1);
         Cat minkatt2 = new Cat(2);
         djur.Add(minkatt2);

         Cow minko = new Cow(3);
         djur.Add(minko);
         Cow minko1 = new Cow(5);
         djur.Add(minko1);
         Cow minko2 = new Cow(2);
         djur.Add(minko2);

       }
       public void Run()
       {
           foreach(Animal animal in djur)
           {
               animal.Act();
           }
           
       }

       


    }
}