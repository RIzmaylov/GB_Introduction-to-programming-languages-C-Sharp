// Домашнее задание по семинару 6

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 6 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (41, 43): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 41 && numTask != 43)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (41, 43): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 41:
    {
        Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.Write("Введите целое число, количество чисел: ");
        int M = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[M];
        int cntr = 0;
        for (int i = 0; i < M; ++i)
        {
            Console.Write($"Введите {i + 1}-е число: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] > 0) cntr++;
        }
        Console.Write($"Количество введенных чисел больше нуля - {cntr}");
        break;
    }
    case 43:
    {
        Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Console.Write("Введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        if (k1 == k2)
        {
            if (b1 == b2)
            {
                Console.WriteLine("Прямые совпадают!");
                break;
            }
            Console.WriteLine("Прямые параллельны!");
            break;
        }
        double x = 0.0, y = 0.0;
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        Console.WriteLine($"Координаты пересечения прямых - ({x}, {y})");
        break;
    }
}