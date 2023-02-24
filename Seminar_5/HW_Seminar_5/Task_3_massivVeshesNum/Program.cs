// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//СОЗДАНИЕ МАССИВА ВЕЩЕСТВЕННЫХ ИЗ ИНТЕРНЕТА:

// double[] array = new double[5];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(5 - rand.Next(11) + rand.NextDouble(), 3);
// }

// СОЗДАНИЕ МАССИВА ВЕЩЕСТВЕННЫХ С СЕМИНАРА. В ОБЫЧНОЙ ФУНКЦИИ ГЕТЭРРЭЙ ПОМЕНЯТЬ ВСЕ НА ДАБЛ И НЭКСТДАБЛ УМНОЖИТЬ НА ДЛИНУ ОТРЕЗКА И 
// ПРИБАВИТЬ МИНИМУМ НА СЛУЧАЙ ЕСЛИ НЭКСТДАБЛ СДЕЛАЕТ НОЛЬ:

double[] GetArray(int size, double min, double max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 3);
    }
    return array;
}


// ФУНКЦИЯ НАХОЖДЕНИЯ РАЗНИЦА МАКС/МИН:

double subtraction(double[] InArray)
{
    double min = InArray[0];
    double max = InArray[0];
    for (int i = 0; i < InArray.Length; i++)
    {
        if (InArray[i] < min) min = InArray[i];
    }
    for (int a = 0; a < InArray.Length; a++)
    {
        if (InArray[a] > max) max = InArray[a];
    }
    double sub = Math.Round(max - min, 3);
    return sub;
}

double[] array = GetArray(5, 1, 50);

Console.WriteLine($"{String.Join("|", array)} -> {subtraction(array)}");


