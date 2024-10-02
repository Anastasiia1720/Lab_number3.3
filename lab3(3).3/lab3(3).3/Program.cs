using System;

class Program
{
    static void Main()
    {
        // Введення початкових даних
        Console.WriteLine("Введіть суму для конвертації:");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Введіть обмінний курс (наприклад, 1 USD = 36.74 UAH):");
        decimal exchangeRate = decimal.Parse(Console.ReadLine());

        // Виклик функції для конвертації
        decimal convertedAmount = ConvertCurrency(amount, exchangeRate);

        Console.WriteLine($"Конвертована сума: {convertedAmount:F2}");
    }

    static decimal ConvertCurrency(decimal amount, decimal exchangeRate)
    {
        // Обчислення конвертованої суми
        return amount * exchangeRate;
    }
}
