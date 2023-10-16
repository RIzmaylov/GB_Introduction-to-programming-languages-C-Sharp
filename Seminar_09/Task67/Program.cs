// Задача 67: Напишите программу, 
//которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigital(int N)
{
    if (N == 0) return 0;
    return N % 10 + SumDigital(N / 10);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {N} = {SumDigital(N)}");
