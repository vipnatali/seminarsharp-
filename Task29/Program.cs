﻿// Напишите программу, 
// которая принимает на вход число и
//  выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

    int count = 0;
    while (number > 0)
    {
        int num = number % 10;
       number = number / 10;
        count = count + num;
    }
 Console.WriteLine($"Сумма чисел:  " + count);