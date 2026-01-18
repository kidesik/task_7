double totalMass = 0;
int itemCount = 0;

Console.WriteLine("\nВведите массу каждого предмета (введите 0 или отрицательное число для завершения ввода):");

while (true)
{
    Console.Write($"Введите массу предмета {itemCount + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentMass))
    {
        if (currentMass <= 0)
        {
            break; 
        }
        totalMass += currentMass;
        itemCount++;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
    }
}

Console.WriteLine($"\nОбщая масса груза из {itemCount} предметов равна: **{totalMass}**");
