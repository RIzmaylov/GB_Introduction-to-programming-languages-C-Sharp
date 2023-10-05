// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int DecToBin(int n)
{
    if (n <= 0) return 0;
    return n % 2 + 10 * DecToBin(n / 2);
}


void GetBinaryView(int N)
{
    if (N == 0) return;
    GetBinaryView(N / 2);
    Console.Write(N % 2);
}

Console.Write("Введите целое число: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {X} в двоично виде - {DecToBin(X)}");
GetBinaryView(X);