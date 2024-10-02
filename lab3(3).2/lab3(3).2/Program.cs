using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} є простим числом.");
        }
        else
        {
            Console.WriteLine($"{number} не є простим числом.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
