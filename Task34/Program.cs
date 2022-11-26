// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива 
// значение которых лежат в отрезке [10, 99]

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

int CountElements (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(123, 0, 999);
PrintArray(array);

int countElements = CountElements(array);
if (countElements > 0) Console.WriteLine($"Количество двухзначных чисел {countElements} ");
else Console.WriteLine("Двухзначных чисел нет");