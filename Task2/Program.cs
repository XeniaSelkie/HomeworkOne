Console.Write("Введите первое число");
int.TryParse(Console.ReadLine(), out int FirstNumber);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out int SecondNumber);

if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"{FirstNumber} - большее число, {SecondNumber} - меньшее число");
}
    else
{
    Console.WriteLine($"{SecondNumber} - большее число, {FirstNumber} - меньшее число");
}
