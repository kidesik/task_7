const int count = 10;
double sumOfSquares = 0;

Console.WriteLine("Пожалуйста, введите 10 чисел:");

for (int i = 0; i < count; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentNumber))
    {
        sumOfSquares += (currentNumber * currentNumber);
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        i--;
    }
}

Console.WriteLine($"\nСумма квадратов всех 10 чисел равна: **{sumOfSquares}**");
