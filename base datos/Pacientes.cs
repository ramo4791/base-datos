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
    public partial class Pacientes : Form
    {
        ConexionPostgreSQL conectandose = new ConexionPostgreSQL();

        public Pacientes()
        {
            InitializeComponent();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {

        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            string q = "select * from pacientes";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }
    }
}
