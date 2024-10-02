using System;

class GeometricCalculator
{
    static void Main()
    {
        Console.WriteLine("Геометричний калькулятор");
        Console.WriteLine("1. Обчислити площу кола");
        Console.WriteLine("2. Обчислити площу прямокутника");
        Console.WriteLine("3. Обчислити об'єм куба");
        Console.Write("Виберіть опцію (1, 2 або 3): ");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CalculateCircleArea();
                break;
            case 2:
                CalculateRectangleArea();
                break;
            case 3:
                CalculateCubeVolume();
                break;
            default:
                Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                break;
        }
    }

    static void CalculateCircleArea()
    {
        Console.Write("Введіть радіус кола: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площа кола: {area:F2}");
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Введіть довжину прямокутника: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Введіть ширину прямокутника: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        Console.WriteLine($"Площа прямокутника: {area:F2}");
    }

    static void CalculateCubeVolume()
    {
        Console.Write("Введіть довжину сторони куба: ");
        double side = double.Parse(Console.ReadLine());

        double volume = Math.Pow(side, 3);
        Console.WriteLine($"Об'єм куба: {volume:F2}");
    }
}
