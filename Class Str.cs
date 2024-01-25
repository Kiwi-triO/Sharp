using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program {

    public class Str {
        //Поля
        private string line;

        //Конструкторы
        public Str(string str) {
            line = str;
        }
        //Метод подсчета цифр в строке
        public int CountDigits() {
            int count = 0;
            foreach (char c in line) {
                if (Char.IsDigit(c))
                    count++;
            }
            return count;
        }

        //Метод выводящий уникальные символы
        public void PrintUnique() {
            Console.Write("Уникальные символы: ");
            foreach (char c in line) {
                if (line.IndexOf(c) == line.LastIndexOf(c))
                    Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        //Метод вывода самой длинной последовательности
        public void PrintTheLongest() {
            int maxLength = 0;
            int length = 1;
            char longestChar = '\0';
            char prevChar = line[0];

            for (int i = 1; i < line.Length; i++) {
                if (line[i] == prevChar) {
                    length++;
                    if (length > maxLength) {
                        maxLength = length;
                        longestChar = prevChar;
                    }
                }
                else {
                    length = 1;
                    prevChar = line[i];
                }
            }

            if (maxLength > 1) {
                Console.WriteLine("Самая длинная последовательность повторяющихся символов: " + longestChar + " (Длина: " + maxLength + ")");
            }
            else {
                Console.WriteLine("Последовательность не найдена");
            }
        }

        //Общее кол-во символов в строке
        public int Length {
            get { return line.Length; }
        }

        //Индексатор
        public char this[int index] {
            get { return line[index]; }
        }

        // Перегруженный оператор ! возвращает true, если строка не является пустой или null.
        public static bool operator !(Str str) {
            return !string.IsNullOrEmpty(str.line);
        }

        // Перегруженный оператор true возвращает true, если строка является палиндромом.
        // Метод IsPalindrome() используется для проверки, является ли строка палиндромом.
        public static bool operator true(Str str) {
            return IsPalindrome(str.line);
        }

        // Перегруженный оператор false возвращает true, если строка не является палиндромом.
        public static bool operator false(Str str) {
            return !IsPalindrome(str.line);
        }

        // Перегруженный оператор неявного преобразования позволяет преобразовать объект StringOperation в строку.
        public static implicit operator string(Str str) {
            return str.line;
        }

        // Перегруженный оператор явного преобразования позволяет преобразовать строку в объект класса Str.
        public static explicit operator Str(string str) {
            return new Str(str);
        }

        // Метод IsPalindrome() используется для проверки, является ли строка палиндромом.
        private static bool IsPalindrome(string str) {
            int left = 0;
            int right = str.Length - 1;

            while (left < right) {
                if (str[left++] != str[right--])
                    return false;
            }

            return true;
        }
    }
}