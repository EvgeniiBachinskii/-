// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = N;
int R = 0;
if (N > 9999)
{
    while (N2 > 0)
    {
        R = (R * 10) + (N2 % 10);
        N2 = N2 / 10;
    }
    if (N == R)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    while (N < 9999)
    {
        Console.Clear();
        Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число: ");
        N = int.Parse(Console.ReadLine()!);
        N2 = N;
        R = 0;
        if (N > 9999)
        {
            while (N2 > 0)
            {
                R = (R * 10) + (N2 % 10);
                N2 = N2 / 10;
            }
            if (N == R)
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
        }
    }
}

// READY