// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98


Console.Clear();

int N = new Random().Next(100, 1000);
int a1 = N / 100;
// int a2 = (N/10)%10;
int a3 = N % 10;
int N2 = a1*10+a3;
Console.WriteLine(N);

Console.WriteLine(N2);
