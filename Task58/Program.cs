﻿//  Сформируйте трёхмерный массив из
// неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.




void PrintMatrix(int[,,] matrix, int indexI, int indexJ, int indexK)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1)
                    Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k}) ");
                else Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("|");
    }
}

int[] ConvertMatrixToArray(int rows, int columns, int dept, int minElement, int maxElement)
{
    Random rnd = new Random();
    int[] array = new int[rows * columns * dept];
    for (int i = 0; i < rows * columns * dept; ++i)
    {
        bool elementsUnique;
        do
        {
            array[i] = rnd.Next(minElement, maxElement);
            elementsUnique = true;
            for (int j = 0; j < i; ++j)
                if (array[i] == array[j])
                {
                    elementsUnique = false;
                    break;
                }
        } while (!elementsUnique);
    }
    return array;
}

void ArrayAllPrint(int[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("|");
}

(int[,,], int, int, int) NewMatrix(int[] array, int row, int columns, int dept)
{
    int[,,] matrix2 = new int[row, columns, dept];
    int x = 0;
    int indexI = 0;
    int indexJ = 0;
    int indexK = 0;
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(2); k++)
            {
                matrix2[i, j, k] = array[x];
                indexI = i;
                indexJ = j;
                indexK = k;
                x++;
            }
        }
    }
    return (matrix2, indexI, indexJ, indexK);
}

int[] array = ConvertMatrixToArray(2, 2, 2, 10, 99);
Console.WriteLine();
ArrayAllPrint(array);
Console.WriteLine();
(int[,,] matrix3, int i, int j, int k) = NewMatrix(array, 2, 2, 2);
Console.WriteLine();
Console.WriteLine(@"Трёхмерная матрица");
Console.WriteLine();
PrintMatrix(matrix3, i, j, k);
