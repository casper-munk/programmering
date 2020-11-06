using System;
using System.Collections.Generic;

namespace Interface1
{
    class Cube 
    {
         protected double length;
        public Cube(double length1)
        {
            length = length1;
          

        }

        public double GetArea()
        {
            return length * length * 6;
        }
        public double GetVolume()
        {
            return length * length * length;
        }

       
    }
}
