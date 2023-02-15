// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int schetchik(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            count++;
        }
    }
    return count;
}


Console.Clear();
Console.WriteLine("Введите длину массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минималку:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максималку:");
int max = int.Parse(Console.ReadLine()!);
int[] massiv = GetArray(length, min, max);
Console.WriteLine(String.Join(",", massiv));

Console.WriteLine("Введите откудава:");
int ot = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите до кудава:");
int Do = int.Parse(Console.ReadLine()!);
int schet = schetchik(massiv, ot, Do);
Console.WriteLine(schet);

// РЕШЕНИЕ НА СЕМИНАРЕ ЧЕРЕЗ FOREACH:

int CountElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 9 && item < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, -9, 150);
Console.WriteLine(string.Join(",", array));
int end = CountElements(array);
Console.Write($"Количество элементов массива удовлетворяющих условие равна {end} ");