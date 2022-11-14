// Напишите программу
// 1 На вход принимает число (N)
// 2 На выходе показывает все чётные числа от 1 до N 

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int coint = 1;
while(coint <= num)
{
    if(coint % 2 == 0)
    {
        Console.WriteLine(coint + ",");
    }
    coint++;
}

