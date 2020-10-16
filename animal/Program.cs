using System;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat minKatt = new Cat(5);
            minKatt.Act();

            Dog minhund = new Dog(5);
            minhund.Act();

        }
    }
}
