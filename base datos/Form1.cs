using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace base_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexionPostgreSQL conectandose = new ConexionPostgreSQL();


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dataGridView1.DataSource = conectandose.Consultar();

        }

        private void button4_Click(object sender, EventArgs e)
        {  
            conectandose.Desconectar();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar(textBox4.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectandose.Insertar(textBox1.Text, textBox2.Text, textBox3.Text);
            //actualiza el DataGidView
            dataGridView1.DataSource = conectandose.Consultar();
            //limpia los campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //se envian los datos por parametro
            conectandose.Eliminar(textBox4.Text);
            //actualiza el DataGidView
            dataGridView1.DataSource = conectandose.Consultar();
            //limpia los campos
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conectandose.Actualizar (textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text);
            //actualiza el DataGidView
            dataGridView1.DataSource = conectandose.Consultar();
            //limpia los campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dire;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dire = saveFileDialog1.FileName;
            }
            else dire = "";

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(dire, FileMode.Create));
            doc.Open();
            Paragraph parrafo = new Paragraph("Esta es una linea usando Paragraph.\n hi hello ");

            doc.Add(parrafo);
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            for (int i=0; i<dataGridView1.ColumnCount; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
            }
            //Flag la primer fila es encabezado
            table.HeaderRows = 1;
            //agregar las filas actuales del el datagridview a la tabla
            for (int i = 0;i<dataGridView1.Rows.Count;i++)
            {
                for (int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    if (dataGridView1[j,i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j,i].Value.ToString()));
                    }
                }
            }
            
            doc.Add(table);
            doc.Close();
            MessageBox.Show("Archivo Creado");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
