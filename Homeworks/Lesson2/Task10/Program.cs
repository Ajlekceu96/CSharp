/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

string s = Console.ReadLine();
if ((int.TryParse(s, out int s2)))
    if ((s2 > 0) && (s.Length == 3))
        Console.WriteLine(s[1]);
    else if ((s2 < 0) && (s.Length == 4))
        Console.WriteLine(s[2]);
    else
        Console.WriteLine("Ошибка: Вы ввели не трёхзначное число");
else
    Console.WriteLine("Ошибка: Вы ввели не число");