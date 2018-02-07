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
        int notaID;
        DateTime fecha;
        int estudianteID;
        String observacion;
        int montoAsignaturas;
        int pctBeca;
        int monto;

        public NotasDeCredito(int notaID, DateTime fecha, int estudianteID, string observacion, int montoAsignaturas, int pctBeca, int monto)
        {
            this.notaID = notaID;
            this.fecha = fecha;
            this.estudianteID = estudianteID;
            this.observacion = observacion;
            this.montoAsignaturas = montoAsignaturas;
            this.pctBeca = pctBeca;
            this.monto = monto;
        }

        public NotasDeCredito()
        {
            this.notaID = 0;
            this.fecha = DateTime.Now;
            this.estudianteID = 0;
            this.observacion = String.Empty;
            this.montoAsignaturas = 0;
            this.pctBeca = 0;
            this.monto = 0;
        }
    }
}
