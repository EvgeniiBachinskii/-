// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Введите x: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0)
{
    if (Y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Четвертая четверть");
    }
}
else
{
    if (Y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}

// READY
