﻿// Не используя рекурсию, выведите первые  N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] resultArray = Fibonacci(number);
Console.WriteLine($"Первые {number} чисел Фибоначчи: ");
PrintArray(resultArray);