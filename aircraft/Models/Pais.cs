using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aircraft.Models
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Aeropuerto> Aereopuerto { get; set; }

        public static implicit operator Pais(int v)
        {
            throw new NotImplementedException();
        }
    }
}
