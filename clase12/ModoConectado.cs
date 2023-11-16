using System.Data.SqlClient;

namespace clase12
{
   internal class ModoConectado
   {
      SqlConnection conexion = new SqlConnection();

      public ModoConectado(string servidor, string bd)
      {
         conexion.ConnectionString = $"Data Source={servidor} ; Integrated Security=SSPI; Initial Catalog={bd}";

      }
//ejercicio2
      public void ListarResultados(string query)
      {
         try
         {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.conexion;
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            ListarPedidos listarPedidos = new ListarPedidos();
            if (sqlDataReader.HasRows)
            {
               while (sqlDataReader.Read())
               {
                  Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
                  listarPedidos.CrearPedido((int)sqlDataReader[0],(double)sqlDataReader[1],(string)sqlDataReader[2]);
               }
            }
                   listarPedidos.GetTotal();
         }
         catch (Exception ex)
         {
            Console.WriteLine("Error " + ex.Message);
         }
         conexion.Close();
  
      }
//ejercicio 3
      public void ListarResultadosTres(string query)
      {
         try
         {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = this.conexion;
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            ListarPedidos listarPedidos = new ListarPedidos();
            if (sqlDataReader.HasRows)
            {
               while (sqlDataReader.Read())
               {
                  //Console.WriteLine($"{sqlDataReader[0]} - {sqlDataReader[1]}");
                  listarPedidos.AgregarDetallePedido((int)sqlDataReader[0],(int)sqlDataReader[1],(double)sqlDataReader[2]);

               }
            }
                   listarPedidos.TotalDetalles();
         }
         catch (Exception ex)
         {
            Console.WriteLine("Error " + ex.Message);
         }
         conexion.Close();
  
      }
   }

   internal class Pedido
   {
      public int  id { get; set; }
      public double precio { get; set; }
      public string destino { get; set; }


   }
   internal class ListarPedidos{
      public  List <Pedido> ListaPedidos {get;set;}
      public List<PedidoDetalle> listaPedidosDetalles {get;set;}
    /*  public ListarPedidos(){
         ListaPedidos = new List <Pedido>();
      }*/
      public void CrearPedido(int id, double precio, string destino){
         ListaPedidos.Add(new Pedido{
            id = id,
            precio = precio,
            destino = destino
         });
      }
       public void AgregarDetallePedido(int id, int cantidad, double precioUnitario){
         if(this.listaPedidosDetalles == null){
            this.listaPedidosDetalles = new List<PedidoDetalle>();
         }
         listaPedidosDetalles.Add(new PedidoDetalle(){
            id = id,
            cantidad = cantidad,
            precioUnitario = precioUnitario
         });
      }

      public void GetTotal(){
         
         Console.WriteLine($"{ListaPedidos.Sum(pedido => pedido.precio)}");
      }
      public void TotalDetalles(){
         double total = listaPedidosDetalles.Sum(pedido => pedido.cantidad * pedido.precioUnitario );
         Console.WriteLine("Total: " + total);
      }
   }

   internal class PedidoDetalle{
      public int  id { get; set; }
      public int cantidad { get; set; }
      public double precioUnitario { get; set; }

   }
}