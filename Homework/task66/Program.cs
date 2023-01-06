﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summa(int N, int M) 
{ 
    if (N == M) return M; 
    else return Summa(N - 1, M) + N;
}

Console.Write("Введите целое число M: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите целое число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
  
Console.WriteLine($"M={M}; N={N} -> Сумма чисел между ними равна {Summa(N,M)}"); 
 
