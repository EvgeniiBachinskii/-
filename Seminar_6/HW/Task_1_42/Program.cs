// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] EnterArray()
{
    Console.WriteLine("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountMoreZero(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) count++;
    }
    return count;
}


int[] array = EnterArray();

Console.WriteLine($"{String.Join(",", array)} > {CountMoreZero(array)}");



// ЭТАЛОННОЕ РЕШЕНИЕ:

// int Prompt(string message)
// {
//     // Console.WriteLine(message);
//     // int N = int.Parse(Console.ReadLine()!); // МОЙ ВАРИАНТ
//     // ИЗ ЭТАЛ РЕШЕНИЯ:
//     Console.WriteLine(message);
//     string value = Console.ReadLine()!;
//     int N = Convert.ToInt32(value);

//     return N;
// }


// int[] InputArray(int Length)
// {
//     int[] array = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = Prompt($"Введите {i + 1}-й элемент");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }


// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// int length = Prompt("Введите количество элементов >");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");




