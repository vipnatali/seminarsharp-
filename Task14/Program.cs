﻿
// Написать программу
// Принимает на вход трёхзначное число
// На выход паказывает вторую цифру этого числа
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Число {number} ");

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10 % 10;
Console.WriteLine($"Второе число: {a}");