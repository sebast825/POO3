using System;

namespace clase6
{
    class Program
    {
        static void Main(string[] args)
        {

            int paisLength, maxLength = 0;
            string namePaisLength = "";
            StreamWriter escritor = new StreamWriter("archivoPaises.txt", true, System.Text.Encoding.Default);

            using (StreamReader unArchivo = new StreamReader("Paises.txt", System.Text.Encoding.Default))
            {
                while (unArchivo.EndOfStream != true)
                {
                    string[] renglon = unArchivo.ReadLine().Split(';');
                    paisLength = renglon[0].Length;

                    if (paisLength > maxLength)
                    {
                        maxLength = paisLength;
                        namePaisLength = renglon[0];
                    }

                    if (renglon[2].ToUpper() == "EUROPA")
                    {
                        escritor.WriteLine($"{renglon[0]} - {renglon[1]}");
                        escritor.Flush();
                    }
                }

                escritor.WriteLine($"El pais con mas caracteres es {namePaisLength} con {maxLength} caracteres");
                escritor.Flush();

            }





        }

    }
}


/*EJERCICIO 2

      int value, value2, resultado;
            StreamWriter escritor = new StreamWriter("archivoResultado.txt", true, System.Text.Encoding.Default);

            Console.WriteLine("Ingresar 1er valor");
            value = int.Parse(Console.ReadLine());

            while (value != 0)
            {
                Console.WriteLine("Ingresar 2do valor");
                value2 = int.Parse(Console.ReadLine());

                try
                {
                    resultado = value / value2;
                    escritor.WriteLine($"{DateTime.Now} - OK - {resultado}");
                    escritor.Flush();

                    Console.WriteLine("Ingresar 1er valor");
                    value = int.Parse(Console.ReadLine());

                }
                catch (Exception err)
                {
                    escritor.WriteLine($"{DateTime.Now} - ERROR - {err.Message}");
                    escritor.Flush();
                    
                    Console.WriteLine("Ingresar 1er valor");
                    value = int.Parse(Console.ReadLine());

                }
            }
*/
/*
//EJERCIOCIO 1
            int max = 0, b = 0;
            using (StreamReader unArchivo = new StreamReader("tanque.txt", System.Text.Encoding.Default))
            {
                while (unArchivo.EndOfStream != true)
                {
                    string[] renglon = unArchivo.ReadLine().Split('|');
                    int numActual = int.Parse(renglon[1]);
                    if ( b == 0){
                        max = numActual;
                        b=1;
                    }else{
                        if(numActual > max){
                            max = numActual;
                        }
                    }
                }
                Console.WriteLine($"El maximo es: {max}");
            }
    */
/*
         using (StreamReader unArchivo = new StreamReader("ejemplo.txt", System.Text.Encoding.Default))
            {
                while (unArchivo.EndOfStream != true)
                {
                    Console.WriteLine(unArchivo.ReadLine());
                }
            }*/

/*
            Partipante unParticipante = new Basquetbolista();
            Partipante dosParticipante = new Cantante();

            Entrenador unEntrenador = new Entrenador();

            unEntrenador.MostrarHablidad(unParticipante);
                        unEntrenador.MostrarHablidad(dosParticipante);
*/