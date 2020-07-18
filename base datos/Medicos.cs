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

        private String comilla_simple(String xcadena)
        {
            return "'" + xcadena + "'";
        }
        private void muestra()
        {
            string q = "select * from medicos";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena += "insert into persona values ( ";
            cadena += comilla_simple(tb_dni.Text) + ",";
            cadena += comilla_simple(tb_nombre.Text) + ",";
            cadena += comilla_simple(tb_apellido.Text) + ",";
            cadena += comilla_simple(tb_tel.Text) + ",";
            cadena += comilla_simple(tb_dire.Text) + ",";
            cadena += comilla_simple(tb_email.Text) + ")";
            conectandose.Insertar(cadena);
            cadena = "";            
            cadena += "insert into medico values ( ";
            cadena += comilla_simple(tb_dni.Text) + ",";
            cadena += comilla_simple(tb_matricula.Text) + ")";
            conectandose.Insertar(cadena);
            muestra();
            tb_dni.Text = "";
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_tel.Text = "";
            tb_dire.Text = "";
            tb_email.Text = "";
            tb_matricula.Text = "";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String cadena = "delete from persona where dni = " + "'" + codigo + "'";
            DialogResult dr = MessageBox.Show(this, "Elimina Medico  \nD.N.I = " + codigo + " ?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                conectandose.Consultar(cadena);
            }
            muestra();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            DataTable xLista = null;
            bt_aceptar.Visible = true;
            String codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String cadena = "select * from persona where dni = " + "'" + codigo + "'";
            xLista = conectandose.Consultar(cadena);
            tb_dni.ReadOnly = true;
            DataRow fila = xLista.Rows[0];
            tb_dni.Text = fila.ItemArray[0].ToString();
            tb_nombre.Text = fila.ItemArray[1].ToString();
            tb_apellido.Text = fila.ItemArray[2].ToString();
            tb_tel.Text = fila.ItemArray[3].ToString();
            tb_dire.Text = fila.ItemArray[4].ToString();
            tb_email.Text = fila.ItemArray[5].ToString();

            cadena = "select * from medico where dnim = " + "'" + codigo + "'";
            xLista = conectandose.Consultar(cadena);
            fila = xLista.Rows[0];
            tb_matricula.Text = fila.ItemArray[1].ToString();
            //muestra();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena += "update persona set ";
            cadena += "nombre = " + comilla_simple(tb_nombre.Text) + ",";
            cadena += "apellido = " + comilla_simple(tb_apellido.Text) + ",";
            cadena += "tel = " + comilla_simple(tb_tel.Text) + ",";
            cadena += "dire = " + comilla_simple(tb_dire.Text) + ",";
            cadena += "email = " + comilla_simple(tb_email.Text);
            cadena += " where dni = " + comilla_simple(tb_dni.Text);
            conectandose.Consultar(cadena);
            cadena = "";
            cadena += "update medico set ";
            cadena += "matricula = " + comilla_simple(tb_matricula.Text);    
            cadena += " where dnim = " + comilla_simple(tb_dni.Text);
            conectandose.Consultar(cadena);


            muestra();
            tb_dni.ReadOnly = false;
            tb_dni.Text = "";
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_tel.Text = "";
            tb_dire.Text = "";
            tb_email.Text = "";
            tb_matricula.Text = "";
            bt_aceptar.Visible = false;
        }
    }
}
