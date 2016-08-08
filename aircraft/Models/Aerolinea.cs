using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Aircraft.Models
{
    public class Aerolinea
    {
        public int AerolineaID { get; set; }
        public string Nombre { get; set; }


        public virtual ICollection<User> Usuarios { get; set; }
        public virtual ICollection<Avion> Aviones { get; set; }
    }
}
