﻿Console.WriteLine("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c=Convert.ToInt32(Console.ReadLine());
int max=Convert.ToInt32(a);

if (b > a)
{
    max = b;
}

if (c > max)
{
   max = c;
}

 Console.WriteLine("Максимальное число: " + max);

