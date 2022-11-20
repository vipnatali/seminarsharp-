
//  Напишите программу, 
//  которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 | day == 7)
    Console.WriteLine("Да");
else Console.WriteLine("Нет");

if (day >= 8)
    Console.WriteLine("Увы, вы ошиблись, такого числа нет.");






// if(num == "1")
// Console.WriteLine("нет");
// else if(num == "2")
// Console.WriteLine("нет");
// else if(num == "3")
// Console.WriteLine("нет");
// else if(num == "4")
// Console.WriteLine("нет");
// else if(num == "5")
// Console.WriteLine(" нет");
// else if(num == "6")
// Console.WriteLine("да");
// else if (num == "7")
// Console.WriteLine("да");



