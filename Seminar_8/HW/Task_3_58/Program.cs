// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

// int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     if (arrayA.GetLength(1) == arrayB.GetLength(0))
//     {
//         for (int iC = 0; iC < arrayC.GetLength(0); iC++)
//         {
//             for (int jC = 0; jC < arrayC.GetLength(1); jC++)
//             {
//                 int iA = iC;
//                 int jB = jC;
//                 int Sum = 0;
//                 for (int k = 0; k < arrayA.GetLength(1); k++)
//                 {
//                     Sum = Sum + arrayA[iA, k] * arrayB[k, jB];
//                 }
//                 arrayC[iC, jC] = Sum;
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Произведение данных матриц не существует");
//     }
//     return arrayC;
// }

int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        for (int i = 0; i < arrayC.GetLength(0); i++)
        {
            for (int j = 0; j < arrayC.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] = arrayC[i, j] + arrayA[i, k] * arrayB[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Произведение данных матриц не существует");
    }
    return arrayC;
}


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



int[,] array1 = Get2DArray(2, 3, 1, 4);
int[,] array2 = Get2DArray(3, 2, 1, 4);
Console.Clear();
Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);
Console.WriteLine();
int[,] array1m2 = MultiplicationMatrix(array1, array2);
Print2DArray(array1m2);

