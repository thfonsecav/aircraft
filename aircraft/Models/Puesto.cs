using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Aircraft.Models
{
    public class Puesto
    {
        public int PuestoID { get; set; }
        public string Posicion { get; set; }
        public bool Ventana { get; set; }
        public Boolean estado { get; set; } //true ocupado false disponible
        public virtual Vuelo VueloId { get; set; }
        public virtual User UsuarioId { get; set; }
    }
}