// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// [1, 4, 5, 8, 5, 4] - 6
//  0  1  2  3  4  5

// i* size-1-i


//  [1, 2, 3, 4, 5,] - 5
//   0  1  2  3  4



int[] getArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] multiPairsArray(int[] array)
{
    int length = array.Length / 2;
    if (array.Length % 2 != 0) length ++;
    int[] newAaray = new int[length];
    int i = 0;
    while (i < array.Length - 1 - i)
    {
        newAaray[i] = array[i] * array[array.Length - 1 - i];
        i++;
    }
    if (i == array.Length - 1 - i)
    {
        newAaray[i] = array[i];
    }
    return newAaray;
}

void PrintArray(int[] array)
{
    Console.Write("[");     // печать открывающей скобки
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");   // печать всего содержимого, кроме последней ячейки
    }
    Console.Write($"{array[array.Length - 1]}"); // печать посл ячейкм без пробела
    Console.WriteLine("]");     // не понял зачем райтлайн с последней скобкой, почему нельзя сразу к последней ячейке добавить
}

Console.WriteLine("Enter size: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter min: ");
int mini = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter max: ");
int maxi = int.Parse(Console.ReadLine()!);
int[] massiv = getArray(size, mini, maxi);
// PrintArray(massiv);
Console.WriteLine(String.Join(",", massiv));
int[] newmassiv = multiPairsArray(massiv);
PrintArray(newmassiv);
// Console.WriteLine(String.Join(",", newmassiv));

// РЕШЕНИЕ С СЕМИНАРА:

int[] MultArray(int[] array)
{
int size = array.Length / 2;
if (array.Length % 2 != 0) size++;
int[] result = new int[size];
for (int i = 0; i < array.Length / 2; i++)
{
result[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 != 0)
result[size - 1] = array[array.Length / 2];
return result;
}


