// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Реализовать функцию возведения в степень
// самостоятельно!

int Stepen(int n, int n2)
{
    int ss = n;
    for (int i = 1; i < n2; i++)
    {
        ss *= n;
    }
    return ss;
}

Console.Clear();
Console.WriteLine("Enter the number 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number 2: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} v stepeni {b} ravno {Stepen(a, b)}");

//READY


// ЭТАЛОННОЕ:

// int Prompt(string message) // функция на ввод числа
// {
//     Console.Write(message); //вводим приглашение ко вводу
//     string readInput = Console.ReadLine()!; // вводим значение
//     int result = int.Parse(readInput); // приводим к числу
//     return result;  // возвращаем результат
// }

// int Power(int powerBase, int exponent)  // функция возведения в степень (основание, экспонента)
// {
//     int power = 1;                      // здесь сделанно по другому, потому что любое число в степени 0
//     for (int i = 0; i < exponent; i++)   // равно еденице. А я этого не учел!
//     {
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent(int exponent) // функция проверки экспоненты на положительность
// {
//     if (exponent < 0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля!");
//         return false;
//     }
//     return true;
// }

// int osnovanie = Prompt("Введите основание: ");
// int pokazatel = Prompt("Введите показатель: ");
// if (ValidateExponent (pokazatel))             // то если степень положительная, то выдает true и запускает метод
// {                                           // если отрицательная, то выдает "Показатель не должен быть меньше нуля!"
//     Console.WriteLine($"Число {osnovanie} в степени {pokazatel} равно {Power(osnovanie,pokazatel)}");
// }