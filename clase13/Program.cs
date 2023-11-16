using System;
using System.Data;
using System.Data.SqlClient;

namespace clase13
{
    class Program
    {
        static void Main(string[] args)
        {

            IConexion conexionSQLServer = new ConexionSQLServer("DESKTOP-K6LIC36\\MSSQLSERVERDOS", "Poo");

//ejercicio 8
            DataTable miTabla = conexionSQLServer.ListarResultados("SELECT  SUM(p.ImporteTotal) as ImporteTotal, SUM(pd.cantidad) as cantidad FROM Pedidos as p INNER JOIN PedidosDetalles as pd ON p.IdPedido = pd.IdPedido GROUP BY p.IdPedido;");

            RegistroPedidos registroPedidos = new RegistroPedidos();
            registroPedidos.AgregarPeidos(miTabla);
            registroPedidos.MostrarPeidods();
            registroPedidos.CantidadPedidos();


            /*
           lo final en clase con el profe

           DataTable miTabla = conexionSQLServer.ListarResultados("SELECT idCliente, nombre, apellidos FROM Clientes");

           List<Cliente> listaClientes = new List<Cliente>();

           foreach (DataRow item in miTabla.Rows)
           {
               Cliente cliente = new Cliente();
               cliente.SetId(int.Parse(item["idCliente"].ToString()));
               cliente.SetNombre(item["nombre"].ToString());
               listaClientes.Add(cliente);
           }

           foreach (Cliente item in listaClientes)
           {
               Console.WriteLine(item.GetNombre());
           }



           List<Cliente> listaFiltrada = listaClientes.Where(x => x.GetId() >= 1).ToList();

           foreach (Cliente item in listaFiltrada)
           {
               Console.WriteLine(item.GetNombre());

           }*/

        }
    }
}

/*
//MODIFICAR
  DataTable miTabla = conexionSQLServer.ListarResultados("SELECT * FROM Pedidos");

int modificar = conexionSQLServer.Modificar("INSERT INTO PRIVILEGIOS VALUES (8,'ANULAR')");
Console.WriteLine(modificar);

*/

/*
 // Crear la conexión
            SqlConnection sesion = new SqlConnection();
            sesion.ConnectionString = "Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";



            try
            {
                // Abrir la conexión
                sesion.Open();

                // Crear el comando y configurarlo
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sesion;
                cmd.CommandText = "SELECT IdCliente, Apellidos, Nombre FROM clientes";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 1000;

                // Crear el adaptador de datos
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
                adaptadorDatos.SelectCommand = cmd;

                // Crear un DataSet y llenarlo con los datos de la consulta
                DataSet datos = new DataSet();
                adaptadorDatos.Fill(datos, "Clientes");

                // También puedes crear un DataTable y llenarlo
                DataTable miTabla = new DataTable();
                adaptadorDatos.Fill(miTabla);

                // Realizar operaciones con los datos, si es necesario

                // Cerrar la conexión
                sesion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        */

/*
                 SqlConnection sesion = new SqlConnection();
  sesion.ConnectionString = "Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";


SqlCommand cmd = new SqlCommand();
cmd.Connection = sesion;

cmd.CommandText = "SELECT IdCliente, Apellidos, Nombre FROM clientes";
cmd.CommandType = CommandType.Text;
cmd.CommandTimeout = 1000;

SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
adaptadorDatos.SelectCommand = cmd;

DataTable miTabla = new DataTable();
adaptadorDatos.Fill(miTabla);

foreach (DataRow item in miTabla.Rows)
{
Console.WriteLine($"ID: {item["IdCliente"]}");
}
*/

/*
SqlConnection sesion = new SqlConnection();
  sesion.ConnectionString = "Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";

     SqlCommand cmd = new SqlCommand();
            cmd.Connection = sesion;
            cmd.CommandText = "SELECT * FROM Pedidos WHERE IdTransportista = @idTransporte";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idTransporte", SqlDbType.Int));
            cmd.Parameters["idTransporte"].Value = 1;

            SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
            adaptadorDatos.SelectCommand = cmd;

            DataTable miTabla = new DataTable();
            adaptadorDatos.Fill(miTabla);

            foreach (DataRow item in miTabla.Rows)
            {
                Console.WriteLine($"ID: {item["IdCliente"]} - IdTransporte: {item["IdTransportista"]}");
            }
*/

/*
 SqlConnection sesion = new SqlConnection();
            sesion.ConnectionString = "Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sesion;
            cmd.CommandText = "SELECT * FROM Pedidos WHERE IdTransportista = @idTransporte";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idTransporte", SqlDbType.Int));
            cmd.Parameters["idTransporte"].Value = 1;

            SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
            adaptadorDatos.SelectCommand = cmd;

            DataTable miTabla = new DataTable();
            adaptadorDatos.Fill(miTabla);

            foreach (DataRow item in miTabla.Rows)
            {
                Console.WriteLine($"ID: {item["IdCliente"]} - IdTransporte: {item["IdTransportista"]}");
            }
*/