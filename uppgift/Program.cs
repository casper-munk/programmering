using System;
using System.Collections.Generic;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
               List<QuestionCard>cards;
           cards = new List<QuestionCard>();
           QuestionCard card;
           card = new QuestionCard("vad heter norges huvudstad?", "oslo");
           cards.Add(card);
           card = new QuestionCard("vad heter danmarks huvudstad?", "köpenhamn");
           cards.Add(card);
           card = new QuestionCard("vad heter finlands huvudstad?", "helsingfors");
           cards.Add(card);

           foreach( QuestionCard mycard in cards)
           {
             string answer;
              Console.WriteLine(mycard.GetQuestion());
             answer = Console.ReadLine();
             if (mycard.IsCorrect(answer))
             {
                 Console.WriteLine("det var rätt");
             }
             else
             {
                 Console.WriteLine("det var fel");
             }

           }
          


        

        }
        /*static void uppgiften()
        {
             List<QuestionCard>cards;
           cards = new List<QuestionCard>();
           QuestionCard card;
           card = new QuestionCard();
           card.question = "vad heter norges huvudstad?";
           card.answer = "oslo";
           cards.Add(card);
           card = new QuestionCard();
           card.question = "vad heter danmarks huvudstad?";
           card.answer = "köpenhamn";
           cards.Add(card);
           card = new QuestionCard();
           card.question = "vad heter finlands huvudstad?";
           card.answer = "helsingfors";
           cards.Add(card);

           foreach( QuestionCard mycard in cards)
           {
             string answer;
             Console.WriteLine(mycard.question);
             answer = Console.ReadLine();
             if (answer == mycard.answer)
             {
                 Console.WriteLine("det var rätt");
             }
             else
             {
                 Console.WriteLine("det var fel");
             }

           }
        }
        */
        
        static void listauppgift()
        {
                       List<string>minLista;
           minLista = new List<string>();
           minLista.Add("vad heter norges huvudstad?");
           minLista.Add("vad heter danmarks huvudstad?");
           minLista.Add("vad heter finlands huvudstad?");

           List<string>minLista1;
           minLista1 = new List<string>();
           minLista1.Add("oslo");
           minLista1.Add("köpenhamn");
           minLista1.Add("helsingfors");

           for(int i = 0; i < 3; i = i + 1)
           {
                string answer;
                Console.WriteLine(minLista[i]);
                answer = Console.ReadLine();
            if (answer == minLista1[i])
            {
                Console.WriteLine("det var rätt");
            }
            else
                {
                    Console.WriteLine("Det var fel");
                }
           }

        }
        
        static void arraystest()
        {
            string[] frågor = new string[3];
           frågor[0] = "vad heter norges huvudstad?";
           frågor[1] = "vad heter danmarks huvudstad?";
           frågor[2] = "vad heter finlands huvudstad?";

           string[] svar = new string[3];
           svar[0] = "oslo";
           svar[1] = "köpenhamn";
           svar[2] = "helsingfors";

           for(int i = 0; i < 3; i = i + 1)
           {
                string answer;
                Console.WriteLine(frågor[i]);
                answer = Console.ReadLine();
            if (answer == svar[i])
            {
                Console.WriteLine("det var rätt");
            }
            else
                {
                    Console.WriteLine("Det var fel");
                }
           }
        }

        static void testmetod()
        {
            string answer;
            Console.WriteLine("vad heter norges huvudstad?");
            answer = Console.ReadLine();
        if (answer == "oslo")
        {
            Console.WriteLine("det var rätt");
        }
          else
            {
                Console.WriteLine("Det var fel");
            }

            string answer3;
            Console.WriteLine("vad heter danmarks huvudstad?");
            answer3 = Console.ReadLine();
        if (answer3 == "köpenhamn")
        {
            Console.WriteLine("det var rätt");
        }
          else
            {
                Console.WriteLine("Det var fel");
            }
             string answer2;
            Console.WriteLine("vad heter finlands huvudstad?");
            answer2 = Console.ReadLine();
        if (answer2 == "helsingfors")
        {
            Console.WriteLine("det var rätt");
        }
          else
            {
                Console.WriteLine("Det var fel");
            }



        }
   
    }
}