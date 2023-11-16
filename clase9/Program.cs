namespace clase9;
class Program
{
    static void Main(string[] args)
    {

Formacion unaFormacion = new Formacion(7);
unaFormacion.AgregarVagon(10,'V');
unaFormacion.AgregarVagon(10,'V');

unaFormacion.AgregarPasajeros(20);
unaFormacion.AgregarPasajeros(20);

unaFormacion.QuitarVagon();
unaFormacion.QuitarPasajeros();
unaFormacion.QuitarVagon();

unaFormacion.MostrarFormacion();


        /*
        Vagon unVagon = new Vagon(20,'V');
        Console.WriteLine(unVagon.GetPasajeros());
        unVagon.SetPasajeros(10);
  Console.WriteLine(unVagon.GetPasajeros());
        unVagon.SetPasajeros(10);
          Console.WriteLine(unVagon.GetPasajeros());
        unVagon.SetPasajeros(10);
          Console.WriteLine(unVagon.GetPasajeros());
        unVagon.SetPasajeros(10);*/
    }
}

/*
figus

  Figurita unaFigu = new Figurita("mache");
     Figurita dosFigu = new Figurita("leo");
     Album unAlbum = new Album(3);
     unAlbum.PegarFigurita(unaFigu);
          unAlbum.PegarFigurita(dosFigu);
          unAlbum.PegarFigurita(dosFigu);
          unAlbum.PegarFigurita(dosFigu);
unAlbum.MostrarFiguritas();
*/
/*
MUNDO

 Sol elSol = new Sol("socito", 8);


        elSol.CrearPlaneta(1);
        elSol.CrearPlaneta(2);
        elSol.CrearPlaneta(3);
        elSol.CrearPlaneta(4);

        elSol.MostrarPlaneta();
        elSol.MostrarInfo();

*/

/*
teclado

 Teclado miTeclado = new Teclado("Confort", 2);

        //miTeclado.EntradaCable("PS2");

        Console.WriteLine($"El teclado está: {miTeclado.Conectar()}");
        Console.WriteLine($"El teclado está: {miTeclado.Desconectar()}");

        Tecla letraA = new Tecla();
        letraA.simbolo = "A";

        miTeclado.AgregarTecla(letraA);

        Tecla letraB = new Tecla();
        letraB.simbolo = "B";
        letraA = new Tecla();
        letraA.simbolo = "B";
        miTeclado.AgregarTecla(letraA);
*/