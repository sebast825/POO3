using System.Reflection;

namespace clase7
{

   interface IPeleador
   {


      void RecibirEnergia();
      void MostrarInformacion();
      void AbsorberEjecucion(double ataque);
      double Ejecucion();
   }

   internal class Stats : IPeleador
   {


      public double Energia { set; get; }
 

      public virtual void RecibirEnergia()
      {

      }
      public virtual void MostrarInformacion()
      {

      }
      public virtual double Ejecucion()
      {
         return 0;
      }
      public virtual void AbsorberEjecucion(double ataque)
      {

      }

   }

   class Mago : Stats
   {

    

      public override void MostrarInformacion()
      {
         Console.WriteLine($"Clase: Mago, Energia Actual: {Energia}");
      }
      public override double Ejecucion()
      {
         Random random = new Random();
         int numeroAleatorio = random.Next(1, 11);
         double ataque = numeroAleatorio * 2 - 5;
         if(ataque < 0){
            ataque = 0;
         }
         return ataque;
      }
      public override void AbsorberEjecucion(double ataque)
      {
         Energia -= ataque;
         Console.WriteLine($"Energia: {Energia}");
         if (Energia <= 0)
         {
            Energia = 0;

            Console.WriteLine("El mago ah muerto, su energia es 0");
         }
      }
   }


}