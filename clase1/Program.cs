namespace clase1;
class Program
{
    static void Main(string[] args)
    {

        Persona personaUno = new Persona();
        Persona personaDos = new Persona();

        personaUno.registrar("mati");
        personaDos.registrar("carlos");
        personaUno.deposito(1500);
        personaDos.deposito(1000);
        personaUno.extraccion(500);
        personaDos.extraccion(200);
personaUno.mostrar();
personaDos.mostrar();
/*
        TarjetaSube miSube = new TarjetaSube();

        miSube.cargarSube(200);
        miSube.pagar(30);
        miSube.pagar(30);
        miSube.pagar(30);
        miSube.mostrarSaldo();*/
/*
        Coche miCoche = new Coche();
        Coche miCoche2 = new Coche();

miCoche.capacidadTanque = 50;
miCoche2.capacidadTanque = 30;
        miCoche.Acelerar();
    
        Console.WriteLine(miCoche.capacidadTanque);

        Console.WriteLine(miCoche2.capacidadTanque);

        miCoche=miCoche2;
        Console.WriteLine(miCoche.capacidadTanque);
        miCoche2.Acelerar();
        Console.WriteLine(miCoche.capacidadTanque);
*/

    }
}
