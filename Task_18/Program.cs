﻿Console.Clear();
Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
    Console.WriteLine("Вы ошиблись!\nВведите число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.WriteLine("x > 0 && y > 0");
else if (n == 2)
Console.WriteLine("x < 0 && y > 0");
else if (n == 3)
Console.WriteLine("x < 0 && y < 0");
else
Console.WriteLine("x > 0 && y < 0");