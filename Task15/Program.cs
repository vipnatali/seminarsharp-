
//  Напишите программу, 
//   выводит третью цифру заданного числа 
//   или сообщает, что третьей цифры нет. 
//   Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.Write("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

if (numDigit(num) == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра: {numDigit(num)}");
}










