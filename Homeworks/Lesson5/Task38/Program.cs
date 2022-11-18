/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

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

double[] CreateArray(int sizeArray)
{
    Random random = new Random();
    double[] localArray = new double[sizeArray];
    for (int i = 0; i < localArray.Length; i++)
        localArray[i] = Math.Round(random.Next(-99, 100) + random.NextDouble(), 2);

    return localArray;
}

void PrintArray(double[] localArray)
{
    Console.Write("[");
    for (int i = 0; i < localArray.Length; i++)
    {
        Console.Write($"{localArray[i]}");

        if (i < localArray.Length - 1)
        {

            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
                Console.Write(" ");
            }
            else
                Console.Write(" | ");
        }
    }
    Console.Write("]");
}

double DiffArray(double[] localArray)
{
    double min = localArray[0];
    double max = localArray[0];

    for (int i = 0; i < localArray.Length; i++)
    {
        if (localArray[i] > max)
            max = localArray[i];
        if (localArray[i] < min)
            min = localArray[i];
    }
    return max - min;
}

double[] array = CreateArray(EnterValue());

Console.WriteLine();
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементов массива = {0 : 0.00}", DiffArray(array));