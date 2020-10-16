 using System;
  namespace animal
  {
      class Animal
      {
          protected int age;
          protected String sound;

          public Animal()
          {
              age = 1;
              sound = "hej hej";
          }

          public void Act() 
          { 
              Console.WriteLine(sound);
          }
      
      }

  }    