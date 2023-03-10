//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Напишите целое число");
int num0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNum(num0)}");
Console.WriteLine($"{SumNumRec(num0)}");
int SumNum(int num0)
{
    int sum = 0;

    while (true)
    {
        sum = sum + num0 % 10;
        num0 = num0 / 10;
        if (num0 == 0)
            break;
    }
    return sum;
}

int SumNumRec(int num0)
{
    int sum = 0;
    if (num0 == 0) return 0;
    sum = SumNumRec(num0 / 10) + num0 % 10;
    return sum;
}
