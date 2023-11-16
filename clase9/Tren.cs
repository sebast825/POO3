using System.Security.Cryptography.X509Certificates;

namespace clase9
{

   internal interface IFormacion
   {
      public int GetPasajeros();
      public void AgregarVagon(int maxPasajeros, char tipo);
      public void QuitarVagon();
      public void AgregarPasajeros(int pasajeros);
      public void QuitarPasajeros();

   }
   internal class Formacion : IFormacion
   {

      private List<Vagon> listFormacion;

      public Formacion(int maxVagones)
      {

         if (maxVagones > 6)
         {
            maxVagones = 6;
            Console.WriteLine("La cantidad maxima de vagones son 6");
         }
         listFormacion = new List<Vagon>(maxVagones);
      }
      public int GetPasajeros()
      {
         return listFormacion.Sum(x => x.GetPasajeros());
      }
      public void AgregarVagon(int maxPasajeros, char tipo)
      {
         listFormacion.Add(new Vagon(maxPasajeros, tipo));
      }
      public void QuitarVagon()
      {

         int pasajerosActuales = this.listFormacion[listFormacion.Count - 1].GetPasajeros();
         if (pasajerosActuales == 0)
         {
            this.listFormacion.RemoveAt(listFormacion.Count - 1);
            Console.WriteLine("Se eliminó un vagon");
         }
         else
         {
            Console.WriteLine("El vagon tiene pasajeros, no se puede eliminar");

         }

      }
      public void AgregarPasajeros(int pasajeros)
      {
         foreach (Vagon elem in listFormacion)
         {
            if (elem.GetPasajeros() < elem.GetPasajerosMax())
            {
               elem.SetPasajeros(pasajeros);
               break;
            }
         }
      }
      public void MostrarFormacion()
      {
         foreach (Vagon elem in listFormacion)
         {

            Console.WriteLine(elem.GetPasajerosMax());


         }
      }
      public void QuitarPasajeros()
      {
         this.listFormacion[listFormacion.Count - 1].BajarPasajeros();
      }
   }
   internal interface IVagon
   {
      /*
      estas 3 no van, porque corresponde a modificar atributos estaticos de las clases, no se tiene que definir en la itnerfaz
      public int GetPasajeros();
      public int GetPasajerosMax();
       public void BajarPasajeros(); */
      public void SetPasajeros(int Pasajeros);



   }

   internal class Vagon : IVagon
   {

      private int maxPasajeros;
      private int pasajeros = 0;
      private char tipo;
      public Vagon(int maxPasajeros, char tipo)
      {
         this.tipo = tipo;
         this.maxPasajeros = maxPasajeros;

      }
      public void SetPasajeros(int pasajeros)
      {
         if (this.pasajeros >= this.maxPasajeros)
         {
            Console.WriteLine("Los pasajeros superan la cantidad máxima");
            return;
         }
         if (this.pasajeros + pasajeros > this.maxPasajeros)
         {
            this.pasajeros = this.maxPasajeros;
         }
         else
         {
            this.pasajeros += pasajeros;
         }


      }
      public void BajarPasajeros()
      {
         this.pasajeros = 0;
         Console.WriteLine("Bajarn los pasajeros");
      }
      public int GetPasajeros()
      {
         return pasajeros;
      }
      public int GetPasajerosMax()
      {
         return maxPasajeros;
      }

   }

}