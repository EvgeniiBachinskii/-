// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int A)       // создаем функцию
{
    int sum = 0;            // изначально сумма равна 0
    for (int i = 0; i <= A; i++) // цикл на перебор и суммирование
    {
        sum += i; // sum = sum + i  // сами суммирование
    }
    return sum; // после завершения цикла надо вернуть сумму
}

Console.Clear();
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Summ ot 1 do {N} ravna {GetSum(N)}");  // выдача с вызовом метода


