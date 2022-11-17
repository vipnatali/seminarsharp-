
//  Напишите программу, 
//   выводит третью цифру заданного числа 
//   или сообщает, что третьей цифры нет. 
//   Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numfirst = Convert.ToString(num);
int numDigit = numfirst.Length;

if (numDigit > 2)
{
    Console.WriteLine($"Третья цифра {numfirst[2]} ");
}
else
{
    Console.WriteLine("третьей цифры нет");

}













