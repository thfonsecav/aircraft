using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aircraft.Models
{
    public class Avion
    {
        public int AvionID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Puesto> Puestos { get; set; }
        public virtual ICollection<Vuelo> Vuelos { get; set; }

    }
}
