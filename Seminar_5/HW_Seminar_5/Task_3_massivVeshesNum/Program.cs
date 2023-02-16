// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = 5 - rand.Next(11) + rand.NextDouble();
}


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
    double sub = max - min;
    return sub;
}




Console.WriteLine($"{String.Join("|", array)} -> {subtraction(array)}");


