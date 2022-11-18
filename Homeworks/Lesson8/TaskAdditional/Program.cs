/*

Дополнительно Напишите программу выводящую треугольник Паскаля

*/

void GetArrayPT(int[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        localArray[i, 0] = 1;
        for (int j = 1; j < i + 1; j++)
        {
            localArray[i, j] = localArray[i - 1, j] + localArray[i - 1, j - 1];
        }
    }
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        int count = 0;
        for (int j = localArray.GetLength(1) - 1; j >= 0; j--)
        {
            if (localArray[i, j] != 0)
            {
                localArray[i, localArray.GetLength(1) / 2 + j - count] = localArray[i, j];
                localArray[i, j] = 0;
                count++;
            }
        }
    }
    localArray[localArray.GetLength(0) - 1, 0] = 1;
}

void PrintArrayPT(int[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            if (localArray[i, j] != 0)
            {
                Console.Write(Convert.ToString(localArray[i, j]).PadLeft(3));
            }
            else Console.Write("   ");
        }
        Console.WriteLine();
    }
}

int size = 10;
int[,] arrayPascalTriangle = new int[size + 1, 2 * size + 1];
GetArrayPT(arrayPascalTriangle);
PrintArrayPT(arrayPascalTriangle);