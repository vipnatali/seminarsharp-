//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите числа: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Numbers(int[] arr)
{
    int num = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) num++;
    }
    return num;
}

int numbers = Numbers(arr);
Console.WriteLine($"Количество чисел больше нуля: {numbers}");