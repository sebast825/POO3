namespace clase4
{
     class Persona
   {
      public Persona(string valor, int edad)
      {

         Console.WriteLine($"Soy una persona: {valor} y tengo {edad} años.");

      }
   }
   internal class Profesor : Persona
   {
      public Profesor(string valor, int numero) : base(valor, numero)
      {

         Console.WriteLine($"Soy el profesor: {valor}");

      }
   }
}