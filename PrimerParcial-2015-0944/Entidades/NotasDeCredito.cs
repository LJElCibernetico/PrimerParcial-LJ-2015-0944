using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial_2015_0944.Entidades
{
    public class NotasDeCredito
    {
        [Key]
        public int notaID;
        public string fecha;
        public int estudianteID;
        public String observacion;
        public int montoAsignaturas;
        public int pctBeca;
        public int monto;

        public NotasDeCredito(int notaID, string Fecha, int EstudianteID, string observacion, int montoAsignaturas, int pctBeca, int monto)
        {
            this.notaID = notaID;
            this.fecha = Fecha;
            this.estudianteID = EstudianteID;
            this.observacion = observacion;
            this.montoAsignaturas = montoAsignaturas;
            this.pctBeca = pctBeca;
            this.monto = monto;
        }

        public NotasDeCredito()
        {
            this.notaID = 0;
            this.fecha = String.Empty;
            this.estudianteID = 0;
            this.observacion = String.Empty;
            this.montoAsignaturas = 0;
            this.pctBeca = 0;
            this.monto = 0;
        }
    }
}
