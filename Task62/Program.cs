// Задайте значения M и N. 
// Напишите программу,
// которая выведет все натуральные числа в промежутке от M и N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number1, number2);
void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        NaturalNumbers(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);  
    }
    if (num1 == num2)
        Console.Write($"{num1} ");
}
