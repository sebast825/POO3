using System.Dynamic;

namespace clase14
{

   internal abstract class Gobierno
   {

      private int ministerios { get; set; }
      public List<LLave> listaLlaves = new List<LLave>();
      public Gobierno(int cantMinisterios)
      {
         ministerios = cantMinisterios;
      }
      public void CrearLlaves()
      {
         for (int i = 0; i < this.ministerios; i++)
         {
            Random random = new Random();
            LLave llave = new LLave(random.Next(1, 11), i+1);
            listaLlaves.Add(llave);
         }
      }
      public abstract void UsarLlave(int numLlave);     
   }

   internal class Tierra : Gobierno
   {
      public Tierra(int cantMinisterios) : base(cantMinisterios)
      {

      }
      public override void UsarLlave(int numLlave){
         int usosDisponibles = listaLlaves[numLlave].GetUsos();
         //Console.WriteLine(usosDisponibles);
         if(usosDisponibles == 0){
            Console.WriteLine($"La llave n° {numLlave} no se puede usar");
         }else{
            listaLlaves[numLlave].UsarLlave();
         }
      }

   }
   internal class Kepler :Gobierno{
       public Kepler(int cantMinisterios) : base(cantMinisterios)
      {

      }
      public override void UsarLlave(int numLlave){
         int usosDisponibles = listaLlaves[numLlave].GetUsos();
         Console.WriteLine(usosDisponibles);
         if(usosDisponibles == 0){
            listaLlaves[numLlave].SetUsos(10);
            Console.WriteLine($"Se ha creado una nueva llave");
         }else{
            listaLlaves[numLlave].UsarLlave();
         }
      }
   }
   internal class LLave
   {
      private int ministroAsociado { get; set; }
      private int usos { get; set; }

      public LLave(int cantUsos, int numMinistro)
      {
         this.ministroAsociado = numMinistro;
         this.usos = cantUsos;
      }
      public int UsarLlave()
      {
         usos--;
         return GetUsos();
      }

      public int GetUsos(){
         return usos;
      }
      public void SetUsos(int cantUsos){
         usos = cantUsos;
      }

   }
}