// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Фибоначи это последовательность чисел начиная с 0 и 1, где каждое последующее равно сумме 2х предыдущих

Console.Clear();

int[] Fibo(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}


// int[] Farray = Fibo(10);
// Console.WriteLine(String.Join(" ", Farray));

Console.WriteLine(String.Join(" ", Fibo(70)));


