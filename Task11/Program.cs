
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());

bool Multipliciti(int num1, int num2)
{
   return num1 % num2 == 0;
}
int MultiplicitiSecond(int num1, int num2)
{
    return num1 % num2;
}
int result2 = MultiplicitiSecond(a, b);
Console.WriteLine(result2 == 0 ? "Первое число кратное второму " :  $"Некратное, остаток = {result2}" );