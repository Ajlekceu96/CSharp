/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

int EnterValue()
{
    int value = 0;
    Console.WriteLine($"Введите размер массива:");
    try
    {
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка: не корректное значение");
        Environment.Exit(0);
    }
    return value;
}

int[] CreateArray(int sizeArray)
{
    Random random = new Random();
    int[] localArray = new int[sizeArray];
    for (int i = 0; i < localArray.Length; i++)
        localArray[i] = random.Next(100, 1000);

    return localArray;
}

void PrintArray(int[] localArray)
{
    Console.Write("[");
    for (int i = 0; i < localArray.Length; i++)
    {
        Console.Write($"{localArray[i]}");
        if (i < localArray.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

int CountArray(int[] localArray)
{
    int Count = 0;
    for (int i = 0; i < localArray.Length; i++)
    {
        if (localArray[i] % 2 == 0)
        {
            Count++;
        }
    }
    return Count;
}

int[] array = CreateArray(EnterValue());

Console.WriteLine();
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Количество чётных чисел = {CountArray(array)}");