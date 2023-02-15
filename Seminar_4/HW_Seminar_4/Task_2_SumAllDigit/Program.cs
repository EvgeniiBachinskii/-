// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int N)
{
    int sum = 0;
    for (N = N; N > 0; N /= 10)     // здесь надо было через while, чтобы не прописывать N=N, это нерамотно 
    {
        int i = N % 10;         // здесь я ввел лишнюю переменную
        sum = sum + i;  // можно было одной строкой записать sum += N % 10, то есть
    }                   // sum = sum + N % 10
    return sum;
}

Console.Clear();
Console.WriteLine("Enter the number: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum numbers of {b} ravno {SumNumbers(b)}");

// READY

// ЭТАЛОННОЕ:

// int Prompt(string message) // функция на ввод числа
// {
//     Console.Write(message); //вводим приглашение ко вводу
//     string readInput = Console.ReadLine()!; // вводим значение
//     int result = int.Parse(readInput); // приводим к числу
//     return result;  // возвращаем результат
// }

// int SumAllDigit(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }

// int chislo = Prompt("Введите число: ");
// Console.WriteLine($"Сумма цифр в числе {chislo} равна {SumAllDigit(chislo)}.");

