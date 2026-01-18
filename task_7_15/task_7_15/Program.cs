const int count = 10;
double sum = 0;
const double threshold = 100.78;

Console.WriteLine("Пожалуйста, введите 10 чисел:");

for (int i = 0; i < count; i++)
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

bool isSumGreaterThanThreshold = sum > threshold;
string resultText = isSumGreaterThanThreshold ? "Да, превышает" : "Нет, не превышает";

Console.WriteLine($"\nСумма всех 10 чисел равна: {sum}");
Console.WriteLine($"Верно ли, что сумма превышает {threshold}? **{resultText}**");
