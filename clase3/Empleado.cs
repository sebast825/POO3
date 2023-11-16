using System.Dynamic;

namespace clase3
{
   class Empleado
   {
      //protected int diasTrabajados { get; set; } 
      public string nombre { get; set; }
      public int salarioHora { get; set; }
      private int diasTrabajados { get; set; }
      public void marcarIngreso()
      {
         diasTrabajados += 1;
      }
      public int mostrarDiasTrabajados()
      {
         return this.diasTrabajados;
      }

      public virtual int verSalario()
      {
         return 0;
      }
   }
   internal class Quincenal : Empleado
   {
      public override int verSalario()
      {
         //base.verSalario();
         Console.WriteLine(this.salarioHora);
         return this.salarioHora * 8 * 5 * 4;
      }
   }
   internal class Horas : Empleado
   {
      public override int verSalario()
      {
                  Console.WriteLine(this.salarioHora);

         //base.verSalario();
         return this.salarioHora * 8 * this.mostrarDiasTrabajados();
      }
   }
}