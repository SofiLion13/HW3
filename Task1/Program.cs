// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = GetNumber ("Введите пятизначное число"), total = 0, t = number, reverse;
int amount = number.ToString().Length;

while (number > 0)
{
    reverse = number % 10;
    total = (total * 10) + reverse;
    number = number / 10;
}
if (t == total)
Console.WriteLine("да");
else if (amount < 5 || amount > 5)
Console.WriteLine("Вы ввели не пятизначное число");
else
Console.WriteLine("нeт");