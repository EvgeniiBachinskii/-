// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] Get3DArray(int row, int col, int z, int min, int max)
{
    int[,,] array = new int[row, col, z];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}:[{i}, {j}, {k}], ");
            }
        }
    }
}


Print3DArray(Get3DArray(3, 2, 3, 10, 99));