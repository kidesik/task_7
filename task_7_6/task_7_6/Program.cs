double totalResistance = 0;
int elementCount = 0;

Console.WriteLine("\nВведите сопротивление каждого элемента (в Омах). Введите 0 или отрицательное число для завершения:");

while (true)
{
    Console.Write($"Введите R{elementCount + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentResistance))
    {
        if (currentResistance <= 0)
        {
            break;
        }
        totalResistance += currentResistance; 
        elementCount++;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
    }
}

Console.WriteLine($"\nОбщее сопротивление цепи из {elementCount} элементов равно: **{totalResistance}** Ом");
