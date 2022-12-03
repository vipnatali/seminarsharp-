﻿// Задайте двумерный массив размера m на n, 
// каждый элемент массива находится по формуле:
// Amn = m + n
// Ввыведите полученный массив на экран.

// m = 3, n = 4.
// 0123
// 1234
// 2345

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4 } ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);
