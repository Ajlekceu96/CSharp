/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

int a = 0;
int b = 0;
int c = 0;

try
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
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
    if (a > c)
    {
        Console.WriteLine($"Max = {a}");
    }
    else
    {
        Console.WriteLine($"Max = {c}");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine($"Max = {b}");
    }
    else
    {
        Console.WriteLine($"Max = {c}");
    }
}