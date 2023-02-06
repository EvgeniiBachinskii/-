// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

Console.Clear();
Console.WriteLine("enter n");
int N = int.Parse(Console.ReadLine()!);
if (N % 7==0)
{
    if (N % 23 == 0)
    {
        Console.WriteLine("da");
    }
    else
    {
        Console.WriteLine("no");
    }
}
else
{
        Console.WriteLine("no");
}

