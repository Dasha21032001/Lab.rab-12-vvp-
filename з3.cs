using System;

namespace задание_3
{
    class Program
    {
        static double RingS(double r1, double r2)
        {
            return Math.PI * Math.Abs(Math.Pow(r1, 2)- Math.Pow(r2, 2));
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите внешний радиус кольца: ");
                double r1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите внутренний радиус кольца: ");
                double r2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь  кольца равна\n" +RingS(r1, r2));
            }
        }


    }
    
}
