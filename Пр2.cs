using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        string e = ((a + b > c) && (a + c > b) && (b + c > a)) ? "YES" : "NO";
        Console.Write($"{e}");

    }
}