namespace parcial;
class Program
{
    static void Main(string[] args)
    {


        Restaurante unRestaurante = new Restaurante();

        unRestaurante.CrearMenues();
        unRestaurante.MostrarCaloriasMenues();

        for (int i = 0; i < 5; i++)
        {
            Comensal unComensal = unRestaurante.ElegirComensal();

            int numMenu = unComensal.ElegirMenu(unRestaurante);
            Menu menuElegido = unRestaurante.Menues[numMenu];

            unComensal.GetMetabolizar(unComensal, unRestaurante.Menues[numMenu]);
            unComensal.Metabolizar(menuElegido);
            unComensal.EsMuyCalorico(unComensal,menuElegido);
            unRestaurante.GustaElPlato();
            unComensal.GustaElPlato();

        }
        unRestaurante.RegistrarMenu();
        unRestaurante.RegistrarCaloriasMenues();

    }
}
