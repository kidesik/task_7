long currentProduct = 1; 
int numberCount = 0;

Console.WriteLine("\nВведите последовательность положительных целых чисел (0 завершает ввод):");

while (true)
{
    Console.Write($"Введите число {numberCount + 1}: ");
    if (long.TryParse(Console.ReadLine(), out long currentNumber))
    {
        if (currentNumber == 0)
        {
            Console.WriteLine("0");
            break;
        }

        if (currentNumber < 0)
        {
            Console.WriteLine("Ошибка: число должно быть положительным.");
            continue;
        }

        currentProduct *= currentNumber;
        Console.WriteLine(currentProduct);
        numberCount++;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное целое число.");
    }
}