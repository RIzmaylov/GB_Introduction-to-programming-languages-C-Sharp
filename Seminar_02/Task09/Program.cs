// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
// int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Случайное число: {number}");
int digitFirst = number / 10;
int digitSecond = number % 10;

if (digitFirst > digitSecond)
{
    System.Console.WriteLine(digitFirst);
}
else if (digitFirst < digitSecond)
{
    System.Console.WriteLine(digitSecond);
}
else
{
    System.Console.WriteLine("Цифры равны");
}