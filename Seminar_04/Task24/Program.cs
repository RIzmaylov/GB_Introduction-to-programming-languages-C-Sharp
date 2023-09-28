// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbersInN(int N)
{
    int sum = 0;
    for (int i = 1; i <= N; ++i)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел - {SumNumbersInN(A)}");