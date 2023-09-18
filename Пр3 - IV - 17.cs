using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        int k = 101; //самое первое подходящее число
        for (int i = 1; i < 10; i++)
        {
            for (int j = k; j < (k + 100); j += 10) //прохожу по всем десяткам трехзначного числа
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            k += 101;
        }

    }
}

