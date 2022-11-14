using System.Data;
// Напишите программу которая  
// 1 принимает на вход два числа 
// 2 и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

