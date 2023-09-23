// Домашнее задание по семинару 2

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 2 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (10, 13, 15): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 10 && numTask != 13 && numTask != 15)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (10, 13, 15): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 10:
    {
        Console.WriteLine("Задача 10. Написать программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.Write("Введите трехзначное целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        while (num1 < -999 || num1 > -100 && num1 < 100 || num1 > 999)
        {
            Console.Write("Введите корректное трехзначное целое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Вторая цифра введенного числа - {Math.Abs(num1 % 100 / 10)}");
        break;
    }
    case 13:
    {
        Console.WriteLine("Задача 13. Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.Write("Введите целое число: ");
        string? numberInString = Console.ReadLine();
        if (numberInString != null)
        {
            int index = 2;
            if (numberInString[0] == '-')
                index = 3;
            if (numberInString.Length < index + 1)
            {
                Console.Write("Третьей цифры нет.");
                break;
            }
            Console.Write("Третья цифра введенного числа - " + numberInString[index]);
        }
        break;
    }
    case 15:
    {
        Console.WriteLine("Задача 15. Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.Write("Введите целое число - порядковый номер дня недели (1 - 7): ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        while (num1 < 1 || num1 > 7)
        {
            Console.Write("Введите корректный порядковый номер дня недели (1 - 7): ");
            num1 = Convert.ToInt32(Console.ReadLine());
        }
        if (num1 < 6) Console.Write("Это будний день!");
        else Console.Write("Это выходной день!");
        break;
    }
    default: break;
}