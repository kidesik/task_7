long sum = 0;
int count = 0;

Console.WriteLine("\nВведите последовательность целых чисел (0 завершает ввод):");

while (true)
{
    Console.Write($"Введите число {count + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int currentNumber))
    {
        sum += currentNumber;
        count++;

        if (currentNumber == 0)
        {
            break; 
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целое число.");
    }
}

Console.WriteLine($"\nа) Сумма всех чисел последовательности: **{sum}**");
Console.WriteLine($"б) Количество всех чисел последовательности: **{count}**");
