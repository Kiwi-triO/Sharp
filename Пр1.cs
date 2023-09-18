using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        Console.Write("Номинал купюры = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Количество купюр = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Сумма денег = " + "{0,0:C}", a * b);
    }
}