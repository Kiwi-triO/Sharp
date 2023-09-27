//using System;
//using System.Diagnostics;
//using System.Threading;

//class Programm {

//    //Итерационный метод извлечения корня n-ной степени
//    //используется для приближенного вычисления корня числа.
//    //Он основывается на итеративном применении формулы:
//    //описанной здесь: https://ru.wikipedia.org/wiki/Алгоритм_нахождения_корня_n-ной_степени

//    static double SquareRoot(double x, double n) {
//        double x0 = x / n; // начальное приближение
//        double eps = 0.0000000001; // точность
//        double a = x;

//        x = ((n - 1) * x0 + a / Math.Pow(x0, n - 1)) / n; // находим корень n-ой степени для х
//        while (Math.Abs(x0 - x) >= eps) // приближаем до заданной точности
//        {
//            x0 = x;
//            x = ((n - 1) * x0 + a / Math.Pow(x0, n - 1)) / n;
//        }
//        return x;
//    }
//    static void Main(string[] args) {
//        Console.Write("Введите число а = ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите число b = ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        for (int z = a; z <= b; z++)
//        {
//            for (int y = a; y < z; y++)
//            {
//                for (int x = a; x < y; x++)
//                {
//                    if ((Math.Abs(SquareRoot(x, 2.0) + SquareRoot(y, 2.0) - SquareRoot(z, 2.0))) % 1 == 0) // %1 - это проверка числа целое оно или дробное
//                        Console.WriteLine($"{x} {y} {z}");
//                }
//            }
//        }
                    
//    }
//}