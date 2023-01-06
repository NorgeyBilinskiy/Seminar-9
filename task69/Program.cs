// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Напишите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Power(numA, numB)}");
Console.WriteLine($"{PowerRec(numA, numB)}");
int Power(int numA, int numB)
{
    int res = 1;
    while (true)
    {
        res = res * numA;
        numB--;
        if (numB == 0)
            break;
    }
    return res;
}

int PowerRec(int numA, int numB)
{
    int res = 1;
    if (numB == 0) return 1;
    res = PowerRec(numA, numB - 1) * numA;
    return res;
}
