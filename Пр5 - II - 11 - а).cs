//using System;
//using System.Diagnostics;
//class Programm {

//    //Итерационный метод извлечения корня n-ной степени
//    //используется для приближенного вычисления корня числа.
//    //Он основывается на итеративном применении формулы Ньютона

//    static double SquareRoot(double x, double n) {
//        double x0 = x / n; // начальное приближение
//        double eps = 0.00001; // точность
//        double a = x;

//        x = ((n - 1) * x0 + a / Math.Pow(x0, n - 1)) / n; // находим корень n-ой степени для х
//        while (Math.Abs(x0 - x) >= eps) // приближаем до заданной точности
//        {
//            x0 = x;
//            x = ((n - 1) * x0 + a / Math.Pow(x0, n - 1)) / n;
//        }
//        return x;
//    }
//    //Примечание: использование формулы Герона для корня 2-ой степени не привела к ускорению работы программы
//    static void Main(string[] args) {
//        Console.Write("Введите число а = ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Введите число b = ");
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Введите число h = ");
//        double h = Convert.ToDouble(Console.ReadLine());
//        double n = 1;
//        var sw = new Stopwatch();
//        sw.Start();
//        for (double x = a; x <= b; x += h, n++)
//        {
//            if (x != 0)
//            {
//                double result = SquareRoot(x, n);
//                Console.WriteLine($"Корень степени {n} для числа {x} равен {result}");
//            }
//            else
//            {
//                double result = 0;
//                Console.WriteLine($"Корень степени {n} для числа {x} равен {result}");
//            }
//        }
//        sw.Stop();
//        Console.WriteLine(sw.Elapsed);
//    }
//}