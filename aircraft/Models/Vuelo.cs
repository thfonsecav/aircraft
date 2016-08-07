using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aircraft.Models
{
    public class Vuelo
    {
        public int VueloID { get; set; }
        public string Nombre { get; set; }
        public string HoraSalida { get; set; }
        public string HoraLlegada { get; set; }
        public string Destino { get; set; }
        public string FechaLlegada { get; set; }
        public string FechaSalida { get; set; }
        public virtual Avion AvionID { get; set; }
        public virtual ICollection<Reservacion> Reservaciones { get; set; }
    }
}
