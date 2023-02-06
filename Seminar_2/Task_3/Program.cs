// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Enter N1:");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N2:");
int N2 = int.Parse(Console.ReadLine()!);

if (N1 % N2 == 0)
{
    Console.WriteLine("Kratno");
}
else
{
    int N3 = N1 % N2;
    Console.WriteLine($"ne kratno, ostatok - {N3}");
}
