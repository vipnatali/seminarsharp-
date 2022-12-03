// Напишите программу 
// которая будет преобразовывать десятичное число в двоичное

// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintArray(int[]arr, string beginStr, string separatorElems, string endstr)
{
    Console.WriteLine(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
             Console.Write($"{arr[i]} {separatorElems}");
        else Console.WriteLine($"{arr[i]}");
    }
    Console.Write(endstr);
}

int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while(numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[i] = numb % 2;
        numb /= 2;
    }
    Array.Reverse(bin);
    return bin;
}

Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(namber);
PrintArray(binary, "", "", "");