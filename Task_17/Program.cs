﻿// Task 17

Console.Clear();
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0 || y == 0)
{
    Console.WriteLine("Вы ошиблись! Введите координаты заново!");
    Console.Write("Введите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");