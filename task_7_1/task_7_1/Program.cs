double[] numbers = new double[10];
double sum = 0;

Console.WriteLine("Пожалуйста, введите 10 чисел:");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    if (double.TryParse(Console.ReadLine(), out numbers[i]))
    {
        sum += numbers[i]; 
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        i--; 
    }
}

Console.WriteLine($"\nСумма всех 10 чисел равна: **{sum}**");