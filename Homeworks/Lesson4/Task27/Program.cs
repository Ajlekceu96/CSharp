/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

 */

string a = String.Empty;

void EnterValue()
{
    Console.WriteLine("Введите число:");
    a = Console.ReadLine();
}

int SummValue()
{
    int b = a.Length;
    int summ = 0;

    for (int i = 0; i < b; i++)
    {
        summ = summ + int.Parse(a[i].ToString());
    }
    return summ;
}

try
{
    EnterValue();
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр в числе = {SummValue()}");
}
catch (Exception)
{
    Console.WriteLine("Ошибка");
}