// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).
// Например:
// ● 4 -> 16
// ● -3 -> 9
// ● -7 -> 49

Console.Clear();

Console.Write("Enter number: ");
int number=int.Parse(Console.ReadLine()!);

int sqr=number*number;
double sqr2=Math.Pow(number,2);

Console.WriteLine($"The square of the number {number} is {sqr}");
Console.WriteLine($"The square of the number {number} is {sqr2}");





