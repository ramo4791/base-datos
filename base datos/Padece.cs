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
    public partial class Padece : Form
    {
        ConexionPostgreSQL conectandose = new ConexionPostgreSQL();

        public Padece()
        {
            InitializeComponent();
        }
        private String comilla_simple(String xcadena)
        {
            return "'" + xcadena + "'";
        }
        private void muestra()
        {
            string q = "select * from padece";
            dataGridView1.DataSource = conectandose.Consultar(q);
        }
        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Padece_Load(object sender, EventArgs e)
        {
            muestra();
            string q = "select dnip,apellido from pacientes";
            cb_paciente.DataSource = conectandose.Consultar(q);
            cb_paciente.DisplayMember = "dnip";
            cb_paciente.ValueMember = "dnip";
            q = "select code,nome from enfermedad";
            cb_enfermedad.DataSource = conectandose.Consultar(q);
            cb_enfermedad.DisplayMember = "code";
            cb_enfermedad.ValueMember = "code";
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string cadena = "";          
            cadena += "insert into padece values ( ";
            cadena += comilla_simple(cb_enfermedad.SelectedValue.ToString()) + ",";
            cadena += comilla_simple(cb_paciente.SelectedValue.ToString()) + ",";
            cadena += comilla_simple(dt_fechae.Value.ToString()) + ")";
            conectandose.Insertar(cadena);
            muestra();           
            dt_fechae.Value = DateTime.Now;
        }

        private void cb_paciente_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_enfermedad_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            cb_enfermedad.Enabled = false;
            cb_paciente.Enabled = false;
            String code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String dnip = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String fechae = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String cadena = "delete from padece where code = " + comilla_simple(code) + "and " +
                "dnip = " + comilla_simple(dnip) + "and fechae = " +comilla_simple(fechae);
                             
            DialogResult dr = MessageBox.Show("Elimina Padece  \nD.N.I = " + dnip + " ?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                conectandose.Consultar(cadena);
            }
            muestra();
            cb_enfermedad.Enabled = true;
            cb_paciente.Enabled = true;
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime();
            bt_aceptar.Visible = true;
            String code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String dnip = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String fechae = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String cadena = "select * from padece where code = " + comilla_simple(code) + "and " +
                "dnip = " + comilla_simple(dnip) + "and fechae = " + comilla_simple(fechae);           
            fecha = DateTime.Parse(fechae);
            dt_fechae.Value = fecha;
            cb_enfermedad.SelectedValue = code;
            cb_paciente.SelectedValue = dnip;
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            string code = cb_enfermedad.SelectedValue.ToString();
            string dnip = cb_paciente.SelectedValue.ToString();
            string fechae = dt_fechae.Value.ToString();
            String c = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String d = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String f = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string cadena = "";           
            cadena += "update padece set ";
            cadena += "code = " + comilla_simple(code) + ",";
            cadena += "dnip = " + comilla_simple(dnip) + ",";
            cadena += "fechae = " + comilla_simple(fechae);
            cadena += " where code = " +comilla_simple(c) + "and " +
            "dnip = " + comilla_simple(d) + "and fechae = " + comilla_simple(f);
            conectandose.Consultar(cadena);
            muestra();
            
            dt_fechae.Value = DateTime.Now;
            bt_aceptar.Visible = false;
        }
    }
}
