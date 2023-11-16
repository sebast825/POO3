namespace clase7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Mago unMago = new Mago();
        Mago otroMago = new Mago();
    unMago.Energia = 50;
    otroMago.Energia = 50;
        
        otroMago.AbsorberEjecucion(unMago.Ejecucion());

    }
}
