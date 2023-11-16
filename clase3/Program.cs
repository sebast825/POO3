namespace clase3;

class Program
{
    static void Main(string[] args)
    {

        Quincenal unQ = new Quincenal
        {
            nombre = "joselio",
            salarioHora = 50
        };
        Horas unH = new Horas
        {
            nombre = "joselio",
            salarioHora = 50
        };



        unQ.marcarIngreso();
        Console.WriteLine(unQ.verSalario());

        unH.marcarIngreso();
        unH.marcarIngreso();

        unH.marcarIngreso();
        unH.marcarIngreso();
        unH.marcarIngreso();

        Console.WriteLine(unH.verSalario());


    }
}


/*
 Persona unaPersona = new Persona();

            unaPersona.cargarSube(300);
            unaPersona.mostrarsaldoSube();
            
               Profesor profesor = new Profesor();

            // Acceder a las propiedades y métodos de la clase Profesor
            profesor.saldoSube = 100; // Establecer el saldoSube del profesor
            int saldo = profesor.cargarSube(50); // Cargar saldoSube del profesor
            Console.WriteLine($"Saldo del Profesor: {saldo} pesos");
            profesor.mostrarsaldoSube(); // Mostrar el saldoSube del profesor

            // Puedes realizar más operaciones con el objeto Profesor aquí

            // Mantén la consola abierta hasta que el usuario presione Enter
          

unaPersona.saludar();
            profesor.saludar();*/