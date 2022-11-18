/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int m = 0;
int n = 0;
int summ = 0;

try
{
    Console.WriteLine("Введите число M:");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    n = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}

void CalculateValue(int m, int n)
{
    if (n >= m)
    {
        summ += m;
        m++;
        CalculateValue(m, n);
    }
}

Console.WriteLine();
CalculateValue(m, n);
Console.Write($"M = {m}; N = {n} -> {summ}");
Console.WriteLine();