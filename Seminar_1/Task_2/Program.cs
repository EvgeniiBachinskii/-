// Console.Clear();

// Console.Write("Enter number: ");
// int number=int.Parse(Console.ReadLine()!);

// int sqr=number*number;
// double sqr2=Math.Pow(number,2);

// Console.WriteLine($"The square of the number {number} is {sqr}");
// Console.WriteLine($"The square of the number {number} is {sqr2}");

// Задача №2. Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();

Console.Write("Enter number №1: ");
int number1=int.Parse(Console.ReadLine()!);
Console.Write("Enter number №2: ");
int number2=int.Parse(Console.ReadLine()!);

double sqr=Math.Pow(number2,2);

if (number1==sqr) 
    {
    Console.WriteLine($"Number №1 ({number1}) is the square of number №2");
    }

else Console.WriteLine($"Number №1 ({number1}) is not a square of number №2");
