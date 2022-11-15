// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

bool  Multipliciti(int num1)
{
    return(num1 % 7 == 0) && (num1 % 23 == 0);
}

Console.WriteLine(Multipliciti(Number) ? "Да" : "Нет");