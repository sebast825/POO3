using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace parcial
{

   interface IComensal
   {
      double Metabolizar(Menu menu);
      void GustaElPlato();

      void EsMuyCalorico(Comensal comensal, Menu menu);

      void GetMetabolizar(Comensal comensal, Menu menu);

      int ElegirMenu(Restaurante restaurante);
   }

   internal class Comensal : IComensal
   {
//con protected lo modifican solo las subclases
      public int FactorMetabolico { protected set; get; }
      public int NivelCalorico { protected set; get; }



      public int ElegirMenu(Restaurante restaurante)
      {
         Random random = new Random();

         int numeroMenu = random.Next(0, restaurante.Menues.Length);

         Console.WriteLine($"\n\nEl Comensal eligió el menú n° {numeroMenu + 1}");
         return numeroMenu;
      }


      public virtual double Metabolizar(Menu menu)
      {
         return 0;
      }

      public virtual void EsMuyCalorico(Comensal comensal, Menu menu)
      {
         if (comensal.Metabolizar(menu) > comensal.NivelCalorico)
         {
            Console.WriteLine("Es muy calorico");
         }
         else
         {
            Console.WriteLine("No es muy calorico");
         }

      }
      public void GetMetabolizar(Comensal comensal, Menu menu)
      {

         Type tipoComensal = comensal.GetType();

         Console.WriteLine($"El Comensal {tipoComensal.Name} debe metabolizar {comensal.Metabolizar(menu)} calorias.");
      }
      public virtual void GustaElPlato()
      {

      }
   }

   internal class Sedentario : Comensal
   {
      public Sedentario()
      {
         FactorMetabolico = 3;
         NivelCalorico = 1500;
      }
      public override void GustaElPlato()
      {
         Console.Write("Si");
      }
      public override double Metabolizar(Menu menu)
      {

         int totalCalorias = menu.GetCaloriasTotales();
         double calculoCalorias = totalCalorias * FactorMetabolico - 120;
         return calculoCalorias;
      }

   }
   internal class Nomade : Comensal
   {
      public Nomade()
      {
         FactorMetabolico = 1;
         NivelCalorico = 2000;
      }
      public override double Metabolizar(Menu menu)
      {

         int totalCalorias = menu.GetCaloriasTotales();
         double calculoCalorias = totalCalorias * FactorMetabolico - 200;
         return calculoCalorias;
      }
      public override void GustaElPlato()
      {
         Console.Write("No");
      }
   }
   internal class Nosedecide : Comensal
   {
      public Nosedecide()
      {
         FactorMetabolico = 2;
         NivelCalorico = 1750;
      }
      public override void GustaElPlato()
      {
         Console.Write("No sé");
      }
      public override double Metabolizar(Menu menu)
      {

         int totalCalorias = menu.GetCaloriasTotales();
         double calculoCalorias = totalCalorias * FactorMetabolico - 150;
         return calculoCalorias;
      }
   }


   //RESTAURANT -----------------------------------------------
   class Restaurante
   {

      public Menu[] Menues = new Menu[3];

      public void CrearMenues()
      {

         for (int i = 0; i < Menues.Length; i++)

         {
            Menu unMenu = new Menu();
            unMenu.SetCaloriasIngredientes();

            Menues[i] = unMenu;
         }
      }
      public void CostoMenu() { }

      public void MostrarCaloriasMenues()
      {
         for (int i = 0; i < Menues.Length; i++)
         {
            int cantCalorias = Menues[i].GetCaloriasTotales();
            Console.WriteLine($"Las Calorias del menu° {i + 1} son: {cantCalorias}");

         }
      }

      public void GustaElPlato()
      {
         Console.Write("Le gustó el plato? ");
      }
      public Comensal ElegirComensal()
      {
         Random random = new Random();

         int numeroRandom = random.Next(1, 4);

         if (numeroRandom == 1)
         {
            return new Sedentario();

         }
         else if (numeroRandom == 2)
         {
            return new Nomade();
         }
         else
         {
            return new Nosedecide();
         }

      }

      public void RegistrarMenu()
      {
         using (StreamWriter escritor = new StreamWriter("wiiiEntendiObjetos.txt", true, System.Text.Encoding.Default))
         
         {
            int posi = 1;
            escritor.WriteLine("");
            foreach(Menu menu in Menues){
           
            escritor.WriteLine($"Precio Menu° {posi}: ${menu.GetCaloriasTotales()}");
            escritor.Flush();
            posi ++;
        
            }
           
         }
      }

      public void RegistrarCaloriasMenues()
      {
         int[] CaloriasIngredientes = new int[Menues[0].CantIngredientes * 3];
         int posi = 0;
         foreach (Menu elemMenu in Menues)
         {
            foreach (int calorias in elemMenu.CaloriasPorIngrediente)
            {
               CaloriasIngredientes[posi] = calorias;
               posi++;
            }
         }
         Array.Sort(CaloriasIngredientes);

         using (StreamWriter escritor = new StreamWriter("wiiiEntendiObjetos.txt", true, System.Text.Encoding.Default))

         {
            escritor.WriteLine("\nLas Calorias de cada ingrediente son: ");

            foreach (int elem in CaloriasIngredientes)
            {

               escritor.Write($"{elem} - ");

            }
            escritor.WriteLine("");
            escritor.Flush();

         }

      }
   }}

   // MENU -----------------------------------------------------------------------
    internal class Menu
   {
      public int CantIngredientes { get; } = 5;
       public int[] CaloriasPorIngrediente;

      public Menu()
      {
         CaloriasPorIngrediente = new int[CantIngredientes];
      }

      public void SetCaloriasIngredientes()
      {
         Random random = new Random();

         for (int i = 0; i < this.CaloriasPorIngrediente.Length; i++)
         {

            int numeroAleatorio = random.Next(200, 601);
            this.CaloriasPorIngrediente[i] = numeroAleatorio;
         }
      }
      public int GetCaloriasTotales()
      {
         int totCalorias = 0;
         for (int i = 0; i < this.CaloriasPorIngrediente.Length; i++)
         {
            totCalorias += this.CaloriasPorIngrediente[i];
         }

         return totCalorias;
      }
     
   }

