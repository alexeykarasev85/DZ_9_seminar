// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumNumbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbers(numberM, numberN, sum);
}

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int numberN = Convert.ToInt32(Console.ReadLine());
SumNumbers(numberM, numberN, 0);