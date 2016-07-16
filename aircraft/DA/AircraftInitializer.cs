using Aircraft.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aircraft.DA
{
    public class AircraftInitializer : DropCreateDatabaseIfModelChanges<AircraftContext>
    {
        protected override void Seed(AircraftContext context)
        {
            var Pais1 = new Pais { PaisID = 001, Nombre = "Costa Rica" };
            var Pais2 = new Pais { PaisID = 002, Nombre = "Nicaragua" };
            var Pais3 = new Pais { PaisID = 003, Nombre = "Panama" };
            var Pais4 = new Pais { PaisID = 004, Nombre = "Colombia" };
            var Pais5 = new Pais { PaisID = 005, Nombre = "Mexico" };

            var paises = new List<Pais>
            {
                 new Pais { PaisID = 006, Nombre = "Venezuela"},
                 new Pais { PaisID = 007, Nombre = "Peru"},
                 new Pais { PaisID = 008, Nombre = "Bolivia"},

            };
            context.Pais.Add(Pais1);
            context.Pais.Add(Pais2);
            context.Pais.Add(Pais3);
            context.Pais.Add(Pais4);
            context.Pais.Add(Pais5);
            paises.ForEach(pais => context.Pais.Add(pais));

            var aeropuertos = new List<Aeropuerto> {
                new Aeropuerto { AeropuertoID = 01, Nombre = " Aeropuerto Internacional Juan Santa Maria", PaisCodigo=001},
                new Aeropuerto { AeropuertoID = 02, Nombre = "Aeropuerto Internacional Daniel Oduber", PaisCodigo=001},
                new Aeropuerto { AeropuertoID = 03, Nombre = "Aeropuerto Internacional de Limon", PaisCodigo=001},
            };
            aeropuertos.ForEach(Aeropuerto => context.Aeropuerto.Add(Aeropuerto));



            context.SaveChanges();
        }
    }

}
