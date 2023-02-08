// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int N)
{
    int sum = 0;
    for (N = N; N > 0; N /= 10)
    {
        int i = N % 10;
        sum = sum + i;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Enter the number: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum numbers of {b} ravno {SumNumbers(b)}");

// READY







