Console.Write("Введите число");
int.TryParse(Console.ReadLine(), out int NumberN);
int TestForEven = 0;
Console.Write("Чётные числа от 1 до введённого числа: ");
if (NumberN == 1) 
{
 Console.Write("таких не существует.");   
}
else if (NumberN < 1)
     {
         while (NumberN < 1)
         {
         if (TestForEven == NumberN % 2)
         {Console.Write($"{NumberN}, ");
         }
         NumberN = NumberN + 1;
         }  
     }
    else
    while (NumberN > 1)
    {
    if (TestForEven == NumberN % 2)
    {Console.Write($"{NumberN}, ");
    }
    NumberN = NumberN - 1;
    }