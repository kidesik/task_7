const int sidesCount = 12;
double perimeter = 0;

Console.WriteLine($"\nПожалуйста, введите длины {sidesCount} сторон:");

for (int i = 0; i < sidesCount; i++)
{
    Console.Write($"Введите длину стороны {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentSideLength))
    {
        perimeter += currentSideLength;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        i--;
    }
}

Console.WriteLine($"\nПериметр 12-угольника равен: **{perimeter}**");
