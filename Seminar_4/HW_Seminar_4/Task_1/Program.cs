// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Реализовать функцию возведения в степень
// самостоятельно!

int Stepen(int n, int n2)
{
    int ss = n;
    for (int i = 1; i < n2; i++)
    {
        ss = ss * n;
    }
    return ss;
}

Console.Clear();
Console.WriteLine("Enter the number 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number 2: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} v stepeni {b} ravno {Stepen(a,b)}");

//READY