// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной
// диагонали: 1+9+2 = 12

// СПОСОБ С ДВУМЯ ЦИКЛАМИ:
int SumArray1(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    return sum;
}

// СПОСОБ С 1 ЦИКЛОМ, НО С ПРОВЕРКОЙ НА МИНИМАЛЬНОЕ ЗНАЧЕНИЕ СТРОК И СТОЛБЦОВ
int SumArray2(int[,] array)
{
    int sum = 0;
    int size = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0); // ЗНАЧИТ ПРИСВОИТЬ К НОВОЙ ПЕРЕМЕНОЙ
    // ЧЕРЕЗ ВОПРОС ОДНОЙ БОЛЬШЕ ДРУГОГО? ДАЛЕЕ ПРИСВОЕНИЕ ЕСЛИ ДА, ЧЕРЕЗ ДВОЕТОЧИЕ ПРИСВОЕНИЕ ЕСЛИ НЕТ
    for (int i = 0; i < size; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] arr = new int[,]
{
{1, 4, 7, 2, 1},
{5, 8, 2, 3, 2},
{8, 4, 5, 4, 3},
{8, 4, 3, 4, 4},
};

Console.Write(SumArray(arr));
