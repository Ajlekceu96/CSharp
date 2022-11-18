/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double AvgValue(int[,] localarray, int colum)
{
    double result = 0;
    for (int i = 0; i < localarray.GetLength(0); i++)
        result = result + localarray[i, colum];

    Console.Write($"Среднее значение {colum + 1} столбца ({result} / {localarray.GetLength(0)}) = ");
    result = Math.Round(result / localarray.GetLength(0), 2);
    return result;
}

int[,] array = GetArray(3, 4);
PrintArray(array);

Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
    Console.WriteLine($"{AvgValue(array, j)}");