namespace clase9
{

   internal class Sol
   {
      private Queue<Planeta> colaPlaneta;
      private string nombre { get; set; }
      private int cargaTotal { get; set; }

      public Sol(string nombre, int cargaTotal)
      {
         this.nombre = nombre;
         this.cargaTotal = cargaTotal;
         this.colaPlaneta = new Queue<Planeta>();
      }
      public void CrearPlaneta(int carga)
      {

         if (cargaTotal < carga)
         {
            Console.WriteLine("no hay energia");
            return;
         }
      

            Planeta planeta = new Planeta(carga);
            this.colaPlaneta.Enqueue(planeta);
            this.cargaTotal -= carga;
         

      }
      public void MostrarInfo()
      {
         Console.WriteLine($"El sol es {this.nombre} y su carga total es {this.cargaTotal}");
      }
      public void MostrarPlaneta()
      {
         foreach (Planeta planeta in colaPlaneta)
         {
            Console.WriteLine($"{planeta.getCodigo()}");
         }
      }
   }
   internal class Planeta
   {

      private int codigo { get; set; }

      public Planeta(int num)
      {
         this.codigo = num;
      }

      public int getCodigo()
      {
         return this.codigo;
      }
   }
}