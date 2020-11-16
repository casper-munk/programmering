
using System;
using System.Collections.Generic;

namespace Interface1
{

 class Databas
{
    List<Shape3D> databas;
    public Databas()
    {
        databas = new List<Shape3D>();
        Sphere spheres = new Sphere(3);
        databas.Add(spheres);
        Cube cubes = new Cube(4);
        databas.Add(cubes);
        Cylinder cylinders = new Cylinder(3, 4);
        databas.Add(cylinders);
    }

        public override string ToString()
        {
            String text = " ";
            
        
          foreach(Shape3D shapes in databas )
          {
              text = text + shapes.ToString(); 
          }
          return text;
   

        


    
    }

}

}


