
// 1. НАПИСАТЬ ВСЕ ЧИСЛА ОТ А ДО B

// РЕШЕНИЕ В ПРЯМУЮ

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";  //накапливает строку
    }
    return result;
}

// РЕШЕНИЕ ЧЕРЕЗ РЕКУРСИЮ

string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b} ";
}

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// 2. НАЙТИ СУММУ ЧИСЕЛ ОТ 1 до N

int SumFor(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++) sum += i;
    return sum;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// С ФАКТОРИАЛОМ ТАК ЖЕ, ТОЛЬКО УМНОЖАТЬ

// 3. ВЫЧИСЛИТЬ a В СТЕПЕНИ n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a;  Алтернативная запись в 1 строку
}
// решение, используя математику ( a^m * a^n = a^m+n; (a^m)^n = a^(m*n) )
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}


// ПЕРЕБОР СЛОВ. ВЫВЕСТИ ВСЕ ВОЗМОЖНЫЕ СЛОВА ИЗ ЗАДАННЫХ БУКВ

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
//     }
// }

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char [4]);