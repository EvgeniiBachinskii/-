// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string PrintDoN(int n)
{
    if (n == 1) return $"{n}";
    return PrintDoN(n - 1) + $", {n}";
}

Console.WriteLine(PrintDoN(5));

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string PrintOtMDoN(int m, int n)
{
    if (m == n) return $"{m}";
    return PrintOtMDoN(m, n - 1) + $", {n}";
}

Console.WriteLine(PrintOtMDoN(5, 10));
