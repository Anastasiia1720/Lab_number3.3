using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 8, 1, 4, 9, 2 };
        (int min, int max) = FindMinMax(array);
        Console.WriteLine($"Найменший елемент: {min}");
        Console.WriteLine($"Найбільший елемент: {max}");
    }

    static (int, int) FindMinMax(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Масив не може бути пустим.");
        }

        int min = arr[0];
        int max = arr[0];

        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }

        return (min, max);
    }
}
