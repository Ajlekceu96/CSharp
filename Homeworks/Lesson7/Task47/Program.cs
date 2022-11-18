/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

try
{
    Console.WriteLine("Введите числа обозначающие размер двумерного массива: ");
    Console.WriteLine("Введите m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n: ");
    int n = int.Parse(Console.ReadLine());


    double[,] GetArray(int m, int n)
    {
        double[,] array = new double[m, n];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(random.Next(-9, 10) + random.NextDouble(), 1);
            }
        }
        return array;
    }

    void PrintArray(double[,] array)
    {
        Console.WriteLine();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}");
                if (j < array.GetLength(1) - 1)
                {
                    Console.Write(" | ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    PrintArray(GetArray(m, n));
}
catch (Exception)
{
    Console.WriteLine("Ошибка: Не корректное значение");
}