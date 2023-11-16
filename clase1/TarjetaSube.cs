namespace clase1;
class TarjetaSube
{
   public int saldo {get;set;}
      public int numeroSerie {get;set;}

    public int cargarSube(int importe)
    {
         saldo += importe;
         return saldo;
    }
    public int pagar(int importe)
    {
         saldo -= importe;
         return saldo;
    }
    public void mostrarSaldo()
    {
         Console.WriteLine($"El saldo actual es: {saldo} pesos."); 
       
    }
}
