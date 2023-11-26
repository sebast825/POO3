using System;
using System.Data;
using System.Data.SqlClient;

namespace clase15;
class Program
{
    static void Main(string[] args)
    {
        Colectivo unColectivo = new Colectivo();

        for (int i = 0; i < 10; i++)
        {
            Estudiante unEstudiante = new Estudiante(50, 200, 'E');
            unColectivo.AgregarEstudiante(unEstudiante);
        }
        for (int i = 0; i < 10; i++)
        {
            Habitual unHabitual = new Habitual(50, 200, 'C');
            unColectivo.AgregarHabitual(unHabitual);
        }
        unColectivo.CobrarPasaje();


        unColectivo.PreguntaInspector();
        unColectivo.MostrarMontos();
        unColectivo.TotalRecaudado();
        unColectivo.InsertarDb();



    }
}
