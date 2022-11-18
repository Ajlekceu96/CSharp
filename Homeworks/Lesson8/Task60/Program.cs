/*

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

bool SearchDuplocate(int[,,] localArray, int value)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
        for (int j = 0; j < localArray.GetLength(1); j++)
            for (int k = 0; k < localArray.GetLength(2); k++)
                if (value == localArray[i, j, k])
                    return true;
    return false;
}

int[,,] GetArray(int x, int y, int z)
{
    int[,,] localArray = new int[x, y, z];
    Random random = new Random();
    int temp = 0;
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            for (int k = 0; k < localArray.GetLength(2); k++)
            {
                do
                {
                    temp = random.Next(10, 100);
                }
                while (SearchDuplocate(localArray, temp));
                localArray[i, j, k] = temp;
            }
        }
    }
    return localArray;
}

void PrintArray(int[,,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            for (int k = 0; k < localArray.GetLength(2); k++)
            {
                Console.WriteLine($"({i},{j},{k}) {localArray[i, j, k]}");
            }
        }
    }
}

int[,,] array3D = GetArray(2, 2, 2);
PrintArray(array3D);