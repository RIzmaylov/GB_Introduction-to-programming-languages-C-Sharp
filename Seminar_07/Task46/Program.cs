﻿// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i,j] = rnd.Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);