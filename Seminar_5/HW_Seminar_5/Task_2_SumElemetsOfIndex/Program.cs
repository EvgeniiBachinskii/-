// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int SumElements(int[] newArray)
{
    int sum = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i % 2 != 0) sum = sum + newArray[i];
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Enter array size:");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the minimum value:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the maximum value:");
int max = int.Parse(Console.ReadLine()!);
int[] arrayTest = GetArray(size, min, max);


Console.WriteLine($"{String.Join(", ", arrayTest)} -> {SumElements(arrayTest)}");
