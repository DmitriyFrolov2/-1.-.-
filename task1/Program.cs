﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

{
 
        int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = int.Parse(Console.ReadLine());
 
        b = int.Parse(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
 
        Console.ReadLine();
 
    if (a < b)
 
        {
 
            Console.WriteLine("{0} наименьшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наименьшее число ", b);
 
        }
 
        Console.ReadLine();
}