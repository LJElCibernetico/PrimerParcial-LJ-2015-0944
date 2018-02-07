using PrimerParcial_2015_0944.DAL;
using PrimerParcial_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrimerParcial_2015_0944.BLL
{
    public class NotasDeCreditoBLL
    {
        public static bool Guardar(NotasDeCredito id)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Nota.Add(id);
                contex.SaveChanges();

                paso = true;
            }

            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(NotasDeCredito id)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(id).State = EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static List<NotasDeCredito> GetList(Expression<Func<NotasDeCredito, bool>> criterioBusqueda)
        {
            List<NotasDeCredito> t = new List<NotasDeCredito>();
            try
            {
                Contexto contex = new Contexto();
                t = contex.Nota.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return t;
        }
    }
}
