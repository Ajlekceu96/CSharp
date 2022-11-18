/*

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

int a = 0;
int b = 0;

try
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}

Console.WriteLine();

if (a > b)
{
    Console.WriteLine($"Max = {a}");
}
else
{
    Console.WriteLine($"Max = {b}");
}