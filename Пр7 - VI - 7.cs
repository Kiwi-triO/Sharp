//using System;

//class Program {
//    static void Main(string[] args) {
//        // Ввод размерности массива
//        Console.Write("Введите размерность массива: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int m = n;
//        // Создание и заполнение массива
//        int[,] arr = new int[n, n];
//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("a[{0},{1}]= ", i, j);
//                arr[i, j] = Convert.ToInt32(Console.ReadLine());
//            }
//        }

//        // Проверка и удаление столбцов
//        for (int j = 0; j < n; j++)
//        {
//            if (arr[0, j] > arr[n-1, j])
//            {
//                // Сдвиг элементов влево
//                for (int i = 0; i < n; i++)
//                {
//                    for (int k = j; k < m - 1; k++)
//                    {
//                        arr[i, k] = arr[i, k + 1];
//                    }
//                }
//                m--; // Уменьшение размерности столбцов
//                j--; // Проверяем повторно текущий столбец, так как все столбцы сдвинулись
//            }
//        }

//        // Вывод обработанного массива
//        Console.WriteLine("Результат:");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write(arr[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}