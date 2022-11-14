// Напишите прграмму
// 1 которая принимает на вход трёхзначное число
// 2 и на выходе показывает ппоследнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
Console.WriteLine($"Последнее цифра  {last}");