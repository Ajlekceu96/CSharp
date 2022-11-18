/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 6:
        {
            Console.WriteLine("Да");
            break;
        }
    case 7:
        {
            Console.WriteLine("Да");
            break;
        }
    default:
        {
            Console.WriteLine("Нет");
            break;
        }
}