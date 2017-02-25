using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Practicas.Entidades
{
  public  class Actores
    {
        [Key]
        public int ActorId { get; set; }
        public string Nombre { get; set; }
    
        public virtual List<Peliculas> pelicula { get; set; }

        public Actores()
        {
            this.pelicula = new List<Peliculas>();
        }


        public Actores(int actorId, string nombre)
        {
            this.ActorId = actorId;
            this.Nombre = nombre;
        }        
        

    }

    
}
