// Домашнее задание по семинару 3

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 3 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (19, 21, 23): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 19 && numTask != 21 && numTask != 23)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (19, 21, 23): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 19:
    {
        Console.WriteLine("Задача 19: Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.Write("Введите целое число: ");        
        int number = Convert.ToInt32(Console.ReadLine());
        string numberInString = Convert.ToString(number);
        int step = 0;
        int stringLength = numberInString.Length;
        while (step != stringLength / 2)
        {
            if (numberInString[step] != numberInString[stringLength - 1 - step]) break;
            step++;
        }
        if (step == stringLength / 2) Console.Write("Число палиндром!");
        else Console.Write("Число не палиндром!");
        break;
    }
    case 21:
    {
        Console.WriteLine("Задача 21: Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        Console.Write("Введите X, Y, Z 1ой точки (по координате в каждой строке)");        
        double X1 = Convert.ToDouble(Console.ReadLine());      
        double Y1 = Convert.ToDouble(Console.ReadLine());      
        double Z1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите X, Y, Z 2ой точки (по координате в каждой строке)");        
        double X2 = Convert.ToDouble(Console.ReadLine());      
        double Y2 = Convert.ToDouble(Console.ReadLine());      
        double Z2 = Convert.ToDouble(Console.ReadLine());
        
        double distance = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)), 2);
        Console.Write($"Расстояние между введенными точками - {distance}");  
        break;
    }
    case 23:
    {
        Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 4, 9. 5 -> 1, 8, 27, 64, 125");
        Console.Write("Введите целое число: ");        
        int numberN = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{numberN} -> "); 
        for (int i = 1; i < numberN; ++i)
        {
            Console.Write($"{Math.Pow(i, 3)}, "); 
        }
        Console.WriteLine($"{Math.Pow(numberN, 3)}"); 
        break;
    }
    default: break;
}