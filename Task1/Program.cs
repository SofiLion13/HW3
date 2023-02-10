// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// using System;
// public class IsPalindrom
// {
//     public static void Main (string[] args)
//     {
//         int number, total = 0, t, reverse;
//         Console.Write("Введите пятизначное число:");
//         number = int.Parse(Console.ReadLine());
//         t = number;
//         while (number > 0)
//         {
//             reverse = number % 10;
//             total = (total * 10) + reverse;
//             number = number / 10;
//         }
//         if (t == total)
//         Console.Write("Палиндром");
//         else
//         Console.Write("He палиндром");
//     }
// }

class IsPalindrom
{
    static void Main (string[] args)
    {
        int number, total = 0, t, reverse;
        Console.Write("Введите пятизначное число: ");
        number = int.Parse(Console.ReadLine());
        t = number;
        while (number > 0)
        {
            reverse = number % 10;
            total = (total * 10) + reverse;
            number = number / 10;
        }
        if (t == total)
        Console.Write("Палиндром");
        else
        Console.Write("He палиндром");
    }
}