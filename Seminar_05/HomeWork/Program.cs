// Домашнее задание по семинару 5

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 5 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (34, 36, 38): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 34 && numTask != 36 && numTask != 38)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (34, 36, 38): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-100, 100);
    }
}

void FillArray3(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}

int CntEvenNums(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i] % 2 == 0) cnt++;
    }
    return cnt;
}

int SumNotEvenIndexNums(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; ++i)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; ++i)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 34:
    {
        Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.Write("Введите целое число, кол-во элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int [size];
        FillArray3(arr);
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine($"Количество четных чисел - {CntEvenNums(arr)}");
        break;
    }
    case 36:
    {
        Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.Write("Введите целое число, кол-во элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int [size];
        FillArray(arr);
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine($"Сумма элементов на нечетных индексах - {SumNotEvenIndexNums(arr)}");
        break;
    }
    case 38:
    {
        Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.Write("Введите целое число, кол-во элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] arr = new double [size];
        Console.Write("Введите числа массива каждое на новой строке: ");
        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine(string.Join(", ", arr));
        double max = FindMax(arr);
        double min = FindMin(arr);
        Console.WriteLine($"Разница между максимальным и минимальным элементами - {max - min}");
        break;
    }
}