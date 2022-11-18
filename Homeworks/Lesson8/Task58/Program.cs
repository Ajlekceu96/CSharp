/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:

2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18

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

void CalculateArray(int[,] localArrayFisrt, int[,] localArraySecond, int[,] localArrayResult)
{
    /*
    Проверка матрицы 2х2 как в примере: 

    localArrayFisrt[0,0] = 2;
    localArrayFisrt[0, 1] = 4;
    localArrayFisrt[1, 0] = 3;
    localArrayFisrt[1, 1] = 2;

    localArraySecond[0, 0] = 3;
    localArraySecond[0, 1] = 4;
    localArraySecond[1, 0] = 3;
    localArraySecond[1, 1] = 3;
    */

    for (int i = 0; i < localArrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < localArrayResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < localArrayFisrt.GetLength(1); k++)
            {
                sum += localArrayFisrt[i, k] * localArraySecond[k, j];
            }
            localArrayResult[i, j] = sum;
        }
    }
}

Console.WriteLine("Первая матрица:");
int[,] arrayFirst = GetArray(2, 2);
PrintArray(arrayFirst);
Console.WriteLine("Вторая матрица:");
int[,] arraySecond = GetArray(2, 2);
PrintArray(arraySecond);
int[,] arrayResult = GetArray(2, 2);

Console.WriteLine();

CalculateArray(arrayFirst, arraySecond, arrayResult);
Console.WriteLine("Результат произведения матриц:");
PrintArray(arrayResult);