// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] GetArray(int size, int max, int min)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


void ZamenaArray(int[] array)     // можно сделать воид, можно инт, разницу не уловил пока
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
        // ВАРИАНТЫ:
        // array[i] = -array[i];
        // array[i] *= -1;
    }
    // return array;
}
Console.Clear();
int[] array = GetArray(8, 9, -9);
Console.WriteLine(String.Join(",", array));

ZamenaArray(array);
Console.WriteLine(String.Join(",", array));
