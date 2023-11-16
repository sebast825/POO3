

namespace clase5{

   interface IPliego{

      void AceleracionSupersonica(int kms);

      void FrenadoEstelar();
   }

   internal class EmpresaA : IPliego{
      public int totalPotencia {get; set;}
       public void AceleracionSupersonica(int kms){
         int resultado = kms *2 - 5;
         Console.WriteLine($"Potencia consumida: { resultado}");
         this.totalPotencia -= resultado;
       }

      public void FrenadoEstelar(){
         Console.WriteLine("Frenado estelar 150");
         this.totalPotencia -= 150;
      }
   }
     internal class EmpresaB : IPliego{
      public int totalPotencia {get; set;}
       public void AceleracionSupersonica(int kms){
         int resultado = kms * 3 - 2;
         Console.WriteLine($"Potencia consumida: { resultado}");
         this.totalPotencia -= resultado;
       }

     public void FrenadoEstelar(){
         Console.WriteLine("Frenado estelar 130");
         this.totalPotencia -= 130;
      }
   }
}