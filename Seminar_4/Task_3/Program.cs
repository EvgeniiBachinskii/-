// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int SS(int N)
{
    int ss = 1;
    for (int i = 2; i <= N; i++)
    {
        ss *= i;
    }
    return ss;
}

Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Super summ {num} eto {SS(num)}");

// READY