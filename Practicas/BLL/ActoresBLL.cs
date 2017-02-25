using Practicas.DAL;
using Practicas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Practicas.BLL
{
   public class ActoresBLL
    {

       

       public static bool Guardar(Entidades.Actores actor)
        {
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    db.actor.Add(actor);
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
        public static bool Eliminar(Entidades.Actores actor)
        {
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    db.Entry(actor).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Entidades.Actores Buscar(int id)
        {
            Entidades.Actores buscar = new Entidades.Actores();
            using (var db = new DAL.DetalleDb())
            {
                try
                {
                    buscar = db.actor.Find(id);
                 
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return buscar;
        }
        public static List<Entidades.Actores> GetList()
        {
            using (var Conec = new DAL.DetalleDb())
            {
                try
                {
                    return Conec.actor.ToList();
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
