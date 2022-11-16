
//  Напишите программу, 
//   выводит третью цифру заданного числа 
//   или сообщает, что третьей цифры нет. 
//   Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());


// if ( num <= 2)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
    
// if (num = num % 10);
//     Console.WriteLine($"Третья цифра: {num}");
// }

      Console.Write("Введите любое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string numStr = Convert.ToString(num);
             int numDigit = numStr.Length;
            if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
            else Console.WriteLine("третьей цифры нет");
      


