// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumb(int n)
{
    if (n / 10 == 0) return n;
    return SumNumb(n / 10) + n % 10;
}

Console.WriteLine(SumNumb(10));