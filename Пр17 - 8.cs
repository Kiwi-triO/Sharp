using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string input = "Hello World!1233345";
            Str str = new Str(input);

            // Вызов метода CountDigits()
            int digitsCount = str.CountDigits();
            Console.WriteLine("Number of digits in the string: " + digitsCount);

            // Вызов метода PrintUniqueCharacters()
            str.PrintUniqueCharacters();

            // Вызов метода PrintLongestSequence()
            str.PrintLongestSequence();

            // Обращение к свойству Length
            Console.WriteLine("Length of the string: " + str.Length);

            // Обращение к элементам строки через индексатор
            for (int i = 0; i < str.Length; i++) {
                Console.WriteLine("Character at index " + i + ": " + str[i]);
            }

            // Проверка оператора !
            if (!str) {
                Console.WriteLine("String is null or empty");
            }
            else {
                Console.WriteLine("String is not null or empty");
            }

            // Проверка оператора true
            if (str) {
                Console.WriteLine("String is a palindrome");
            }
            else {
                Console.WriteLine("String is not a palindrome");
            }

            // Проверка оператора false
            if (!str) {
                Console.WriteLine("String is not a palindrome");
            }
            else {
                Console.WriteLine("String is a palindrome");
            }

            // Создание второго объекта Str
            string input2 = "hello world!";
            Str str2 = new Str(input2);

            // Проверка оператора &
            if (str & str2) {
                Console.WriteLine("Strings are equal");
            }
            else {
                Console.WriteLine("Strings are not equal");
            }

            // Переобразование объекта Str в string
            string str3 = str;

            // Переобразование string в объект Str
            Str str4 = (Str)input;
        }
    }
}