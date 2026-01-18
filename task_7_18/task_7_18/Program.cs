Console.Write("Введите натуральное число N (количество чисел): ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Ошибка ввода N."); return;
}

Console.Write("Введите целое число 'b' (делитель): ");
if (!int.TryParse(Console.ReadLine(), out int b))
{
    Console.WriteLine("Ошибка ввода b."); return;
}

long sum = 0;
Console.WriteLine($"\nПожалуйста, введите {n} целых чисел:");

for (int i = 0; i < n; i++)
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

string resultText;
if (b == 0)
{
    resultText = "Нельзя проверить кратность нулю (деление на ноль).";
}
else
{
    bool isSumMultipleOfB = (sum % b == 0);
    string yesNo = isSumMultipleOfB ? "Да, кратна" : "Нет, не кратна";
    resultText = $"Верно ли, что сумма кратна числу b ({b})? **{yesNo}**";
}

Console.WriteLine($"\nСумма всех {n} чисел равна: {sum}");
Console.WriteLine(resultText);