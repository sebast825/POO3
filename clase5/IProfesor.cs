namespace clase5
{
   internal interface IProfesion
   {
      int aniosEstudio();
      string nombreProfesion();
   }

   internal class Profesor : IProfesion
   {
      public int aniosEstudio()
      {
         //Console.WriteLine("Son 4 años");
         return 4;
      }

      string IProfesion.nombreProfesion()
      {
         //Console.WriteLine("Soy profesor");
         return "Soy profesor";
      }

      public void Saludo()
      {
         Console.WriteLine("hola");
      }
   }
   internal class Arquitecta : IProfesion
   {
      public int aniosEstudio()
      {
         throw new NotImplementedException();
      }

      public string nombreProfesion()
      {
         throw new NotImplementedException();
      }
   }
}