// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



bool findNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

// Решение через foreach:

// bool FindElement(int number, int[] collection)
// {
// foreach (int el in collection)
// {
// if (el == number)
// {
// return true;
// }
// }
// return false;
// }

int[] massiv = GetArray(7, 1, 9);
Console.WriteLine(String.Join(",", massiv));

if(findNumber(massiv, 3))
{
    Console.WriteLine("YES");
}
else
{
Console.WriteLine("no");
}