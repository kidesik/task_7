const int count = 9;
long sum = 0;

Console.WriteLine("\nПожалуйста, введите 9 целых чисел:");

for (int i = 0; i < count; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int currentNumber))
    {
        sum += currentNumber;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целое число.");
        i--;
    }
}

bool isSumEven = (sum % 2 == 0);
string resultText = isSumEven ? "Да, четное" : "Нет, нечетное";

Console.WriteLine($"\nСумма всех 9 чисел равна: {sum}");
Console.WriteLine($"Верно ли, что сумма есть четное число? **{resultText}**");
    