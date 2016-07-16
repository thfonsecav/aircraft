using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aircraft.Models
{
    public class Aeropuerto
    {
        public int AeropuertoID { get; set; }
        public string Nombre { get; set; }

        public virtual Pais PaisCodigo { get; set; }
        public virtual ICollection<Vuelo> Vuelos { get; set; }
        public virtual ICollection<Aerolinea> Aerolineas { get; set; }

    }
}
