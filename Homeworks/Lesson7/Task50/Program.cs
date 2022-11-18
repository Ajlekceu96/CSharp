/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

*/

int rows = 7;
int columns = 5;
int[,] array = new int[rows, columns];

int[,] GetArray(int m, int n)
{
    int[,] localArray = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            localArray[i, j] = random.Next(-9, 10);
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
            Console.Write(Convert.ToString(localArray[i, j]).PadLeft(2));
            if (j < localArray.GetLength(1) - 1)
            {
                Console.Write(" | ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int SearchValue(int[,] localarray, int position)
{
    int i = 0;
    int j = 0;
    i = (position - 1) / columns;
    j = (position - 1) % columns;
    if (i >= rows)
    {
        Console.WriteLine();
        Console.WriteLine("Такой позиции в массиве нет");
        Environment.Exit(0);
    }
    return localarray[i, j];
}

array = GetArray(rows, columns);
PrintArray(array);

try
{
    Console.WriteLine();
    Console.WriteLine($"Всего в массиве {rows * columns} элементов");
    Console.WriteLine("Введите позицию искомого элемента: ");
    int result = SearchValue(array, Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine();
    Console.WriteLine($"Значение = {result}");
}
catch (Exception)
{
    Console.WriteLine("Ошибка: Не корректное значение");
}