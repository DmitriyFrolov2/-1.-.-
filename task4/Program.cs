﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int a, b;
a = 1;
Console.WriteLine("Введи любое число: ");
b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write( i );
    }  
}

