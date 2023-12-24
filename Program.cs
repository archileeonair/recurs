// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void ReleaseArray(int m, int n)
// {
//     if (m > n)
//         return;
//     if (m > 0)
//     {
//         Console.Write($"{ m}, ");
//     }
//     ReleaseArray(m + 1, n);
// }

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ReleaseArray(m, n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void rec(int n, int min){
//     if(n == min){
//         return;
//     }
//     return rec(n - 1, min) + n;
// }

void Reverse(int[] array, int start, int end)
{
    if (start >= end)
    {
        return;
    }
    int tmp = array[start];
    array[start] = array[end];
    array[end] = tmp;
    Reverse(array, start + 1, end - 1);
    return array;
}

Console.Clear();
int[] array = new int[3] { new Random().Next(-5, 6), new Random().Next(-5, 6), new Random().Next(-5, 6) };
Console.Write(string.Join(", ", array));
int n = array.Length;
int min = array.Min();
Console.WriteLine(string.Join(", ", Reverse(array, 0, n)));

