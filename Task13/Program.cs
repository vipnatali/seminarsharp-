// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1 : ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int Number2 = Convert.ToInt32(Console.ReadLine());

bool square (int Num1,  int Num2 )
{
    return (Num1 == Num2*Num2) || (Num2 == Num1 * Num1);
}
Console.WriteLine(square(Number1, Number2)? "Да" : "Нет");