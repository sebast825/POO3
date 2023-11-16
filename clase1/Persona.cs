namespace clase1;
class Persona
{
   public string nombre {get;set;}
      public double monto {get;set;}

   public void registrar (string nombre){

      this.nombre = nombre;
 
   }
    public double deposito(double importe)
    {
         monto += importe;
         return monto;
    }
    public double extraccion(double importe)
    {
         monto -= importe;
         return monto;
    }
    public void mostrar()
    {
         Console.WriteLine($"El monto actual de {nombre} es: {monto} pesos."); 
       
    }
}
