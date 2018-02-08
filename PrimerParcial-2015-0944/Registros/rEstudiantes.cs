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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            nombrestextBox.Text = String.Empty;
            estudiantesIDtextBox.Text = String.Empty;
            apellidostextBox.Text = String.Empty;
            matriculatextBox.Text = String.Empty;
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            if (estudiantesIDtextBox.Text == String.Empty || nombrestextBox.Text == String.Empty || apellidostextBox.Text == String.Empty || matriculatextBox.Text == String.Empty)
                mostrarerrorProvider.SetError(estudiantesIDtextBox, "Recuerde No dejar Campos Vacios");
            else
                 estudiante.estudianteID = 0;
                 estudiante.nombres = nombrestextBox.Text;
                 estudiante.apellidos = apellidostextBox.Text;
                 estudiante.matricula = matriculatextBox.Text;
            if (NotasDeCreditoBLL.Guardar(estudiante))
                    MessageBox.Show("Acaba de Registrar su Nota de Credito");
                else
                    MessageBox.Show("No se pudo registrar su Nota de Credito");
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            int Id = 0;
            Contexto d = new Contexto();

            int.TryParse(estudiantesIDtextBox.Text, out Id);

            var t = d.Nota.Find(Id);

            d.Nota.Remove(t);
            d.SaveChanges();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {

            Contexto db = new Contexto();

            int p = 0;
            int.TryParse(estudiantesIDtextBox.Text, out p);

            Estudiantes estudiante = new Estudiantes();

            estudiante = db.Nota.Find(p);
            if (estudiante == null)
            {
                MessageBox.Show("Estudiante No encontado");
            }
            else
            {
                MessageBox.Show("Estudiante Encontado");
                nombrestextBox.Text = estudiante.nombres;
                apellidostextBox.Text = estudiante.apellidos;
                matriculatextBox.Text = estudiante.matricula.ToString();
            }
        }
    }
}
