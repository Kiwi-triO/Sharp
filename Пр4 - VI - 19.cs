using System;
using System.Diagnostics;

namespace StopwatchExample
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int count_b = (Math.Floor(Math.Sqrt(b) * Math.Sqrt(b)) == b) ? 1 : 0;
            int count_a = (Math.Floor(Math.Sqrt(a) * Math.Sqrt(a)) == a) ? 1 : 0;
            for (int i = 1; i * i < a; i++)
            {
                if (a % i == 0)
                {
                    count_a += 2;
                }
            }
            for (int i = 1; i * i < b; i++)
            {
                if (b % i == 0)
                {
                    count_b += 2;
                }
            }
            int answer = (count_a > count_b) ? a : b;
            Console.Write("Больше делителей у числа ");
            Console.WriteLine((answer == a) ? "a = " + a : "b = " + b);
        }
    }
}

