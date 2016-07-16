using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aircraft.Models
{
    public class Puesto
    {
        public int PuestoID { get; set; }
        public Boolean estado { get; set; } //true ocupado false disponible
        public virtual Vuelo VueloId { get; set; }
        public virtual Usuario UsuarioId { get; set; }
    }
}