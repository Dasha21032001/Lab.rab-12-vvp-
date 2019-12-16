using System;

namespace Лаб.раб__12
{
    class Program
    {
        static void PowerA3(double A, out double B)
        { 
            B = A * A * A;
        }
        static void Main(string[] args)
        {
            double B;
            for (int i = 2; i < 7; i++)
            {
                PowerA3(i,  out B);
                Console.WriteLine(B);
            }
        }
    }
}
