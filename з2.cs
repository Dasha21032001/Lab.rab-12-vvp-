using System;

namespace задание_2
{
    class Program
    {
      static void Sign(double X, out int y)
         {  
             y = 0;
            if (X < 0)
            {
                y = -1;
            }
            else
            {
                if (X > 0)
                {
                    y = 1;
                }
                else
                {
                    if (X == 0)
                    {
                        y = 0;
                    }
                }
            }
         }
            static void Main(string[] args)
            {
                int y, x, sum;
                double A, B;
                Console.Write("Введите A: ");
                A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите B: ");
                B = Convert.ToDouble(Console.ReadLine());
                x = 0;
                y = 0;
                Sign(A, out x);
                Sign(B, out y);
                sum = x + y;
                Console.WriteLine(sum);
            }
        }
    }
