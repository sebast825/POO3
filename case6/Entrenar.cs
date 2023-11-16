namespace case6{

   internal interface Partipante{

       public void MostrarHablidad();
      internal class Basquetbolista : Partipante{

         public  void MostrarHablidad(){
            Console.WriteLine("Encestar");
         }
         
      }
       internal class Cantante : Partipante{

         public  void MostrarHablidad(){
            Console.WriteLine("EntonarHimno.");
         }
         
      }

      internal class Entrenador{

         public void MostrarHablidad(Partipante unPartipante){

            unPartipante.MostrarHablidad();
         }
      }
   }
}


