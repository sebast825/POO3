namespace clase5
{
    interface IPelota
    {
        void Distancia(int f);
       void Curvatura(int f);
    }

    internal class Pelota
    {
 public virtual void Curvatura(int f)
        {
            Console.WriteLine(10 * f);
        }
    }

    internal class Tenis : Pelota, IPelota
    {
        public void Distancia(int f)
        {
            Console.WriteLine(50 * f);
        }
    }

    internal class Futbol : Pelota, IPelota
    {

        public void Distancia(int f)
        {
            Console.WriteLine(40 * f);
        }
    }
}