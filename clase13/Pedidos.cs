using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace clase13
{
   internal class Pedido
   {
      public float totalVendido { get; set; }
      public float unidades { get; set; }
      public Pedido(float totalVendido, float unidades){
         this.totalVendido= totalVendido;
         this.unidades = unidades;
      }
   }
   internal class RegistroPedidos
   {
      public List<Pedido> listarPedidos { get; set; }

      public RegistroPedidos()
      {
         listarPedidos = new List<Pedido>();
      }

      public void CantidadPedidos()
      {
         Console.WriteLine($"Hay {listarPedidos.Count()} pedidos");
      }
      public void MostrarPeidods()
      {
         foreach (Pedido elem in listarPedidos)
         {
            Console.WriteLine($"Total vendido: {elem.totalVendido}, unidades: {elem.unidades}");
         }
         
      }
      public void AgregarPeidos(DataTable miTabla)
      {
         foreach (DataRow item in miTabla.Rows)
         {
                  float importeTotal = Convert.ToSingle(item["ImporteTotal"]);
                float cantidad = Convert.ToSingle(item["cantidad"]);

                listarPedidos.Add(new Pedido(importeTotal, cantidad));
            //listarPedidos.Add(new Pedido((float)item["ImporteTotal"], (float)item["cantidad"]));
            //Console.WriteLine($"{item["ImporteTotal"]} - {item["cantidad"]}");
         }
      }
   }
}