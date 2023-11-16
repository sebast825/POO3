namespace clase5
{
   interface IMicroorganismo
   {

      void NivelMultiplicacion();
      void Infectan();


   }

   internal class Microorganismo : IMicroorganismo
   {


      public int TiempoVida { set; get; }
      public int NivelInfeccion { set; get; }

      public virtual void NivelMultiplicacion()
      {

      }

      public void Infectan()
      {
         Console.WriteLine($"Nivel infeccion: {this.TiempoVida * this.NivelInfeccion}");
      }
   }
   internal class Virus : Microorganismo
   {

      public override void NivelMultiplicacion()
      {
         Console.WriteLine("Se reprduce cada 2 segundos");
      }


   }
   internal class Bacteria : Microorganismo
   {

     
      public override void NivelMultiplicacion()
      {
         Console.WriteLine("Se reprduce cada 1 segundo");
      }

      public void InfectaA()
      {
         Console.WriteLine("Afecta funciones motoras");
      }
      public void InfectaA(Virus virus)
      {
         if (virus is VirusSuper)
         {
            Console.WriteLine("Es un virus super!");
            virus.NivelInfeccion = 0;
         }
      }

   }

   internal class VirusSuper : Virus
   {

      public void InfectaA()
      {
         Console.WriteLine("Infecta las vias aéreas");
      }
   }
   internal class VirusUltra : Virus
   {

      public void InfectaA()
      {
         Console.WriteLine("Infecta la sangre y descompone celulas");
      }
   }
}