// Задача №7. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
int number=int.Parse(Console.ReadLine()!);
Console.WriteLine(number % 10);