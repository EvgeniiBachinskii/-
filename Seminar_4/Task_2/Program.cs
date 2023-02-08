// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int NumCount(int N)   // задали метод
{
    int count = 0;
    if (N > 0)
    {
        while (N > 0)
        {
            N /= 10;
            count++;
        }
    }
    else
    {
        count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Count numbers in {num} eto {NumCount(num)}");

// READY