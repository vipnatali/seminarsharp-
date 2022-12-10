﻿// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3 } ");
        }
        Console.WriteLine("|");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++]= matrix[i, j];
        }
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.WriteLine("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0, 4}", arr[i]);
        Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.Write("]\n");
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i <arr.Length; i++)
    {
       if (arr[i] == num) count++;
       else
       {
        PrintMessage(num, count);
        count = 1;
        num = arr[i];
       } 
    }
    PrintMessage(num, count);
}

void PrintMessage(int num, int count)
{
    Console.WriteLine($"{num} встречается {count} раз.");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int[] array = MatrixToArray(array2D);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountValue(array);