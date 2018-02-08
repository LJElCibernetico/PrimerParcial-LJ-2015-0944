using PrimerParcial_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PrimerParcial_2015_0944.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Nota { get; set; }
        public DbSet<NotasDeCredito> NC { get; set; }

        public Contexto() : base("ConStr")
        {

        }
        
    }
}
