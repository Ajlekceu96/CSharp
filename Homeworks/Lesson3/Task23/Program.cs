/*

Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

 */

int a = 0;

try
{
    a = Convert.ToInt32(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка: Не корректное значение");
    Environment.Exit(0);
}

Console.WriteLine();

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}