// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите номер дня недели: ");
int N = int.Parse(Console.ReadLine()!);

if (N<=5 && N>=1) Console.WriteLine("Нет");
if (N>=6 && N<=7) Console.WriteLine("Да");
if (N<1) Console.WriteLine("Нет такого дня недели");
if (N>7) Console.WriteLine("Нет такого дня недели");
