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
        private void muestra ()
        {
            string q = "select * from enfermedad";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            //tb_codigo.ReadOnly = false;
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
            DataTable xLista = null;
            bt_aceptar.Visible = true;
            String codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String cadena = "select * from enfermedad where code = " + "'" + codigo + "'";
            xLista = conectandose.Consultar(cadena);
            tb_codigo.ReadOnly = true;
            DataRow fila = xLista.Rows[0];
            tb_codigo.Text = fila.ItemArray[0].ToString();
            tb_nombre.Text = fila.ItemArray[1].ToString();
            tb_sistema.Text = fila.ItemArray[2].ToString();
            //muestra();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String cadena = "delete from enfermedad where code = " + "'" + codigo + "'";
            DialogResult dr = MessageBox.Show(this,"Elimina enfermedad \nCodigo :" + codigo + " ?","Confirmar",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                conectandose.Consultar(cadena);
            }            
            muestra();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena += "update enfermedad set ";
            cadena += "nome = " + comilla_simple(tb_nombre.Text) + ",";
            cadena += "sistema = " + comilla_simple(tb_sistema.Text);
            cadena += " where code = " + comilla_simple(tb_codigo.Text);
            conectandose.Consultar(cadena);
            muestra();
            tb_codigo.ReadOnly = false;
            tb_codigo.Text = "";
            tb_nombre.Text = "";
            tb_sistema.Text = "";
            bt_aceptar.Visible = false;
            
        }
    }
}
