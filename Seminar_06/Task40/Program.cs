// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if (A + B < C || A + C < B || B + C < A)
    Console.WriteLine("Такого треугольника быть не может!");
else
    Console.WriteLine("Такого треугольника можеть быть!");
