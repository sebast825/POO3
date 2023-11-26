
using System;
using System.Data;
using System.Data.SqlClient;

namespace clase14;
class Program
{
    static void Main(string[] args)
    {
ColegioUno colegioUno = new ColegioUno(4);
        Random r = new Random();

        for(int i = 0; i < 10; i++){
            colegioUno.AgregarAlumno(new Alumno(i+1,r.Next(1,11),r.Next(150,180)));
        }

        DataTable miTabla = colegioUno.ListarResultados("select * from alumnos");
        foreach(DataRow elem in miTabla.Rows){
            Console.WriteLine($"{elem["legajo"]} - {elem["calificacion"]} - {elem["altura"]}" );
        }

        
       
       colegioUno.OrdernarAlumnos();
       colegioUno.Altura();
     
        colegioUno.Saludar();
        colegioUno.Aprobar();
        colegioUno.Estadistica();
          //colegioUno.Inserar();


       /* Kepler unGobierno = new Kepler(4);

        unGobierno.CrearLlaves();
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);

        unGobierno.UsarLlave(1);

        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
        unGobierno.UsarLlave(1);
     */
    }
}


/*
   ColegioUno colegioUno = new ColegioUno(4);
        Random r = new Random();

        for(int i = 0; i < 10; i++){
            colegioUno.AgregarAlumno(new Alumno(i+1,r.Next(1,11),r.Next(150,180)));
        }

        DataTable miTabla = colegioUno.ListarResultados("select * from alumnos");
        foreach(DataRow elem in miTabla.Rows){
            Console.WriteLine($"{elem["legajo"]} - {elem["calificacion"]} - {elem["altura"]}" );
        }

        
       
       colegioUno.OrdernarAlumnos();
       colegioUno.Altura();
     
        colegioUno.Saludar();
        colegioUno.Aprobar();
        colegioUno.Estadistica();
          //colegioUno.Inserar();

*/