// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21


Console.Clear();
Console.WriteLine("Введите х первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y первой точки: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите х второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);

double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

// S = Math.Round(S,3);

// Math.Round это округление до скольки-то знаков, с изменением последнего знака
// Math.Sqrt это корень из числа
// Math.Pow это возведение в степень

// Округлить можно еще так:
Console.WriteLine($"{S:f3}");

// Console.WriteLine(S);
