// Написать программу
// 1 На вход принимает два числа
// 2 Выдаёт какое число больше, а какое меньше.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max =10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

bool number0 = a > b;
if (number0)
{
    Console.WriteLine($"Большее число {a}");
}
else
{
    bool number1 = a < b;
    if(number1)
    {
        Console.WriteLine($"Большее число {b}");
    }
}