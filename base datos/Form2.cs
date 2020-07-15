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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ConexionPostgreSQL conex = new ConexionPostgreSQL();

        private void Form2_Load(object sender, EventArgs e)
        {
            //cbo.DataSource = conex.Consultar();
            //cbo.DisplayMember = "nombre";
            //cbo.ValueMember = "dnip";
            //listBox1.DataSource = conex.Consultar();
            //listBox1.DisplayMember = "apellido";
            //listBox1.ValueMember = "dnip";
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbo.SelectedIndex;
            //label2.Text = cbo.Items[indice].ToString();
            label2.Text = indice.ToString();
            label3.Text = cbo.SelectedValue.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
        }
    }
}
