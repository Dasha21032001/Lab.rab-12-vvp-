using System;

namespace задание_5
{
    class Program
    {
        static double Fact2(double N)
        {
            double result = 1;
            for (int i = N % 2 == 0 ? 2 : 1; i <= N; i += 2)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact2(N));
        }
    }
}
