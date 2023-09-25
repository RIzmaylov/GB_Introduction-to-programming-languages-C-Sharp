// Задача №17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

void WriteQuarter(int X, int Y)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("Точка находится в 1 четверти");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("Точка находится в 2 четверти");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверти");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("Точка находится в 4 четверти");
    }
    else
    {
        Console.WriteLine("Точка не может содержать координату 0");
    }
}

Console.Write("Введите X точки: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки: ");
int Y = Convert.ToInt32(Console.ReadLine());

WriteQuarter(X, Y);
