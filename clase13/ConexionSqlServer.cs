using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13
{
    internal class ConexionSQLServer : IConexion
    {
        SqlConnection sesion = new SqlConnection();

        public ConexionSQLServer(string servidor, string bd)
      {
         sesion.ConnectionString = $"Data Source={servidor} ; Integrated Security=SSPI; Initial Catalog={bd}";

      }

        public DataTable ListarResultados (string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.sesion; //SqlConnection
            cmd.CommandText = query; //SP o query
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1000;

            SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
            adaptadorDatos.SelectCommand = cmd;

            DataTable miTabla = new DataTable();
            adaptadorDatos.Fill(miTabla);

            return miTabla;
        }


/*insertar-modificar-eliminar*/
        public int Modificar(string query)
        {
            //SqlCommand admite la consulta y la conexión como argumentos del constructor
            SqlCommand cmd = new SqlCommand();
            sesion.Open();
            //Sesión donde va a ejecutar
            cmd.Connection = sesion; //SqlConnection


            cmd.CommandText = query; //SP o query
            cmd.Connection = sesion;
            //tipo de consulta
            cmd.CommandType = CommandType.Text;
            //tiempo en que si no hay respuesta expira.
            cmd.CommandTimeout = 1000;

            //Muestro la cantidad de filas afectadas por la ejecución de la consulta.
            //La sentencia ExcecuteNonQuery se puede ejecutar y asignar a una variable.
            int total;
            total = cmd.ExecuteNonQuery();

            return total;
        }
    }
}