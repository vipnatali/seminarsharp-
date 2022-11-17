
//  Напишите программу, 
//  которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
string num = Console.ReadLine();

if(num == "1")
Console.WriteLine("нет");
else if(num == "2")
Console.WriteLine("нет");
else if(num == "3")
Console.WriteLine("нет");
else if(num == "4")
Console.WriteLine("нет");
else if(num == "5")
Console.WriteLine(" нет");
else if(num == "6")
Console.WriteLine("да");
else if (num == "7")
Console.WriteLine("да");

else Console.WriteLine("Увы, такого дня недели нет!");

