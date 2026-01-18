Console.Write("Введите целое пороговое значение P: ");
if (!int.TryParse(Console.ReadLine(), out int p))
{
    Console.WriteLine("Ошибка ввода P."); return;
}

const int count = 10;
long sum = 0;

Console.WriteLine($"\nПожалуйста, введите 10 целых чисел:");

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

bool isSumLessThanP = sum < p;
string resultText = isSumLessThanP ? "Да, меньше" : "Нет, не меньше";

Console.WriteLine($"\nСумма всех 10 чисел равна: {sum}");
Console.WriteLine($"Верно ли, что сумма меньше P ({p})? **{resultText}**");
