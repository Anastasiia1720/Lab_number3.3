using System;

class Program
{
    static void Main()
    {
        // Введення рядка
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        // Виклик функції для підрахунку голосних та приголосних
        (int vowels, int consonants) = CountVowelsAndConsonants(input);

        Console.WriteLine($"Кількість голосних: {vowels}");
        Console.WriteLine($"Кількість приголосних: {consonants}");
    }

    static (int, int) CountVowelsAndConsonants(string input)
    {
        // Набори голосних і приголосних
        string vowelsSet = "AEIOUYaeiouy";
        string consonantsSet = "BCDFGHJKLMNPQRSTVWXZbcdfghjklmnpqrstvwxz";

        int vowelCount = 0;
        int consonantCount = 0;

        // Перебір кожного символу в рядку
        foreach (char c in input)
        {
            if (vowelsSet.Contains(c))
            {
                vowelCount++;
            }
            else if (consonantsSet.Contains(c))
            {
                consonantCount++;
            }
        }

        // Повернення результату як кортеж
        return (vowelCount, consonantCount);
    }
}

