// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


// МОЖНО ПЕРЕВЕРНУТЬ ЧЕРЕЗ INT, НО ЭТО ДОП ПАМЯТЬ ДЛЯ НОВОГО МАССИВА. ЕСЛИ СТАРЫЙ НЕ ЖАЛКО, ТО VOID, ЕСЛИ ЖАЛКО, ТО INT
void ReverseArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i]= array[array.Length-1-i];
        array[array.Length-1-i]=temp;
    }
}


Console.Clear();
int[] array = GetArray(6, 1, 9);
Console.WriteLine(String.Join(",", array));

ReverseArray(array);
Console.WriteLine(String.Join(",", array));
