using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace base_datos
{
    class ConexionPostgreSQL
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; " +
            "Password = amarillo; Database = Caso1-Deportes");
            //"Password = amarillo; Database = clinica");

        public void Conectar()
        {

            conn.Open();

            MessageBox.Show("Listo");
        }
        public void Desconectar ()
        {
            conn.Close();
            MessageBox.Show("Cerrado");
        }

        public DataTable Consultar ()
        {
            string query = "select * from depo";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable Consultar (string nom)
        {
            string query = "select * from depo where clase = '"+nom+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public void Insertar (string codd,string nomd,string clase)
        {
            string query = "insert into depo values ('"+codd+"','"+nomd+ "','"+clase+"') ";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");
            conn.Close();
        }

        public void Eliminar(string n)
        {
            string query = "delete from depo where nomd = '" + n + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("El registro a sido eliminado...");
            conn.Close();
        }

        public void Actualizar (string codd, string nomd, string clase,string n)
        {
            string query = "update depo set codd = '"+ codd + "',nomd='" + nomd + "', clase = '" + clase +"' where nomd ='"+n+"'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado!");
            conn.Close();
           
        }

    }
}
