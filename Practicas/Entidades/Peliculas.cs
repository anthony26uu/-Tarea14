using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Practicas.Entidades
{
  public  class Peliculas
    {
        [Key]

        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public DateTime PeliculaEstreno { get; set; }
        public int ActorId { get; set; }



        public virtual List<Actores> actores { get; set; }

        public Peliculas()
        {
            this.actores = new List<Actores>();
        }

        public Peliculas(int peliculaId,string nombre, DateTime peliculaEstreno, string actor, int actorId)

        {
         
            this.PeliculaId = peliculaId;
            this.Nombre = nombre;
            this.PeliculaEstreno = PeliculaEstreno;
           

        }
    }
}
