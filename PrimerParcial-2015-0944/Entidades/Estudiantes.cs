using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial_2015_0944.Entidades
{
    public class Estudiantes
    {
        public int estudianteID { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string matricula { get; set; }

        public Estudiantes(int estudianteID, string nombres, string apellidos, string matricula)
        {
            this.estudianteID = estudianteID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.matricula = matricula;
        }

        public Estudiantes()
        {
            this.estudianteID = 0;
            this.nombres = String.Empty;
            this.apellidos = String.Empty;
            this.matricula = String.Empty;
        }
    }
}
