// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите х первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y первой точки: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z первой точки: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите х второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z второй точки: ");
int z2 = int.Parse(Console.ReadLine()!);

double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Расстояние между точками = {S:f2}");

// READY