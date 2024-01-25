using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string input = "Hello World!1233345";
            Str str = new Str(input);

            // ����� ������ CountDigits()
            int digitsCount = str.CountDigits();
            Console.WriteLine("Number of digits in the string: " + digitsCount);

            // ����� ������ PrintUniqueCharacters()
            str.PrintUniqueCharacters();

            // ����� ������ PrintLongestSequence()
            str.PrintLongestSequence();

            // ��������� � �������� Length
            Console.WriteLine("Length of the string: " + str.Length);

            // ��������� � ��������� ������ ����� ����������
            for (int i = 0; i < str.Length; i++) {
                Console.WriteLine("Character at index " + i + ": " + str[i]);
            }

            // �������� ��������� !
            if (!str) {
                Console.WriteLine("String is null or empty");
            }
            else {
                Console.WriteLine("String is not null or empty");
            }

            // �������� ��������� true
            if (str) {
                Console.WriteLine("String is a palindrome");
            }
            else {
                Console.WriteLine("String is not a palindrome");
            }

            // �������� ��������� false
            if (!str) {
                Console.WriteLine("String is not a palindrome");
            }
            else {
                Console.WriteLine("String is a palindrome");
            }

            // �������� ������� ������� Str
            string input2 = "hello world!";
            Str str2 = new Str(input2);

            // �������� ��������� &
            if (str & str2) {
                Console.WriteLine("Strings are equal");
            }
            else {
                Console.WriteLine("Strings are not equal");
            }

            // ��������������� ������� Str � string
            string str3 = str;

            // ��������������� string � ������ Str
            Str str4 = (Str)input;
        }
    }
}