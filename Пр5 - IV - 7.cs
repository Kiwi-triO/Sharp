//using System;

//class ReverseDigits {
//    public static void Main(string[] args) {
//        int a = Convert.ToInt32(Console.ReadLine()); // начало отрезка
//        int b = Convert.ToInt32(Console.ReadLine()); // конец отрезка

//        // Вывод цифр чисел от a до b в обратном порядке.
//        for (int i = a; i <= b; i++)
//        {
//            Console.Write("Число " + i + ": ");
//            PrintDigitsReverse(i);
//            Console.WriteLine();
//        }
//    }

//    // Рекурсивный метод для вывода цифр числа в обратном порядке.
//    private static void PrintDigitsReverse(int number) {
//        if (number < 10)
//        {
//            Console.Write(number); // если число однозначное
//        }
//        else
//        {
//            Console.Write(number % 10); // вывод последней цифры
//            PrintDigitsReverse(number / 10); // рекурсивный вызов для оставшихся цифр
//        }
//    }
//}

