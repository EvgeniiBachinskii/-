// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GetArray(int N) // ввод метода создания заполненного массива из N элементов
// {
//     int[] array = new int[N]; // создание пустого массива с N количеством ячеек
//     for (int i = 0; i < N; i++) //  цикл наполнения массива. Записывает в каждую ячейку рандомное число 
//     {                           // пока индекс не станет равен длине массива
//         array[i] = new Random().Next(0, 10);
//     }
//     return array; // возвращение готового массива
// }


// void printArray(int[] inArray)   // метод печати имеющегося массива. На вход принимает готовый массив
// {
//     int i = 0;              // сразу задан счетчик индексов
//     Console.Write($"[{inArray[i]}, ");  // чтобы первая ячейка была с [
//     i++;
//     while (i < inArray.Length - 1)   // далее цикл печати элементов от 2го до предпоследнего
//     {
//         Console.Write($"{inArray[i]}, ");
//         i++;
//     }
//     Console.Write($"{inArray[i]}]");   // печать последнего элемента с ]
// }

// printArray(GetArray(5));    // запуск обоих функций 

// READY

// ЭТАЛОННОЕ:

int Prompt(string message) // функция на ввод числа
{
    Console.Write(message); //вводим приглашение ко вводу
    string readInput = Console.ReadLine()!; // считываем строку
    int result = int.Parse(readInput); // приводим к числу
    return result;  // возвращаем результат
}

int[] GenerateArray(int Length, int minValue, int maxValue) // функция создания массива (длина, диапазон от, диапазон до)
{
    int[] array = new int[Length];  // создание пустого массива с определенным количеством ячеек (длиной)
    Random random = new Random();   // здесь на рандом заведена отдельная переменная, я же делал одной строчкой "array[i] = new Random().Next(0, 1000)"
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // заполнение массива псевдослучайными числами
    }
    return array;
}


void PrintArray(int[] array)  // функция печати массива У НИХ ЛУЧШЕ!
{
    Console.Write("[");     // печать открывающей скобки
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");   // печать всего содержимого, кроме последней ячейки
    }
    Console.Write($"{array[array.Length - 1]}"); // печать посл ячейкм без пробела
    Console.WriteLine("]");     // не понял зачем райтлайн с последней скобкой, почему нельзя сразу к последней ячейке добавить
}


int dlina = Prompt("Длина массива: ");
int minimum = Prompt("Начальное значение, для диапазона случайного числа: ");
int maximum = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] massiv = GenerateArray(dlina, minimum, maximum);
PrintArray(massiv);



