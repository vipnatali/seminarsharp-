// Напишите программу
// Ввыводит случайное трёхзначное число
// удаляет вторую цифру


int number = new Random().Next(100, 1000);
Console.WriteLine($"Число {number} ");
int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
Console.WriteLine($" Результат = {RemoveSecondDigit(number)}");