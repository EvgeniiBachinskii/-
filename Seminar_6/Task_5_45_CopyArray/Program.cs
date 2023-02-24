// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] cArray = GetArray(5, 1, 6);
Console.WriteLine(String.Join(",", cArray));
Console.WriteLine(String.Join(",", CopyArray(cArray)));


// РЕШЕНИЕ С СЕМИНАРА:

// Console.Clear();

// int[] CopyArray(int[] arr)
// {
// int[] newArr = new int[arr.Length];

// for (int i = 0; i < arr.Length; i++)
// {
// newArr[i] = arr[i];
// }
// return newArr;
// }

// int[] array = { 1, 2, 3, 55 };

// int[] newArray = CopyArray(array);
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine();
// Console.WriteLine(String.Join(", ", newArray));