namespace clase5
{

   internal class Curso
   {
      Dictionary<string, int> listaAlumnos { get; set; }

      public Curso()
      {
         this.listaAlumnos = new Dictionary<string, int>();
      }

      public void AgregarAlumno(string apellido, int nota)
      {

         if (this.listaAlumnos.Count == 5)
         {
            Console.WriteLine("No se pueden agregar mas alumnos");
         }
         else
         {
            this.listaAlumnos.Add(apellido, nota);
               Console.WriteLine("Se agregó el alumno");
            
         }
      }

      public void Promedio()
      {
         int suma = 0;
         foreach(string apellido in this.listaAlumnos.Keys){
            suma += this.listaAlumnos[apellido];
         }
         Console.WriteLine($"El promedio es {suma / this.listaAlumnos.Count}");
      }

      public void MinimoMaximo(){
      

         if(this.listaAlumnos.Count == 0){
            Console.WriteLine("No hay alumnos");
            return;
         }
         int min = 0;
         int max = 0;
         int order = 0;
         /*
         foreach(string apellido in this.listaAlumnos.Keys){

            int getKey = this.listaAlumnos[apellido];

            if(order == 0){
               order = 1;
               min = getKey;
               max = getKey;
            }
            else{
               if(min > getKey){
                  min = getKey;
               }
               if(max < getKey){
                  max = getKey;
               }
            }
         }
*/
         min = this.listaAlumnos.Min(x => x.Value);
                  max = this.listaAlumnos.Min(x => x.Value);

         Console.WriteLine($"El minimo es {min}, y el maximo es {max}");
      }

      public void Ordernar(){
         var resultados = this.listaAlumnos.OrderBy(x => x.Value);

         foreach (var item in resultados){
            Console.WriteLine(item.Value);
         }
      }
   }

}