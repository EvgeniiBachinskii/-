// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindIntersectionLines()
{
    Console.WriteLine("Enter k1");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter k2");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter b1");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter b2");
    double b2 = double.Parse(Console.ReadLine()!);

    if ((k1 - k2) != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        if (x == 0 || y == 0)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine($"Точка пересечения прямых -> ({x}; {y})");
        }
    }
    else Console.WriteLine("Прямые не пересекаются");
}

FindIntersectionLines();

// y = k1 * x + b1
// y = k2 * x + b2

// y = 5 * x + 2
// y = 9 * x + 4

// 5x + 2 = 9x + 4           k1* x+b1=k2*x+b2
// 5x-9x=4-2                 k1*x-k2*x=b2-b1  
// -4x=2                     (k1-k2)*x = b2 - b1
// x = -0.5                     x = (b2 - b1) / (k1 - k2)

// y = 5 * -0.5 + 2
// y = -2.5 + 2
// y = -0.5





// ЭТАЛОННОЕ:

// const int COEFFICIENT = 0;
// const int CONSTANT = 1;
// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int LINE1 = 1;
// const int LINE2 = 2;

// double[] LineData1 = InputLineData(LINE1);
// double[] LineData2 = InputLineData(LINE2);

// if (ValidateLines(LineData1, LineData2))
// {
//     double[] coord = FindCoords(LineData1, LineData2);
//     Console.Write($"Точка пересечения уравнений y = {LineData1[COEFFICIENT]}*x+{LineData1[CONSTANT]} и y = {LineData2[COEFFICIENT]}*x+{LineData2[CONSTANT]} ");
//     Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
// }

// double Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }

// // ВВОД ДАННЫХ ПО ПРЯМОЙ
// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой");
//     lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой");
//     return lineData;
// }

// // ПОИСК КООРДИНАТ
// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//     double[] coord = new double[2];
//     coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
//     coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
//     return coord;
// }

// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//     if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
//     {
//         if (lineData1[CONSTANT] == lineData2[CONSTANT])
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны");
//             return false;
//         }
//     }
//     return true;
// }



