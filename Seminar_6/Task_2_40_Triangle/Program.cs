// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


void HaveTriangle(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Have");
    }
    else
    {
    Console.WriteLine("Not Have");
    }
}

Console.WriteLine("Enter z:");
double z = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter z:");
double x = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter z:");
double v = double.Parse(Console.ReadLine()!);


HaveTriangle(z, x, v);


// РЕШЕНИЕ С СЕМИНАРА:
// Console.Clear();

// bool CheckTriangele(int a, int b, int c)
// {
// return a < b + c && b < a + c && c < a + b;
// }

// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число c: ");
// int c = int.Parse(Console.ReadLine()!);

// if(CheckTriangele(a, b, c))
// {
// Console.WriteLine("Треугольник существует");
// }
// else
// {
// Console.WriteLine("Треугольника не существует");
// }

