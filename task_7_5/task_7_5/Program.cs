decimal totalSalary = 0; 
int employeeCount = 0;

Console.WriteLine("\nВведите зарплату каждого сотрудника (введите 0 или отрицательное число для завершения):");

while (true)
{
    Console.Write($"Введите зарплату сотрудника {employeeCount + 1}: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal currentSalary))
    {
        if (currentSalary <= 0)
        {
            break; 
        }
        totalSalary += currentSalary;
        employeeCount++;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
    }
}

Console.WriteLine($"\nОбщая сумма зарплаты для {employeeCount} сотрудников равна: **{totalSalary:C2}**");
