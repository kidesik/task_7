const int count = 10;
double product = 1.0; 

Console.WriteLine("Пожалуйста, введите 10 чисел:");

for (int i = 0; i < count; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out double currentNumber))
    {
        product *= currentNumber; 
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        i--;
    }
}

Console.WriteLine($"\nПроизведение всех 10 чисел равно: **{product}**");
