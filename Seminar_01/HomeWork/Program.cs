// Домашнее задание по семинару 1

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 1 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (2, 4, 6, 8): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 2 && numTask != 4 && numTask != 6 && numTask != 8)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (2, 4, 6, 8): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 2:
    {
        Console.WriteLine("Задача 2. Написать программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.");
        Console.Write("Введите первое целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Максимальное из двух чисел - {Math.Max(num1, num2)}");
        if (num1 > num2)
        {
            Console.WriteLine($"Максимальное из двух чисел - {num1}, минимальное - {num2}");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"Максимальное из двух чисел - {num2}, минимальное - {num1}");
        }
        else
        {
            Console.WriteLine("Числа одинаковы!");
        }
        break;
    }
    case 4:
    {
        Console.WriteLine("Задача 4: Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
        Console.Write("Введите первое целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье целое число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Максимальное из трех чисел - {Math.Max(num1, Math.Max(num2, num3))}");
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        Console.WriteLine($"Максимальное из трех чисел - {max}");
        break;
    }
    case 6:
    {
        Console.WriteLine("Задача 6: Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
        Console.Write("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Число {num} является " + (num % 2 == 0 ? "четным!" : "нечетным!"));
        break;
    }
    case 8:
    {
        Console.WriteLine("Задача 8: Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
        Console.Write("Введите натуральное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        while (num < 1)
        {
            Console.Write("Введите натуральное число - это целое число больше нуля: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        if (num == 1)
        {
            Console.WriteLine("Для этого числа четных чисел нет");
            break;
        }
        int step = 2;
        Console.Write($"Четные числа от 1 до {num} -> (");
        while (step <= num)
        {
            Console.Write($" {step} ");
            step += 2;
        }
        Console.Write(")");
        break;
    }
    default: break;
}
