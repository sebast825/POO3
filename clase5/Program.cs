namespace clase5;
class Program
{
    static void Main(string[] args)
    {
       VirusUltra unUltra = new VirusUltra();
        VirusSuper unSuper = new VirusSuper();
        Bacteria unaBacteria = new Bacteria();

        unUltra.TiempoVida = 1;
        unUltra.NivelInfeccion = 2;

        unUltra.Infectan();
      
      unSuper.TiempoVida = 1;
        unSuper.NivelInfeccion = 2;

        unSuper.Infectan();

        unaBacteria.InfectaA(unSuper);
        unSuper.Infectan();
    }
}

/*
 IPelota tenis = new Tenis();

        tenis.Distancia(10);
        tenis.Curvatura(10);
*/
/*
int valor = int.Parse(Console.ReadLine());
    IPliego empresa;
    if (valor == 1){
        empresa = new EmpresaA();
        ((EmpresaA)empresa).totalPotencia = 100;
    }
    else{
                empresa = new EmpresaB();
        ((EmpresaB)empresa).totalPotencia = 100;

    }

    empresa.AceleracionSupersonica(10);
    empresa.FrenadoEstelar();
 
*/
/*
  EmpresaA empresaA = new EmpresaA();
      EmpresaB empresaB = new EmpresaB();

      empresaA.totalPotencia = 300;
empresaA.totalPotencia = 300;
empresaA.AceleracionSupersonica(10);
empresaB.AceleracionSupersonica(10);

empresaA.FrenadoEstelar();
empresaB.FrenadoEstelar();
*/
/*
  //lo que se pone antes es con respecto a la interfaz, despues del new es la clase
        //saludo es propio de la clase Profesor, no IProfesor
        Profesor unProfesor = new Profesor();
        IProfesion unaProfesora = new Profesor();

        Console.WriteLine(((IProfesion)unProfesor).nombreProfesion());

        ((Profesor)unaProfesora).Saludo();
        unProfesor.Saludo();

*/

/*
     Curso unCurso = new Curso();
        unCurso.AgregarAlumno("Romero", 10);
        unCurso.AgregarAlumno("Percara", 9);
        unCurso.AgregarAlumno("Vigabriel", 10);
        unCurso.AgregarAlumno("Montenegro", 10);
        unCurso.AgregarAlumno("Benitex", 4);
                unCurso.AgregarAlumno("Villalva",2);

                unCurso.Promedio();
                unCurso.MinimoMaximo();

unCurso.Ordernar();
*/