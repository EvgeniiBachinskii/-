// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет


Console.Clear();
Console.WriteLine("enter n");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter n2");
int N2 = int.Parse(Console.ReadLine()!);

if (N == N2 * N2 || N2 == N * N ) // знак || это "или"
{
    Console.WriteLine("da");
}
    else
    {
        Console.WriteLine("no");
    }


