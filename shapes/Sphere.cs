using System;
using System.Collections.Generic;

namespace Interface1
{
    class Sphere : Shape3D
    {
        protected double radius;
        public Sphere(double radius1)
        {
            radius = radius1;
          

        }

        public double GetArea()
        {
            return 4 * Math.PI * radius * radius;
        }
        public double GetVolume()
        {
            return 4 * Math.PI * radius * radius * radius / 3;
        }
        public override string ToString()
        {
            return "Sphere: " +Environment.NewLine + "radius=" +radius + Environment.NewLine + "Volume=" +GetVolume() + Environment.NewLine + "Area=" +GetArea() + Environment.NewLine;
         }



       
    }
}
