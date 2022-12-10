// Задайте значение M и N.
//  Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M и N.
// Выполнить с помощью рекурсии. 

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите значение M: ");
int sum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int sum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SummaDigits(sum, sum1));

int SummaDigits(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SummaDigits(num1, num2 - 1);
    else return num2 + SummaDigits(num1, num2 + 1);
}