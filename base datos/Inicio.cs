using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_datos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void butt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes v_p = new Pacientes();
            this.Hide();
            v_p.ShowDialog();
            this.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos v_m = new Medicos();
            this.Hide();
            v_m.ShowDialog();
            this.Show();
        }

        private void enfermedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enfermedades v_e = new Enfermedades();
            this.Hide();
            v_e.ShowDialog();
            this.Show();
        }

        private void padeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Padece v_padece = new Padece();
            this.Hide();
            v_padece.ShowDialog();
            this.Show();
        }
    }
}
