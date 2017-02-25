using Practicas.DAL;
using Practicas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practicas.BLL
{
    public class PeliculaBLL
    {
    


        public static bool Guardar(Entidades.Peliculas pelicula)
        {
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    db.pelicula.Add(pelicula);

                    foreach (var cat in pelicula.actores)
                    {
                        db.Entry(cat).State = EntityState.Unchanged;
                    }

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                  
                    throw;
                }
               
            }
            return false;
        }
        public static bool Eliminar(Entidades.Peliculas pelicula)
        {
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    db.Entry(pelicula).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }      
        public static Entidades.Peliculas Buscar (int id)
        {
            Entidades.Peliculas buscar = new Entidades.Peliculas();

            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    buscar = db.pelicula.Find(id);
                    buscar.actores.Count();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return buscar;
        }
        public static List< Entidades.Peliculas> GetList()
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    return db.pelicula.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }
        public static List<Entidades.Peliculas> GetListFecha(DateTime desde, DateTime hasta)
        {
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    return db.pelicula.Where(p => p.PeliculaEstreno >= desde.Date && p.PeliculaEstreno <= hasta.Date).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }



    }
}
