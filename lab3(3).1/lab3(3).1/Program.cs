using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача ввести перший операнд
        Console.WriteLine("Введіть перший операнд:");
        double operand1 = double.Parse(Console.ReadLine());

        // Запитуємо користувача ввести другий операнд
        Console.WriteLine("Введіть другий операнд:");
        double operand2 = double.Parse(Console.ReadLine());

        // Запитуємо користувача ввести операцію (+, -, *, /)
        Console.WriteLine("Введіть операцію (+, -, *, /):");
        string operation = Console.ReadLine();

        // Викликаємо функцію для виконання обчислення
        double result = Calculate(operand1, operand2, operation);

        // Виводимо результат
        Console.WriteLine("Результат: " + result);
    }

    // Функція для виконання обчислення
    static double Calculate(double operand1, double operand2, string operation)
    {
        switch (operation)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                if (operand2 != 0)
                {
                    return operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("Помилка: Ділення на нуль!");
                    return double.NaN; // Повертаємо NaN, якщо ділення на нуль
                }
            default:
                Console.WriteLine("Невідома операція!");
                return double.NaN; // Повертаємо NaN для невідомих операцій
        }
    }
}

