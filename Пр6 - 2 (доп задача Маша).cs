//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace a {
//    class Program {
         
//        static double CalculateRoot(double x, int n) {
//            Stopwatch sw = new Stopwatch();
//            Console.WriteLine("\nИтерационный метод оптимизированный");
//            double guess = x / n;
//            double eps = 0.0000001;
//            sw.Start();
//            while (true) {
//                double prevGuess = guess;
//                guess = (1.0 / n) * ((n - 1) * guess + x / Math.Pow(guess, n - 1));

//                if (Math.Abs(prevGuess - guess) < eps) {
//                    break;
//                }
//            }
//            sw.Stop();
//            Console.WriteLine("Время работы в тактах: " + sw.ElapsedTicks);
//            return guess;
//        }

//        static void Main(string[] args) {
//            Console.WriteLine("Введите значение А(число под корнем): ");
//            double A = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите значение n(степень корня): ");
//            int n = int.Parse(Console.ReadLine());
           
//            Console.WriteLine("Стандартный метод");
//            Stopwatch sw = Stopwatch.StartNew();
//            double res = Math.Pow(A, 1.0 / n);
//            sw.Stop();
//            Console.WriteLine("Время работы в тактах: " + sw.ElapsedTicks);
//            Console.WriteLine("Ответ: " + res);

//            Console.WriteLine("Ответ: " + CalculateRoot(A, n) + '\n');


//        }

//    }
//}