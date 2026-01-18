const int sportsCount = 5;
double sumAthlete1 = 0;
double sumAthlete2 = 0;

Console.WriteLine($"\nВведите баллы для 5 видов спорта (вещественные числа):");

for (int i = 0; i < sportsCount; i++)
{
    Console.Write($"  Спортсмен 1, вид спорта {i + 1} баллы: ");
    if (double.TryParse(Console.ReadLine(), out double score1))
    {
        sumAthlete1 += score1;
    }
    else
    {
        Console.WriteLine("Ошибка ввода."); i--; continue;
    }

    Console.Write($"  Спортсмен 2, вид спорта {i + 1} баллы: ");
    if (double.TryParse(Console.ReadLine(), out double score2))
    {
        sumAthlete2 += score2;
    }
    else
    {
        Console.WriteLine("Ошибка ввода."); i--; continue;
    }
}

Console.WriteLine($"\nСумма баллов Спортсмена 1: **{sumAthlete1}**");
Console.WriteLine($"Сумма баллов Спортсмена 2: **{sumAthlete2}**");