// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void CalculateArithmeticMeanInCol(int[,] array)
{
    int col = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    while (col < array.GetLength(1))
    {
        int row = 0;
        double sum = 0;
        while (row < array.GetLength(0))
        {
            sum += array[row, col];
            row++;
        }
        Console.Write($" {Math.Round(sum / array.GetLength(0), 2)};");
        col++;
    }
}

int[,] newArray = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

CalculateArithmeticMeanInCol(newArray);