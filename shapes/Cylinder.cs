using System;
using System.Collections.Generic;

namespace Interface1
{
    class Cylinder : Shape3D
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
         public override string ToString()
        {
            return "Cylinder: " +Environment.NewLine + "radius=" +radius + Environment.NewLine + "height=" +height +Environment.NewLine + "Volume=" +GetVolume() + Environment.NewLine + "Area=" +GetArea()+ Environment.NewLine ;
         }
        
    }
}
