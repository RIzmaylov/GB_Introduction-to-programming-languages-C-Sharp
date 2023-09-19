// Задача №5. Напишите программу, 
// которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 0)
{
    Console.Write("Введите целое положительное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int num2 = -num;
Console.Write($"{num} -> (");
Console.Write(num2);
num2++;
while (num2 <= num)
{
    Console.Write($", {num2}");
    num2++;
}
Console.Write(")");