﻿// Задайте двумерный массив
// Напишите программу которая заменяет строки на столбцы.
// В случае если это не возможно, программа должна вывести сообщение для ползователя


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

int[,] CreateModifiedMatrix(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[i, j] = matrix[j, i];
        }
    }
    return matrix2;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 5);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Замена невозможна");
}
else
{
    int[,] matrix2 = CreateModifiedMatrix(matrix);
    PrintMatrix(matrix2);
}
