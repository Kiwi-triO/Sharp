//using System;

//class Program {
//    static void Main(string[] args) {
//        // Ввод размерности массива
//        Console.Write("Введите размерность массива: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int m = n;
//        // Создание и заполнение массива
//        int[][] arr = new int[n][];

//        for (int i = 0; i < n; i++) {
//            arr[i] = new int[m];
//        }

//        Console.WriteLine("Введите элементы массива:");
//        for (int i = 0; i < n; i++) {
//            for (int j = 0; j < n; j++) {
//                Console.Write("a[{0},{1}]= ", i, j);
//                arr[j][i] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        Console.WriteLine("Исходный массив");
//        for (int i = 0; i < m; i++) {
//            for (int j = 0; j < n; j++) {
//                Console.Write(arr[j][i] + " ");
//            }
//            Console.WriteLine();
//        }
//        // Проверка и удаление столбцов
//        for (int j = 0; j < n; j++) {
//            if (arr[j][0] > arr[j][m - 1]) {
//                for (int i = j; i < n - 1; i++)
//                    arr[i] = arr[i + 1];
//                n--; // Уменьшение размерности столбцов
//                j--; // Проверяем повторно текущий столбец, так как все столбцы сдвинулись
//            }
//        }

//        // Вывод обработанного массива
//        Console.WriteLine("Результат:");
//        for (int i = 0; i < m; i++) {
//            for (int j = 0; j < n; j++) {
//                Console.Write(arr[j][i] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}