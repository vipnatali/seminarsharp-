// Написать программу
// 1 На вход принимает число
// 2 И выдаёт является ли число чётным

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write("Да");
}
else Console.Write("Нет");