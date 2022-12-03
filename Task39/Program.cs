﻿using System;
// Напишите программу
//  которая перевернёт однамерный массив
//  (последний элемент будет на первом месте)

//  [12345] -> [54321]

int[] CreateArrayRndInt (int size, int min, int max) 
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array [i];
        array[i] = array[array.Length - 1 - i];
       array[array.Length - 1 - i] = temp;
    }
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);