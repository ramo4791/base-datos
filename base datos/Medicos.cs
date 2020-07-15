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
    public partial class Medicos : Form
    {
        ConexionPostgreSQL conectandose = new ConexionPostgreSQL();

        public Medicos()
        {
            InitializeComponent();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            string q = "select * from medicos";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }
    }
}
