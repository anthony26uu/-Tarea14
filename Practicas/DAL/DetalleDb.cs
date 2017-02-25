using Practicas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Practicas.DAL
{
  public class DetalleDb : DbContext
{

    public DetalleDb() : base("ConStr")
    {

    }
    public DbSet<Actores> actor { get; set; }
    public DbSet<Peliculas> pelicula { get; set; }
    
   protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Actores>()
                .HasMany (actor=> actor.pelicula)
                .WithMany(pelicula => pelicula.actores)
                .Map(PeliculaActores =>
                {
                    PeliculaActores.MapLeftKey("PeliculaId");
                    PeliculaActores.MapRightKey("ActorId"); 
                    PeliculaActores.ToTable("PeliculasActores");
                }
               
                );


        }


    }
}

