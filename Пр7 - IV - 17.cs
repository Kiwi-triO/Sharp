//using System;

//class Program {
//    static void Main(string[] args) {
//        // Ввод размерности массива
//        Console.Write("Введите размерность массива: ");
//        int n = Convert.ToInt32(Console.ReadLine());

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

//        // Создание и заполнение массива с суммами строк
//        int[] rowSums = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < n; j++)
//            {
//                sum += arr[i, j];
//            }
//            rowSums[i] = sum;
//        }

//        // Нахождение максимального элемента нового массива
//        int maxElement = rowSums[0];
//        for (int i = 1; i < n; i++)
//        {
//            if (rowSums[i] > maxElement)
//            {
//                maxElement = rowSums[i];
//            }
//        }

//        // Вывод результата
//        Console.WriteLine($"Максимальный элемент нового массива: {maxElement}");
//    }
//}