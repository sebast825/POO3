
using System.Data;
using System.Data.SqlClient;


namespace clase15
{
   internal class Colectivo
   {
      private List<Estudiante> listaEstudiante;
      private List<Habitual> listaHabitual;
      private List <int> listaRecaudado;
      SqlConnection sesion = new SqlConnection();


      public Colectivo()
      {
         listaEstudiante = new List<Estudiante>();
         listaHabitual = new List<Habitual>();
         listaRecaudado = new List<int>();
         sesion.ConnectionString = $"Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";

      }

      public void Registrar(Pasajero pasajero)
      {

         sesion.Open();
         SqlCommand cmd = new SqlCommand();

         cmd.Parameters.Add(new SqlParameter("tipo", SqlDbType.VarChar));
         cmd.Parameters["tipo"].Value = pasajero.GetTipo();
         cmd.Parameters.Add(new SqlParameter("monto", SqlDbType.Int));
         cmd.Parameters["monto"].Value = pasajero.GetUltimoPasaje();

         cmd.Connection = sesion; //SqlConnection
         cmd.CommandText = "insert into Cobros values (@tipo, @monto)"; //SP o query
         cmd.CommandType = CommandType.Text;
         cmd.CommandTimeout = 1000;

         //Muestro la cantidad de filas afectadas por la ejecución de la consulta.
         //La sentencia ExcecuteNonQuery se puede ejecutar y asignar a una variable.
         int total = cmd.ExecuteNonQuery();
         sesion.Close();

      }
      public void InsertarDb()
      {
         foreach (Estudiante elem in listaEstudiante)
         {
            Registrar(elem);
         }
         foreach (Habitual elem in listaHabitual)
         {
            Registrar(elem);
         }

      }

      public void MostrarMontos()
      {

         foreach (Estudiante estudiante in listaEstudiante)
         {
            listaRecaudado.Add(estudiante.GetUltimoPasaje());
         }
         foreach (Habitual habitual in listaHabitual)
         {
            listaRecaudado.Add(habitual.GetUltimoPasaje());
         }
         listaRecaudado.Sort();
         foreach (int elem in listaRecaudado)
         {
            Console.Write($"{elem} - ");
         }

         Console.WriteLine($"\nEl total recaudado fue: {listaRecaudado.Sum()}");

      }

      public int TotalRecaudado()
      {
         int total = 0;
         foreach (Estudiante estudiante in listaEstudiante)
         {
            total += estudiante.GetUltimoPasaje();
         }
         foreach (Habitual habitual in listaHabitual)
         {
            total += habitual.GetUltimoPasaje();
         }

         return total;
      }
      public void PreguntaInspector()
      {
         Console.WriteLine("¿Cuanto Recaudaste?");
         Console.WriteLine($"El total recaudado fue: {TotalRecaudado()}");
      }
      public void AgregarEstudiante(Estudiante estudiante)
      {

         listaEstudiante.Add(estudiante);

      }
      public void AgregarHabitual(Habitual habitual)
      {

         listaHabitual.Add(habitual);

      }

      public void CobrarPasaje()
      {
         Console.WriteLine("Abonan estudiantes:");
         foreach (Estudiante estudiante in listaEstudiante)
         {
            estudiante.AbonarPasaje(this.Monto());


         }
         Console.WriteLine("Abonan habituales:");

         foreach (Habitual habitual in listaHabitual)
         {
            habitual.AbonarPasaje(this.Monto());

         }
      }
      public int Monto()
      {
         Random random = new Random();

         int opcion = random.Next(1, 4);

         switch (opcion)
         {
            case 1:
               return 50;

            case 2:
               return 75;

            case 3:
               return 100;

            default:
               Console.WriteLine("Error");
               return 0;

         }
      }

   }
   internal abstract class Pasajero
   {

      protected int monto { get; set; }
      protected int montoNegativo { get; set; }
      protected char tipo;
      private int ultimoPasaje { get; set; }

      public char GetTipo()
      {
         return tipo;
      }

      public int GetUltimoPasaje()
      {
         return ultimoPasaje;
      }

      public void SetUltimoPasaje(int value)
      {
         ultimoPasaje = value;
      }
      public Pasajero(int monto, int montoNegativo, char tipo)
      {
         this.monto = monto + montoNegativo;
         this.montoNegativo = montoNegativo;
         this.tipo = tipo;
      }

      public abstract int AbonarPasaje(int abonar);
   }
   internal class Habitual : Pasajero
   {
      public Habitual(int monto, int montoNegativo, char tipo) : base(monto, montoNegativo, tipo) { }

      public override int AbonarPasaje(int abonar)
      {
         int montoAbonado = this.monto - abonar;
         if (montoAbonado >= 0)
         {
            this.monto = montoAbonado;
            SetUltimoPasaje(abonar);

            int saldoActual = montoAbonado - this.montoNegativo;
            Console.WriteLine($"El saldo actual es {saldoActual}");
            return abonar;
         }
         else
         {
            Console.WriteLine("El Saldo es insuficiente");
            return 0;
         }
      }

   }

   internal class Estudiante : Pasajero
   {
      public Estudiante(int monto, int montoNegativo, char tipo) : base(monto, montoNegativo, tipo) { }

      public override int AbonarPasaje(int abonar)
      {
         int boletoEstudiantil = 10;
         int montoAbonado = this.monto - boletoEstudiantil;
         if (montoAbonado >= 0)
         {
            this.monto = montoAbonado;
            SetUltimoPasaje(boletoEstudiantil);

            int saldoActual = montoAbonado - this.montoNegativo;
            Console.WriteLine($"El monton disponible es {saldoActual}");
            return boletoEstudiantil;
         }
         else
         {
            Console.WriteLine("El Saldo es insuficiente");
            return 0;
         }
      }

   }

}