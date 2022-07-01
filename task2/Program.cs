/*  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a, b, c;
Console.WriteLine("Введи первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
c = Convert.ToInt32(Console.ReadLine());

if(a > b) 
{
    if(a > c)
    Console.WriteLine($"Число {a} максимальное");
}
if(b > a) 
{
    if(b > c)
    Console.WriteLine($"Число {b} максимальное");
}
if(c > a) 
{
    if(c > b)
    Console.WriteLine($"Число {c} максимальное");
}