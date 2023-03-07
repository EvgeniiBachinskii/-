// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void ChangeColAndRow(int[,] inArray)
{
    if (inArray.GetLength(0) == inArray.GetLength(1))
    {
        int temp;
        int j;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            j = i + 1;
            while (j < inArray.GetLength(1))
            {
                if (i != j)
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[j, i];
                    inArray[j, i] = temp;
                }
                j++;
            }
        }
    }
    else
    {
        Console.WriteLine("no");
    }
}

int[,] array = Get2DArray(5, 5, -5, 10);
Print2DArray(array);
Console.WriteLine();
ChangeColAndRow(array);
Print2DArray(array);


//РЕШЕНИЕ С СЕМИНАРА ЧЕРЕЗ INT:

// int[,] Transparent(int[,] newArray)
// {
//     int[,] transparent = new int[newArray.GetLength(1), newArray.GetLength(0)];
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             transparent[j, i] = newArray[i, j];
//         }
//     }
//     return transparent;
// }

// Console.Clear();
// Console.Write("row = ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("col = ");
// int col = int.Parse(Console.ReadLine()!);
// int[,] array2D = GetArray(row, col, -10, 10);
// PrintArray(array2D);
// Console.WriteLine();
// if (row != col)
// {
//     Console.Write("Операцию вывести невозможно");
// }
// else
// {
//     int[,] arrayLast = Transparent(array2D);
//     PrintArray(arrayLast);
// }