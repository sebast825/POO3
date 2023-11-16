using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9
{
   internal class Plaqueta
   {
      private bool encendido;
   
      public string modelo;

      public void Encender()
      {
         this.encendido = true;
      }

      public void Apagar()
      {
         this.encendido = false;
      }

      public bool getEncendido()
      {
         return this.encendido;
      }
   }

   internal class Cable
   {
      public int metros;
      public string tipoEntrada;
   }

   internal class Teclado
   {
      private Plaqueta plaqueta;
      private Cable cable;
      public List<Tecla> listaTeclas;

      public Teclado(string modelo, int largoCable)
      {
         this.plaqueta = new Plaqueta();
         this.plaqueta.modelo = modelo;

         this.cable = new Cable();
         this.cable.metros = largoCable;

         this.listaTeclas = new List<Tecla>();
      }

      //Cuando conecto el cable, se enciende la plaqueta
      public bool Conectar()
      {
         this.plaqueta.Encender();
         return this.plaqueta.getEncendido();
      }

      public bool Desconectar()
      {
         this.plaqueta.Apagar();
         return this.plaqueta.getEncendido();
      }
      public void EntradaCable(string tipoEntrada)
      {
         this.cable.tipoEntrada = tipoEntrada;
      }

      public void AgregarTecla(Tecla unaTecla)
      {
         this.listaTeclas.Add(unaTecla);
      }


      ~Teclado()
      {
         this.plaqueta = null;
         this.cable = null;
      }
   }

   internal class Tecla
   {
      public string simbolo;
   }




}