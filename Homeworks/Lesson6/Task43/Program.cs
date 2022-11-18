/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

*/

double b1 = 0;
double k1 = 0;
double b2 = 0;
double k2 = 0;
double x = 0;
double y = 0;

void EnterValue()
{

    Console.Write($"Введите значение b1 = ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите значение k1 = ");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите значение b2 = ");
    b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите значение k2 = ");
    k2 = Convert.ToDouble(Console.ReadLine());

}

void CalculateValue()
{
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
}

try
{
    EnterValue();
    CalculateValue();
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: не корректное значение");
    Environment.Exit(0);
}

Console.WriteLine();
Console.WriteLine($"x = {x}; y = {y}");
Console.WriteLine();