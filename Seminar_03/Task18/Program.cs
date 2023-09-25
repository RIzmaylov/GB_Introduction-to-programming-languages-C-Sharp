// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

void WritePossibleNumsByQuarter(int quarter)
{
    switch(quarter)
    {
        case 1:
        {
            Console.WriteLine("X > 0, Y > 0");
            break;
        }
        case 2:
        {
            Console.WriteLine("X < 0, Y > 0");
            break;
        }
        case 3:
        {
            Console.WriteLine("X < 0, Y < 0");
            break;
        }
        case 4:
        {
            Console.WriteLine("X > 0, Y < 0");
            break;
        }
        default: 
        {
            Console.WriteLine("Такой четверти нет!");
            break;
        }
    }
}

void QuartersArray(int quarter)
{
    string[] quarters = {"X > 0, Y > 0", 
                         "X < 0, Y > 0",
                         "X < 0, Y < 0",
                         "X > 0, Y < 0"};
    if (quarter < 1 || quarter > 4)
        Console.WriteLine("Такой четверти нет!");
    else
        Console.WriteLine(quarters[quarter - 1]);
}

Console.Write("Введите номер четверти (1 - 4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

// WritePossibleNumsByQuarter(quarter);
QuartersArray(quarter);