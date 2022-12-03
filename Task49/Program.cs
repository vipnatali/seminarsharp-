// Задайте двумерный массив. 
// Найдите сумму элементов,
// находящихся на главной диагонали(с индексами(0,0);(1;1) и т.д)

// Например, задан массив:
// 1472
// 5923
// 8424
// Сумма элементов главной диагонали: 1+ 9 + 2 = 12

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

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    int minIndex = matrix.GetLength(0);
    if (matrix.GetLength(1) < matrix.GetLength(0)) minIndex = matrix.GetLength(1);
    for (int i = 0; i < minIndex; i++)
    {
        sum += matrix[i, i];
    }
     return sum;
}

int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array);
Console.WriteLine();
int sumDiagonalMatrix = SumDiagonalMatrix(array);
Console.WriteLine($"сумму элементов, находящихся на главной диагонали = {sumDiagonalMatrix}");
