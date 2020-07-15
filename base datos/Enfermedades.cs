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
    public partial class Enfermedades : Form
    {
        ConexionPostgreSQL conectandose = new ConexionPostgreSQL();

        public Enfermedades()
        {
            InitializeComponent();
        }
        private String comilla_simple(String xcadena)
        {
            return "'" + xcadena + "'";
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            string q = "select * from enfermedad";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string cadena = "";

            cadena += "insert into enfermedad values ( ";
            cadena += comilla_simple(tb_codigo.Text) + ",";
            cadena += comilla_simple(tb_nombre.Text) + ",";
            cadena += comilla_simple(tb_sistema.Text) + ")";
            conectandose.Insertar(cadena);
            string q = "select * from enfermedad";
            dataGridView1.DataSource = conectandose.Consultar(q);
            tb_codigo.Text = "";
            tb_nombre.Text = "";
            tb_sistema.Text = "";
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            //string tb = "enefermedad";
            //conectandose.Actualizar(text.Text, tb_nombre.Text, tb_sistema.Text, textBox4.Text);
            //actualiza el DataGidView
            //dataGridView1.DataSource = conectandose.Consultar();
            //limpia los campos
            //textBox1.Text = "";
            //tb_nombre.Text = "";
            //tb_sistema.Text = "";
            //textBox4.Text = "";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
