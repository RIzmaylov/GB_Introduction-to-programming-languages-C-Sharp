// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int RecDegree(int A, int B)
{
    if (B == 0) return 1;
    return A * RecDergree(A, B - 1);
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} = {RecDegree(A, B)}");

