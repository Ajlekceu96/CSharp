/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

 */

int[] numers = new int[8];

void ReadArray()
{
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < 8; i++)
    {
        numers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void WriteArray()
{
    Console.WriteLine();
    Console.Write("Массив = [");
    for (int i = 0; i < 8; i++)
    {

        Console.Write(numers[i]);
        if (i < 7)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

try
{
    ReadArray();
    WriteArray();
}
catch (Exception)
{
    Console.WriteLine("Ошибка");
}