// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int PrintRec(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{PrintRec(n, m + 1)}, ");
    return m;
}

Console.Write("Введите целое положительное число N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

if (n < 1)
{Console.WriteLine("Число не положительное, введите другое");}

int m = 1;

Console.WriteLine(PrintRec(n, m));



