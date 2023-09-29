// Домашнее задание по семинару 4

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 4 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (25, 27, 29): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 25 && numTask != 27 && numTask != 29)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (25, 27, 29): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

int NumDeg(int num, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; ++i)
    {
        result *= num;
    }
    return result;
}

int SumInNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

void FillArray(int[] collection)
{
    Console.WriteLine("Введите 8 чисел в массив, каждое в новой строке: ");
    for (int i = 0; i < collection.Length; ++i)
    {
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 25:
    {
        Console.WriteLine("Задача 25: Написать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.Write("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите натуральную степень: ");
        int deg = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Число {num} в степени {deg} - {NumDeg(num, deg)}");
        break;
    }
    case 27:
    {
        Console.WriteLine("Задача 27: Написать программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.Write("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Сумма цифр в числе {num} - {SumInNum(num)}");
        break;
    }
    case 29:
    {
        Console.WriteLine("Задача 29: Написать программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        int[] array = new int[8];
        FillArray(array);
        System.Console.WriteLine('[' + string.Join(", ", array) + ']');
        break;
    }
} 
