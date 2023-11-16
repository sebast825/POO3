namespace clase6
{

   interface Partipante
   {

      void MostrarHablidad();
   }
   class Basquetbolista : Partipante
   {
      public void MostrarHablidad()
      {
         Console.WriteLine("Encestar");
      }

   }
   class Cantante : Partipante
   {

      public void MostrarHablidad()
      {
         Console.WriteLine("EntonarHimno.");
      }

   }

   internal class Entrenador
   {

      public void MostrarHablidad(Partipante unPartipante)
      {

         unPartipante.MostrarHablidad();
      }
   }

}


