// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

// ПЕРЕВЕСТИ ЕГО В ОБЫЧНЫЙ МАССИВ, ОТСОРТИРОВАТЬ ПО ВОЗРАСТАНИЮ, ИСКАТЬ ЧАСТОТНЫЕ ЭЛЕМЕНТЫ

int[] Transform2DTo1D(int[,] array2D)
{
    int[] array1D = new int[array2D.GetLength(0) * array2D.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array1D[k++] = array2D[i, j];
        }
    }
    return array1D;
}

void Sort1Darray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void CountUnique(int[] array)
{
    // int[] array = Transform2DTo1D(array2D);
    // Sort1Darray(array);
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раз");
}

Console.Clear();
int[,] array2d = Get2DArray(3, 3, 1, 4);
Print2DArray(array2d);
Console.WriteLine();
int[] array = Transform2DTo1D(array2d);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Sort1Darray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
CountUnique(array);