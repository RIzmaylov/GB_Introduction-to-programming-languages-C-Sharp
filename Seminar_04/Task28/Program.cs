// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int NumbersInN(int N)
{
    int prod = 1;
    for (int i = 1; i <= N; ++i)
    {
        prod *= i;
    }
    return prod;
}

Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел - {NumbersInN(N)}");
