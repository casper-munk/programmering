using System;
using System.Collections.Generic;

namespace Interface1
{

 class Databas
{
    List<Shape> databas;
    public Databas()
    {
        databas = new List<Shape>();
        Sphere spheres = new Sphere(3);
        databas.Add(spheres);
    }

}

}


