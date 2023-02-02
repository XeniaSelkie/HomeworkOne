Console.Write("Введите первое число");
int.TryParse(Console.ReadLine(), out int FirstNumber);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out int SecondNumber);
Console.WriteLine("Введите третье число");
int.TryParse(Console.ReadLine(), out int ThirdNumber);

if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
Console.WriteLine($"{FirstNumber} - максимальное число из трёх введённых");
}
else if (SecondNumber > FirstNumber && SecondNumber > ThirdNumber)
    {
    Console.WriteLine($"{SecondNumber} - максимальное число из трёх введённых");
    }
    else 
    {
    Console.WriteLine($"{ThirdNumber} - максимальное число из трёх введённых");
    }


  