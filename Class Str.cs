using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program {

    public class Str {
        //����
        private string line;

        //������������
        public Str(string str) {
            line = str;
        }
        //����� �������� ���� � ������
        public int CountDigits() {
            int count = 0;
            foreach (char c in line) {
                if (Char.IsDigit(c))
                    count++;
            }
            return count;
        }

        //����� ��������� ���������� �������
        public void PrintUnique() {
            Console.Write("���������� �������: ");
            foreach (char c in line) {
                if (line.IndexOf(c) == line.LastIndexOf(c))
                    Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        //����� ������ ����� ������� ������������������
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
                Console.WriteLine("����� ������� ������������������ ������������� ��������: " + longestChar + " (�����: " + maxLength + ")");
            }
            else {
                Console.WriteLine("������������������ �� �������");
            }
        }

        //����� ���-�� �������� � ������
        public int Length {
            get { return line.Length; }
        }

        //����������
        public char this[int index] {
            get { return line[index]; }
        }

        // ������������� �������� ! ���������� true, ���� ������ �� �������� ������ ��� null.
        public static bool operator !(Str str) {
            return !string.IsNullOrEmpty(str.line);
        }

        // ������������� �������� true ���������� true, ���� ������ �������� �����������.
        // ����� IsPalindrome() ������������ ��� ��������, �������� �� ������ �����������.
        public static bool operator true(Str str) {
            return IsPalindrome(str.line);
        }

        // ������������� �������� false ���������� true, ���� ������ �� �������� �����������.
        public static bool operator false(Str str) {
            return !IsPalindrome(str.line);
        }

        // ������������� �������� �������� �������������� ��������� ������������� ������ StringOperation � ������.
        public static implicit operator string(Str str) {
            return str.line;
        }

        // ������������� �������� ������ �������������� ��������� ������������� ������ � ������ ������ Str.
        public static explicit operator Str(string str) {
            return new Str(str);
        }

        // ����� IsPalindrome() ������������ ��� ��������, �������� �� ������ �����������.
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