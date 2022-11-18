/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int m = 0;
int n = 0;

try
{
    Console.WriteLine("Введите число m:");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n:");
    n = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}

int CalculateValue(int m, int n)
{
    if (m == 0)
        return n + 1;
    if ((m > 0) && (n == 0))
        return CalculateValue(m - 1, 1);
    return CalculateValue(m - 1, CalculateValue(m, n - 1));
}

Console.WriteLine();
Console.Write($"m = {m}, n = {n} -> A(m,n) = {CalculateValue(m, n)}");
Console.WriteLine();