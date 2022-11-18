/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

 */

int a, b;

void EnterValue()
{
    Console.WriteLine("Введите число которое хотите возвести в степень");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
    b = Convert.ToInt32(Console.ReadLine());
}

int MathPow(int a, int b)
{
    int result = a;

    for (int i = 0; i < b - 1; i++)
    {
        result = result * a;
    }

    return result;
}

try
{
    EnterValue();
    Console.WriteLine();
    Console.WriteLine($"Число {a} в степени {b} = {MathPow(a, b)}");
}
catch (Exception)
{
    Console.WriteLine("Ошибка");
}