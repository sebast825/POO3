namespace clase3{
class Persona
{
   public int saldoSube { get; set; }
   public int numeroSerie { get; set; }

//solo se puede ver dentro de la clase persona
private int Edad {get; set;}
//lo puede ver las clases derivadas (donde se usa herencia)
protected int Altura {get; set;}
 public virtual void saludar(){
      Console.WriteLine("Hola soy una persona");
   }
   public int cargarSube(int importe)
   {
      saldoSube += importe;
      return saldoSube;
   }
   public int pagarSube(int importe)
   {
      saldoSube -= importe;
      return saldoSube;
   }
   public void mostrarsaldoSube()
   {
      Console.WriteLine($"El saldoSube actual es: {saldoSube} pesos.");

   }
}
internal class Profesor : Persona
{
   public override void saludar(){
      //base.saludar();
      Console.WriteLine("Hola soy el Profesor");
      
   }
}
}
