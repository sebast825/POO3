using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clase14
{
   internal class Alumno
   {
      private int legajo { get; set; }
      private int calificacion { get; set; }
      private int altura { get; set; }
      public Alumno(int legajo, int calificacion, int altura)
      {
         this.legajo = legajo;
         this.calificacion = calificacion;
         this.altura = altura;
      }

      public void Saludar()
      {
         Console.WriteLine("Hola " + this.legajo);
      }

      public void Aprobar(int calificacionMin)
      {
         Console.WriteLine($"Mi calificacion es: {this.calificacion}");

         if (calificacionMin <= calificacion)
         {
            Console.WriteLine("Aprobe");
         }
         else
         {
            Console.WriteLine("Desaprobe");
         }
      }
      public int GetCalificacion()
      {
         return this.calificacion;
      }
      public int GetAltura()
      {
         return this.altura;
      }
      public int GetLegajo()
      {
         return this.legajo;
      }

   }

   internal abstract class Colegio
   {
      SqlConnection sesion = new SqlConnection();
      protected int calificacionMin { get; set; }
      protected List<Alumno> listaAlumnos = new List<Alumno>();

      public Colegio(int calificacionMin)
      {
         sesion.ConnectionString = $"Data Source=DESKTOP-K6LIC36\\MSSQLSERVERDOS ; Integrated Security=SSPI; Initial Catalog=Poo";

         this.calificacionMin = calificacionMin;
      }
      public void AgregarAlumno(Alumno alumno)
      {
         listaAlumnos.Add(alumno);
      }
      public void Saludar()
      {
         foreach (Alumno elem in listaAlumnos)
         {
            elem.Saludar();
         }
      }

      public void Estadistica()
      {
         Console.WriteLine($"Promedio: {listaAlumnos.Average(x => x.GetCalificacion())}");
         Console.WriteLine($"Max: {listaAlumnos.Max(x => x.GetCalificacion())}");
         Console.WriteLine($"Min: {listaAlumnos.Min(x => x.GetCalificacion())}");
      }

      public void Aprobar()
      {
         foreach (Alumno elem in listaAlumnos)
         {
            elem.Aprobar(this.calificacionMin);
         }
      }

      public abstract void OrdernarAlumnos();
      public void Altura()
      {
         foreach (Alumno elem in listaAlumnos)
         {
            Console.WriteLine(elem.GetAltura());
         }
      }

      public DataTable ListarResultados(string query)
      {
         sesion.Open();
         SqlCommand cmd = new SqlCommand();
         cmd.Connection = this.sesion; //SqlConnection
         cmd.CommandText = query; //SP o query
         cmd.CommandType = CommandType.Text;
         cmd.CommandTimeout = 1000;

         SqlDataAdapter adaptadorDatos = new SqlDataAdapter();
         adaptadorDatos.SelectCommand = cmd;

         DataTable miTabla = new DataTable();
         adaptadorDatos.Fill(miTabla);

         return miTabla;
      }
      public void Registrar(Alumno alumno)
      {

         sesion.Open();
         SqlCommand cmd = new SqlCommand();

         cmd.Parameters.Add(new SqlParameter("legajo", SqlDbType.Int));
         cmd.Parameters["legajo"].Value = alumno.GetLegajo();
         cmd.Parameters.Add(new SqlParameter("calificacion", SqlDbType.Int));
         cmd.Parameters["calificacion"].Value = alumno.GetCalificacion();

         cmd.Parameters.Add(new SqlParameter("altura", SqlDbType.Int));
         cmd.Parameters["altura"].Value = alumno.GetAltura();


         cmd.Connection = sesion; //SqlConnection
         cmd.CommandText = "INSERT INTO Alumnos VALUES (@legajo, @calificacion, @altura)"; //SP o query
         cmd.CommandType = CommandType.Text;
         cmd.CommandTimeout = 1000;


         //Muestro la cantidad de filas afectadas por la ejecución de la consulta.
         //La sentencia ExcecuteNonQuery se puede ejecutar y asignar a una variable.
         int total = cmd.ExecuteNonQuery();
         sesion.Close();

      }
      public void Inserar()
      {
         foreach (Alumno elem in listaAlumnos)
         {
            Registrar(elem);
         }
      }
   }

   internal class ColegioUno : Colegio
   {
      public ColegioUno(int calificacionMin) : base(calificacionMin)
      {

      }
      public override void OrdernarAlumnos()
      {

         listaAlumnos = listaAlumnos.OrderBy(elem => elem.GetAltura()).ToList();
         //listaAlumnos.Sort((a, b) => a.GetAltura().CompareTo(b.GetAltura()));


      }
   }
   internal class ColegioDos : Colegio
   {
      public ColegioDos(int calificacionMin) : base(calificacionMin)
      {

      }
      public override void OrdernarAlumnos()
      {
         listaAlumnos = listaAlumnos.OrderByDescending(elem => elem.GetAltura()).ToList();

         //         listaAlumnos.Sort((a, b) => b.GetAltura().CompareTo(a.GetAltura()));
      }
   }
}