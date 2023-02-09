﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNumber(string message)
{
   int result = 0;
   while (true)
   {
      Console.WriteLine(message);
      if (int.TryParse(Console.ReadLine(), out result))
      {
         break;
      }
      else
      {
         Console.WriteLine("Ввели не число или 0. Повторите ввод");
      }
   }
   return result;
}

int x1 = GetNumber("Введите координату X первой точки");
int y1 = GetNumber("Введите координату Y первой точки");
int z1 = GetNumber("Введите координаты Z первой точки");

int x2 = GetNumber("Введите координату X второй точки");
int y2 = GetNumber("Введите координату Y второй точки");
int z2 = GetNumber("Введите координаты Z второй точки");

// // Корень((x1-x2)^2 + (y1-y2)^2)
// // Math.Sqrt()
// // Math.Pow(выражение, степень)

double GetDistance (int x1, int x2, int y1, int y2, int z1, int z2)
{
   double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
   return result;
}

System.Console.WriteLine(GetDistance(x1,x2,y1,y2,z1,z2));