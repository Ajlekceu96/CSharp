/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

int EnterValue()
{
    int value = 0;
    Console.WriteLine($"Введите размер массива:");
    try
    {
        value = Convert.ToInt32(Console.ReadLine());
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
        localArray[i] = random.Next(-100, 101);

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

int SummArray(int[] localArray)
{
    int Summ = 0;
    for (int i = 0; i < localArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            Summ = Summ + localArray[i];
        }
    }
    return Summ;
}

int[] array = CreateArray(EnterValue());

Console.WriteLine();
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SummArray(array)}");