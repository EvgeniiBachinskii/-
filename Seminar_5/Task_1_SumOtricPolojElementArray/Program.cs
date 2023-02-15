// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


// // МОЕ РЕШЕНИЕ:
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = int.Parse(Console.ReadLine()!);
//     return result;
// }

// int[] GenerateArray(int length, int min, int max)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");
// }

// int SumPositivNumbersArray(int[] array)
// {
//     int PositivSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) PositivSum += array[i];
//     }
//     return PositivSum;
// }

// int SumNegativNumbersArray(int[] array)
// {
//     int NegativeSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) NegativeSum += array[i];
//     }
//     return NegativeSum;
// }

// GenerateArray(Prompt("length:"), Prompt("min:"), Prompt("max:"));
// int[] massiv = GenerateArray(Prompt("length:"), Prompt("min:"), Prompt("max:"));

// Console.Write("В массиве ");
// PrintArray(massiv);
// Console.WriteLine($" сумма положительных чисел равна {SumPositivNumbersArray(massiv)}, сумма отрицательных равна {SumNegativNumbersArray(massiv)}.");






// РЕШЕНИЯ ЛЕКТОРА:

int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// !!!!!!!!!!СПОСОБ ПЕЧАТИ МАССИВА:
int[] array = GetArray(8, -9, 9);
Console.WriteLine(String.Join(",", array));


int PositiveSum = 0;
int NegativeSum = 0;

foreach (int element in array)// перебирает весь массив типа как for, но без счетчиков. И он не может менять элементы! Только смотреть!
{
    PositiveSum += element > 0 ? element : 0;// запись в одну строку, что надо суммировать все элементы больше нуля:
    // if (element > 0)                             а в противном случае прибавлять ноль. ВСегда необходим else для этой функции
    // {
    //     PositiveSum+=element;
    // }
    // else PositiveSum+=0;

    NegativeSum += element < 0 ? element : 0;
}

Console.WriteLine($"Сумма положительных числе равна {PositiveSum}, а отрицательных {NegativeSum}.");

