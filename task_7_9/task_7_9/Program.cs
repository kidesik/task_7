const int subjectsCount = 4;
int sumStudent1 = 0;
int sumStudent2 = 0;

Console.WriteLine($"\nВведите оценки для 4 предметов (целые числа):");

for (int i = 0; i < subjectsCount; i++)
{
    Console.Write($"  Ученик 1, предмет {i + 1} оценка: ");
    if (int.TryParse(Console.ReadLine(), out int mark1))
    {
        sumStudent1 += mark1;
    }
    else
    {
        Console.WriteLine("Ошибка ввода."); i--; continue;
    }

    Console.Write($"  Ученик 2, предмет {i + 1} оценка: ");
    if (int.TryParse(Console.ReadLine(), out int mark2))
    {
        sumStudent2 += mark2;
    }
    else
    {
        Console.WriteLine("Ошибка ввода."); i--; continue;
    }
}

Console.WriteLine($"\nСумма оценок Ученика 1: **{sumStudent1}**");
Console.WriteLine($"Сумма оценок Ученика 2: **{sumStudent2}**");
