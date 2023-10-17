// Домашнее задание по семинару 9

void RecRoadTo1FromN(int N)
{
    if (N == 0) return;
    Console.Write($"{N} ");
    RecRoadTo1FromN(N - 1);
}

int RecSumFromMToN(int M, int N)
{
    if (N <= M) return M;
    return RecSumFromMToN(M, N - 1) + N;
}

int RecAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return RecAkkerman(M - 1, 1);
    if (M > 0 && N > 0) return RecAkkerman(M - 1, RecAkkerman(M, N - 1));
    return 0;
}

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 9 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (64, 66, 68): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 64 && numTask != 66 && numTask != 68)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (64, 66, 68): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 64:
    {
        Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
        Console.Write("Введите число N - ");
        int N = Convert.ToInt32(Console.ReadLine());
        RecRoadTo1FromN(N);
        break;
    }
    case 66:
    {
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.Write("Введите число M - ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N - ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (M > N)
        {
            int temp = M;
            M = N;
            N = temp;
        }
        Console.WriteLine($"Сумма натуральных элементов от {M} до {N} = {RecSumFromMToN(M, N)}");
        break;
    }
    case 68:
    {
        Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.Write("Введите неотрицательное число M - ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите неотрицательное число N - ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат вычисления по формуле Аккермана от чисел ({M}, {N}) = {RecAkkerman(M, N)}");
        break;
    }
    default: break;
}