using System;
using System.Collections.Generic;

namespace Interface1
{
    class Cylinder
    {

            protected double radius;
             protected double height;
           
        public Cylinder(double radius1, double height1)
        {
            radius = radius1;
            height = height1;
          

        }

        public double GetArea()
        {
            return Math.PI * radius * radius * height;
        }
        public double GetVolume()
        {
            return 2 * Math.PI * radius * height;
        }
        
    }
}
