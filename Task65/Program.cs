// Задайте значение N. 
//  Напишите программу, которая выдаёт все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNambers(number);

void NaturalNambers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNambers(num - 1);
    
}