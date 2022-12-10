﻿// Задайте значение N. 
// Напишите программу,
//  которая выдаёт все натуральные числа в промежутке от 1 до N.

//  N = 5-> "1, 2, 3, 4, 5, "
//  N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNambers(number);

void NaturalNambers(int num)
{
    if (num == 0) return;
    NaturalNambers(num - 1);
    Console.WriteLine($"{num}");
}