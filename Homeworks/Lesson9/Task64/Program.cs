/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int n = 0;

try
{
    Console.WriteLine("Введите число:");
    n = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}

void PrintValue(int n)
{
    if (n >= 1)
    {
        if (n != 1)
            Console.Write($"{n}, ");
        else
            Console.Write($"{n}");
        n--;
        PrintValue(n);
    }
}

Console.WriteLine();
Console.Write('"');
PrintValue(n);
Console.Write('"');
Console.WriteLine();