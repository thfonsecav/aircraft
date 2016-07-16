using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aircraft.Models
{
    public class Reservacion
    {
        public string ReservacionID { get; set; }

        public virtual Vuelo VueloId { get; set; }
        public virtual Usuario UsuarioId { get; set; }
    }
}
