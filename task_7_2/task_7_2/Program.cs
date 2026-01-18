Console.Write("Введите натуральное число N (количество чисел): ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода N. Введите корректное натуральное число.");
    return;
}

double sum = 0;

Console.WriteLine($"\nПожалуйста, введите {n} чисел:");

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentNumber))
    {
        sum += currentNumber;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        i--;
    }
}

Console.WriteLine($"\nСумма всех {n} чисел равна: **{sum}**");