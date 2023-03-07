// Задача 62: Заполните спирально массив 4 на 4.


int[,] Get4x4spiralArray(int start, int step)
{
    int[,] array = new int[4, 4];
    array[0, 0] = start;
    int i = 0;
    int j = 1;
    while (j < 4)
    {
        start = start + step;
        array[i, j] = start;
        j++;
    }
    i++;
    j = j - 1;
    while (i < 4)
    {
        start = start + step;
        array[i, j] = start;
        i++;
    }
    i = i - 1;
    j = j - 1;
    while (j > -1)
    {
        start = start + step;
        array[i, j] = start;
        j = j - 1;
    }
    i = i - 1;
    j = j + 1;
    while (i > 0)
    {
        start = start + step;
        array[i, j] = start;
        i = i - 1;
    }
    i++;
    j++;
    while (j < 3)
    {
        start = start + step;
        array[i, j] = start;
        j = j + 1;
    }
    i++;
    j = j - 1;
    while (j > 0)
    {
        start = start + step;
        array[i, j] = start;
        j = j - 1;
    }
    return array;
}


void Print2DArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}



Print2DArray(Get4x4spiralArray(1,1));