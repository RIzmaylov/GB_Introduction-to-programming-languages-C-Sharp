// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CntInNum(int N)
{
    N = Math.Abs(N);
    int cnt = 0;
    if (N == 0) return 1;
    while (N > 0)
    {
        cnt++;
        N /= 10;
    }
    return cnt;
}

int CntInNumByString(int N)
{
    string num = Convert.ToString(Math.Abs(N));
    return num.Length;
}

Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число цифр в числе - {CntInNum(N)}");
Console.WriteLine($"Число цифр в числе через строку - {CntInNumByString(N)}");