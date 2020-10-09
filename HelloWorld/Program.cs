using System;

  class Program
  {
      static void Main(string[] args)
      {
         //Uppgift_1A();

         //Uppgift_1B();

         //Uppgift_1C();

         //Uppgift_1D();

         //Uppgift_2A();

         //Uppgift_2B();

         //Uppgift_3A();

         //Uppgift_3B();

         //Uppgift_3C();

         //Uppgift_4A();

         //Uppgift_4B();

         //Uppgift_4C();

         //Uppgift_5A();

         //Uppgift_6A();

         //UppGift_7A();

         //Uppgift_8A();

         //Uppgift_8B();

         //Uppgift_9A();

         //Uppgift_9B1();

         //Uppgigt_9B2();

         //Uppgift_9B3();

         Uppgift_10();

         





            

           


         



        

          
      }

      static void Uppgift_1A()
      {
         Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine(" Varmt Välkommen " + namn + "!");
            Console.WriteLine();
      }

      static void Uppgift_1B()
      {
             double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd / 2;
            Console.WriteLine("triangel");
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
      }
      static void Uppgift_1C()
      {
     

          Console.WriteLine("bredd?");
            String bredd = Console.ReadLine();
          Console.WriteLine("höjd?");
            String höjd = Console.ReadLine();
          double area;
          double decimaltal1 = Convert.ToDouble(bredd);
          double decimaltal2 = Convert.ToDouble(höjd);
          area = decimaltal1 * decimaltal2 / 2;
          Console.WriteLine("triangelns area är" + area);
      }
      static void Uppgift_1D()
      {
          Console.WriteLine("första talet?");
            String tal1 = Console.ReadLine();
          Console.WriteLine("andra talet?");
            String tal2 = Console.ReadLine();
            int tal3 = Convert.ToInt32(tal1);
            int tal4 = Convert.ToInt32(tal2);
            int summa;
            summa = tal3 + tal4;
            Console.WriteLine("summan är " + summa);
 
      }

      static void Uppgift_2A()
      {
          Console.WriteLine("gissa mitt favorit nummer");
         string tal = Console.ReadLine();
         int tal1 = Convert.ToInt32(tal);

        if (tal1 == 3)
        {
            Console.WriteLine("det var rätt");
        }
        else
        {
            Console.WriteLine("det var fel");
        }

      }
      static void Uppgift_2B()
      {

         Random randomGenerator = new Random();
         Random randomGenerator1 = new Random();

         Console.WriteLine("om tärningarna visar lika så vinner du");

         int antalTärningsögon = randomGenerator.Next(1, 7);
         Console.WriteLine(antalTärningsögon);
         int antalTärningsögon1 = randomGenerator1.Next(1, 7);
         Console.WriteLine(antalTärningsögon1);

         if (antalTärningsögon == antalTärningsögon1)
         {
             Console.WriteLine("du vann");
         }
         else
         {
             Console.WriteLine("förlust");

         }

         }
         static void Uppgift_3A()

         {
             int räknare = 1;
            while (räknare < 6)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 1;
            }
            Console.WriteLine();
         }
          static void Uppgift_3B()
         {
             int räknare = 5;
            while (räknare < 23)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 3;
            }
            Console.WriteLine();
         }
         static void Uppgift_3C()
         {

         int räknare = 10;
            while (räknare > -1)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare - 1;
            }
            


         }
         static void Uppgift_4A()

         {
             for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine("" + i);
            }
         }
         static void Uppgift_4B()

         {
             for (int i = 5; i < 23; i = i + 3)
            {
                Console.WriteLine("" + i);
            }
         }
         static void Uppgift_4C()

         {
             for (int i = 10; i > -1; i = i - 1)
            {
                Console.WriteLine("" + i);
            }
         }
         static void Uppgift_5A()
         {
               String input = "13";
         while (!input.Equals("15"))
         {
             Console.WriteLine("gissa numret");
             input = Console.ReadLine();
         }
         Console.WriteLine("rätt");
         Console.WriteLine();
         }
         static void Uppgift_6A()
         {
             Random rnd = new Random();
             int kast1 = rnd.Next(1, 7);
             int kast2 = rnd.Next(1, 7);
             Console.WriteLine(kast1 + " " + kast2);
              if (kast1 * kast2 == 36)
              Console.WriteLine("stor vinst");
              else
              if (kast1 == kast2)
              Console.WriteLine("liten vinst");
              else
              Console.WriteLine("förlust");

         }
         static void Uppgift_7A()
         {
             int[] tal = new int[6];
             tal[0] = 3;
             tal[1] = 5;
             tal[2] = 7;
             tal[3] = 9;
             tal[4] = 11;
             tal[5] = 13;
         }
         static void Uppgift_8A()
         {
              int[] tal = new int[6];
             tal[0] = 3;
             tal[1] = 5;
             tal[2] = 7;
             tal[3] = 9;
             tal[4] = 11;
             tal[5] = 13;

             Console.WriteLine(tal[1]);
             Console.WriteLine(tal[2]);
             Console.WriteLine(tal[3]);
             Console.WriteLine(tal[4]);
             Console.WriteLine(tal[5]);
         
         }
         static void Uppgift_8B()
         {
             int[] tal = new int[6];
             tal[0] = 3;
             tal[1] = 5;
             tal[2] = 7;
             tal[3] = 9;
             tal[4] = 11;
             tal[5] = 13;
             for (int runs = 0; runs < 6; runs++ )
             {
                 tal[runs] = tal[runs] + 1;
             }
             Console.WriteLine(tal[1]);
             Console.WriteLine(tal[2]);
             Console.WriteLine(tal[3]);
             Console.WriteLine(tal[4]);
             Console.WriteLine(tal[5]);
         


         }
        static void Uppgift_9A()
        {
            Console.WriteLine("Välkomen Agent X. ditt uppdrag är . . .");

        }
        static void Uppgift_9B1()
        {
            string tal1String;
            Console.WriteLine("Första numret: ");
            tal1String = Console.ReadLine();

             string tal2String;
            Console.WriteLine("andra numret: ");
            tal2String = Console.ReadLine();

            int tal1 = Convert.ToInt32(tal1String);
            int tal2 = Convert.ToInt32(tal2String);

            int summa = (tal1 + tal2);

            Console.WriteLine(tal1String + "+" + tal2String + "=" + summa);


            

        }
        static void Uppgift_9B2()
        {
            int tal1 = 0;
            int tal2 = 0;
            int tal3 = 0;

            string tal1String;
            Console.Write("Första nummret: ");
            tal1String = Console.ReadLine();

            string tal2String;
            Console.Write("Andra nummret: ");
            tal2String = Console.ReadLine();

            int summa = (tal1 + tal2 + tal3);

            tal1 = Convert.ToInt32(tal1String);
            tal2 = Convert.ToInt32(tal2String);
            Console.WriteLine(tal1String + "+" + tal2String + "=" + summa);
        }
        static void Uppgift_9B3()
        {
            string tal1String;
            Console.Write("Första nummret: ");
            tal1String = Console.ReadLine();

            string tal2String;
            Console.Write("Andra nummret: ");
            tal2String = Console.ReadLine();

            string tal3String;
            Console.Write("Andra nummret: ");
            tal3String = Console.ReadLine();

            int tal1 = Convert.ToInt32(tal1String);
            int tal2 = Convert.ToInt32(tal2String);
            int tal3 = Convert.ToInt32(tal3String);
            int summa = (tal1 + tal2 + tal3);
            Console.WriteLine(tal1String + "+" + tal2String + "+" + tal3String + "=" + summa);
        }
        static void Uppgift_10()
        {
            string[] produkter = new string[20];
            int svar;
            int antal = 0;
            Console.WriteLine("shopping lista");
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("\n1. lägg till produkt\n2. skriva ut lista");
                svar = Convert.ToInt32(Console.ReadLine());
                if (svar == 1)
                {
                    Console.WriteLine("en produkt");
                    string mat = Console.ReadLine();
                    produkter[antal] = mat;
                    antal = antal + 1;
                }
                else if (svar == 2)
                {
                   foreach(string talet in produkter) 
                
                    {
                        Console.Write(talet + " ");

                    }
                }
                else if(svar == 3)
                {
                    isRunning = false;

                }
            Console.WriteLine();
            

            
            }

        }

         



  }