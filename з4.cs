using System;

namespace задание_4
{
    class Program
    {
        public static int Quarter(double x, double y)
        {
            int resultat = 0;

            if (x > 0)
            {
                if (y > 0)
                    resultat = 1;
                else if (y < 0)
                    resultat = 4;
            }
            else
            {
                if (y > 0)
                    resultat = 2;
                else if (y < 0)
                    resultat = 3;
            }

            return resultat;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.Write("\nВведите ненулевую координату x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВведите ненулевую координату y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                if ((x != 0) && (y != 0))
                {
                    Console.Write("\nКоординатная четверть: " + Quarter(x,y));
                }
                else { Console.Write("Ошибка"); }
            }
        }
    }
}
