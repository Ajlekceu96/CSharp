/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] GetArray(int m, int n)
{
    int[,] localArray = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            localArray[i, j] = random.Next(1, 10);
        }
    }
    return localArray;
}

void PrintArray(int[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write($"{localArray[i, j]}");
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void CalculateArray(int[,] localArray)
{
    int temp = 0;
    int minSumRows = 0;
    int minRows = 0;

    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            temp += localArray[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {temp}");
        if ((minSumRows > temp) || (minSumRows == 0))
        {
            minSumRows = temp;
            minRows = i;
        }
        temp = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Строка {minRows + 1} имеет наименьшую сумму элементов = {minSumRows}");
}

int[,] array = GetArray(7, 3);
PrintArray(array);

Console.WriteLine();

CalculateArray(array);