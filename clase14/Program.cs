
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
       
       colegioUno.OrdernarAlumnos();
       colegioUno.Altura();
     
       /* colegioUno.Saludar();
        colegioUno.Aprobar();
        colegioUno.Estadistica();*/
          colegioUno.Inserar();
    }
}
