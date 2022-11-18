/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

int[,] GetArray(int m, int n)
{
    int[,] localArray = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            localArray[i, j] = random.Next(1, 100);
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

int[,] CalculateArray(int[,] localArray)
{
    int temp;
    for (int rows = 0; rows < localArray.GetLength(0); rows++)
        for (int i = 0; i < localArray.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < localArray.GetLength(1); j++)
            {
                if (localArray[rows, i] < localArray[rows, j])
                {
                    temp = localArray[rows, i];
                    localArray[rows, i] = localArray[rows, j];
                    localArray[rows, j] = temp;
                }
            }
        }

    return localArray;
}

int[,] array = GetArray(10, 15);
PrintArray(array);

Console.WriteLine();

array = CalculateArray(array);
PrintArray(array);