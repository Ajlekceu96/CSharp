/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/

int EnterValue()
{
    int count = 0;
    string s = string.Empty;
    Console.WriteLine($"Для завершения ввода чисел введите 'Calc'");
    Console.WriteLine($"Вводите числа:");
    try
    {
        while (s.ToLower() != "calc")
        {
            s = Console.ReadLine();
            if (s.ToLower() != "calc")
                if (int.Parse(s) > 0)
                    count++;
        }
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка: не корректное значение");
        Environment.Exit(0);
    }
    return count;
}

Console.WriteLine($"Количество чисел больше 0 = {EnterValue()}");