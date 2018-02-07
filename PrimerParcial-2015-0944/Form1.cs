using PrimerParcial_2015_0944.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial_2015_0944
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes re = new rEstudiantes();
            re.Show();
        }

        private void notasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rNotasDeCredito rn = new rNotasDeCredito();
            rn.Show();
        }
    }
}
