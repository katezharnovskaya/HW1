﻿Console.WriteLine("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число больше второго" );
}
else if (a < b)
{
    Console.WriteLine("Первое число меньше второго" );
}
else
{
    Console.WriteLine("Оба числа равны" );

}


