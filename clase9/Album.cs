namespace clase9{


internal class Album{
   private int maxFiguritas {get;set;}
   public List<Figurita> listaFiguritas {get;}
   public Album(int maxFiguritas){
      this.maxFiguritas = maxFiguritas;
      this.listaFiguritas = new List<Figurita>();
   }

   public void PegarFigurita(Figurita figurita){

      if(this.maxFiguritas < 1) {
         Console.WriteLine("El album esta lleno");
         return;
      }
      this.listaFiguritas.Add(figurita);
      Console.WriteLine($"Jugador agregado, {this.maxFiguritas}");
      this.maxFiguritas -= 1;

   }
   public void MostrarFiguritas(){
      foreach(Figurita elem in listaFiguritas){
         Console.WriteLine($"{elem.GetNombre()}");
      }
   }
}
   internal class Figurita{
      private string nombre {set;get;}

      public Figurita(string nombre){
         this.nombre = nombre;
      }
      public string GetNombre(){
         return this.nombre;
      }
   }
}