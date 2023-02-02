Console.Write("Введите число");
int.TryParse(Console.ReadLine(), out int JustNumber);
int TestForEven = JustNumber % 2;
if (TestForEven == 0)
{
    Console.WriteLine($"Число {JustNumber} - чётное");
}
    else
{
    Console.WriteLine($"Число {JustNumber} - нечётное");
}