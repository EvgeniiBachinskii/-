// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}



int CountEven(int[] inarray)
{
    int count = 0;
    for (int i = 0; i < inarray.Length; i++)
    {
        if(inarray[i]%2==0)count++;
    }
    return count;
}


int[] arrayTest = GetArray(5,100,999);
Console.WriteLine($"{String.Join(",", arrayTest)} -> {CountEven(arrayTest)}");

// Console.Write(CountEven(arrayTest));