using PrimerParcial_2015_0944.BLL;
using PrimerParcial_2015_0944.DAL;
using PrimerParcial_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial_2015_0944.Registros
{
    public partial class rNotasDeCredito : Form
    {
        public rNotasDeCredito()
        {
            InitializeComponent();
        }

        /*private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            NotasDeCredito nc = new NotasDeCredito();
            if (notaIDtextBox.Text == String.Empty || fechadateTimePicker.Text == String.Empty || estudianteIDtextBox.Text == String.Empty || nombretextBox.Text == String.Empty || montoasignaturasnumericUpDown.Text == String.Empty || porcientobecatextBox.Text == String.Empty )
                mostrarerrorProvider.SetError(notaIDtextBox, "Recuerde No dejar Campos Vacios");
            else
                nc.notaID = 0;
                nc.fecha = fechadateTimePicker.Text;
                nc.estudianteID = int.Parse(estudianteIDtextBox.Text);
                nc.montoAsignaturas = int.Parse(montoasignaturasnumericUpDown.Text);
            if (NotasDeCreditoBLL.Guardar(nc))
                MessageBox.Show("Acaba de Registrar su Nota de Credito");
            else
                MessageBox.Show("No se pudo registrar su Nota de Credito");
        }*/

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            notaIDtextBox.Text = String.Empty;
            estudianteIDtextBox.Text = String.Empty;
            nombretextBox.Text = String.Empty;
            montoasignaturasnumericUpDown.Text = "1";
            porcientobecatextBox.Text = String.Empty;
            montotextBox.Text = String.Empty;
        }

        private void montotextBox_TextChanged(object sender, EventArgs e)
        {
            int n, n1, r;

            n = int.Parse(montoasignaturasnumericUpDown.Text);
            n1 = int.Parse(porcientobecatextBox.Text);
            r = n * n1;
            montotextBox.Text = r.ToString();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int Id = 0;
            Contexto d = new Contexto();

            int.TryParse(notaIDtextBox.Text, out Id);

            var t = d.Nota.Find(Id);

            d.Nota.Remove(t);
            d.SaveChanges();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            int p = 0;
            int.TryParse(notaIDtextBox.Text, out p);

            NotasDeCredito notasDeCredito = new NotasDeCredito();

            notasDeCredito = db.NC.Find(p);
            if (notasDeCredito == null)
            {
                MessageBox.Show("Estudiante No encontado");
            }
            else
            {
                MessageBox.Show("Estudiante Encontado");
                fechadateTimePicker.Text = notasDeCredito.fecha;
                estudianteIDtextBox.Text = notasDeCredito.estudianteID.ToString();
                montoasignaturasnumericUpDown.Text = notasDeCredito.montoAsignaturas.ToString();
                porcientobecatextBox.Text = notasDeCredito.pctBeca.ToString();
                montotextBox.Text = notasDeCredito.monto.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();

            int p = 0;
            int.TryParse(estudianteIDtextBox.Text, out p);

            Estudiantes estudiante = new Estudiantes();

            estudiante = db.Nota.Find(p);
            if (estudiante == null)
            {
                MessageBox.Show("Estudiante No encontado");
            }
            else
            {
                MessageBox.Show("Estudiante Encontado");
                nombretextBox.Text = estudiante.nombres;
            }
        }
    }
}
