using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aircraft.Models
{
    public class Aerolinea
    {
        public int AerolineaID { get; set; }
        public string Nombre { get; set; }


        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Avion> Aviones { get; set; }
    }
}
