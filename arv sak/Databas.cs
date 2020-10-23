using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Databas 
    {
        List<Sak> databas;
        public Databas()
        {
          databas = new List<Sak>();
          Cd cds = new Cd("Name: Violator", "Artist: Depenche mode");
          databas.Add(cds);
          Cd cds1 = new Cd(" Name: some great reward", "Artist: depenche mode");
          databas.Add(cds1);

          Dvd dvds = new Dvd(" Name: meme comp 1", "Regissör: meme");
          databas.Add(dvds);
          Dvd dvds1 = new Dvd(" Name: meme comp 2", "Regissör: meme1");
          databas.Add(dvds1);
          Dvd dvds2 = new Dvd(" Name: meme comp 3", "Regissör: meme2");
          databas.Add(dvds2);

          foreach(Sak saken in databas )
          {
            saken.Act();
          }
        }
        

    }
        
}
