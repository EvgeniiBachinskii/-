// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Get2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
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

void FindSumMinRow(int[,] array)
{
    int SumRow0 = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        SumRow0 = SumRow0 + array[0, k];
    }

    int MinSumRow = SumRow0;
    int MinSumRowI = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow = SumRow + array[i, j];
        }
        if (SumRow < MinSumRow)
        {
            MinSumRow = SumRow;
            MinSumRowI = i;
        }
    }
    Console.WriteLine($"{MinSumRowI + 1}-я строка с самой минимальной суммой элементов = {MinSumRow}");
}

int[,] array = Get2DArray(5, 4, 1, 4);
Print2DArray(array);
Console.WriteLine();
FindSumMinRow(array);



