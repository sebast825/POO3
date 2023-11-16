using System;
using System.Data.SqlClient;

namespace clase12;
class Program
{
    static void Main(string[] args)

    
    {
        
   
      try{
        ModoConectado modoConectado = new ModoConectado("DESKTOP-K6LIC36\\MSSQLSERVERDOS","Poo");
        //modoConectado.ListarResultados("select  IdCliente, Apellidos from clientes");

        //ejercicio 2
        //modoConectado.ListarResultados("select idPedido,ImporteTotal,CiudadDestino from pedidos");

        //ejercicio3
        modoConectado.ListarResultadosTres("select IdPedido,cast(Cantidad as int),cast(Precio as float) from PedidosDetalles");
      }catch(Exception ex){
        Console.WriteLine($"errorasd: " + ex.Message);
      }

    }


}


/*
  try
        {


            SqlConnection conexion = new SqlConnection();
            //DESKTOP-K6LIC36\MSSQLSERVERDOS
            //conexion.ConnectionString = "Data Source=localhost; User=sa; Password=123456; Initial Catalog=Poo";
            conexion.ConnectionString = "Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS; Integrated Security=SSPI; Initial Catalog=Poo";

            conexion.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandText = "select  IdCliente, Apellidos from clientes";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"El id cliente es: {sqlDataReader.GetInt32(0)} y el apellido es {sqlDataReader.GetString(1)}");
                    Console.WriteLine($"sin saber el dato,El id cliente es: {sqlDataReader[0]} y el apellido es {sqlDataReader[1]}");
                
                }
            }
            conexion.Close();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }*/