// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).


Console.Clear();

Console.WriteLine("Введите номер четверти:");
int N = int.Parse(Console.ReadLine()!);

while (N<1 || N>4)
{
    Console.WriteLine("Введите номер четверти (от 1 до 4!):");
    N = int.Parse(Console.ReadLine()!);
}

// if (N == 1 || N == 4) 
// {
//     Console.Write("Диапазон Х - больше нуля, ");
//     if (N == 1)
//     {
//        Console.Write("диапазон Y - больше нуля.");
//     }
//     else
//     {
//         Console.Write("диапазон Y - меньше нуля.");
//     }
// }
// else
// {
//    Console.Write("Диапазон Х - меньше нуля, ");
//     if (N == 2)
//     {
//        Console.Write("диапазон Y - больше нуля.");
//     }
//     else
//     {
//         Console.Write("диапазон Y - меньше нуля.");
//     } 
// }

// АЛьТЕРНАТИВА:

switch (N)
{
    case 1:
        Console.Write("Диапазон Х - больше нуля, диапазон Y - больше нуля.");
        break;
    case 2:
        Console.Write("Диапазон Х - меньше нуля, диапазон Y - больше нуля.");
        break;
    case 3:
        Console.Write("Диапазон Х - меньше нуля, диапазон Y - меньше нуля.");
        break;
    case 4:
        Console.Write("Диапазон Х - больше нуля, диапазон Y - меньше нуля.");
        break;
}