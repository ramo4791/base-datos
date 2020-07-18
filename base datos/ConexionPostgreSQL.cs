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
        //Objeto para la conexion
        //private static NpgsqlConnection conexion = new NpgsqlConnection();
        //#region conexion y desconexion
        //public Boolean conectar()
        //{
        //    conexion.ConnectionString = "Server = localhost; User Id = postgres; " +
        //    "Password = amarillo; Database = clinica";
        //    Boolean bestado = true;
        //    try
        //    {   //abrimos conexion
        //        conexion.Open();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return bestado;
        //}
        //public void desconectar()
        //{
        //    try
        //    {
        //        if (conexion.State == System.Data.ConnectionState.Open)
        //        {   //cerrar
        //            conexion = null;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //#endregion
        //#region consulta de datos
        //public DataTable consultar_datos(String cSql)
        //{
        //    DataTable lista = new DataTable();
        //    try
        //    {
        //        NpgsqlCommand comando = new NpgsqlCommand(cSql,conexion);
        //        NpgsqlDataAdapter respuesta = new NpgsqlDataAdapter(comando);
        //        respuesta.Fill(lista);
        //    }
        //    catch (Exception)
        //    {
        //        atrapa_errores(cSql);
        //        throw;
        //    }
        //    return lista;

        //}
        //public DataSet consultar_datos_carga_gria(String cSql)
        //{
        //    DataSet dts = new DataSet();
        //    try
        //    {
        //        NpgsqlCommand comando = new NpgsqlCommand(cSql, conexion);
        //        NpgsqlDataAdapter respuesta = new NpgsqlDataAdapter(comando);
        //        respuesta.Fill(dts);
        //    }
        //    catch (Exception)
        //    {
        //        atrapa_errores(cSql);
        //        throw;
        //    }
        //    return dts;
        //}
        //#endregion
        //#region ejecucion de consultas
        //public Boolean ejecutar (String cSql)
        //{
        //    Boolean bestado = true;
        //    try
        //    {
        //        NpgsqlCommand comando = new NpgsqlCommand(cSql, conexion);
        //        comando.ExecuteScalar();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return bestado;
        //}
        //#endregion
        //#region util
        //private void atrapa_errores(String cSql)
        //{   //atrapa la consulta
        //    System.Windows.Forms.Clipboard.SetText(cSql);
        //}
        //#endregion

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; " +
            "Password = amarillo; Database = clinica");

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

        public DataTable Consultar (string query)
        {
            //string query = "select * from pacientes";
            conn.Open();
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            conn.Close();
            return tabla;
        }

        //public DataTable Consultar (string nom)
        //{
        //    string query = "select * from depo where clase = '"+nom+"'";
        //    NpgsqlCommand conector = new NpgsqlCommand(query, conn);
        //    NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
        //    DataTable tabla = new DataTable();
        //    datos.Fill(tabla);
        //    return tabla;
        //}

        public void Insertar (string query)
        {
            //string query = "insert into depo values ('"+codd+"','"+nomd+ "','"+clase+"') ";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            //MessageBox.Show("Hecho!");
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
            //MessageBox.Show("Registro Actualizado!");
            conn.Close();
           
        }

    }
}
