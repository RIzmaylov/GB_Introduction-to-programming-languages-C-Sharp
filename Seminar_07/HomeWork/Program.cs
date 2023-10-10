// Домашнее задание по семинару 7

int[,] CreateAndFillIntMatrix()
{
    Random rnd = new Random();
    int n = rnd.Next(1, 10);
    int m = rnd.Next(1, 10);
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i,j] = rnd.Next(0, 9);
        }
    }
    return matrix;
}

void PrintIntMatrix(int[,] matrix)
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

bool IsIncludeIndex(int[,] matrix, int rows, int cols)
{
    if (rows >= 0 && cols >= 0 && rows < matrix.GetLength(0) && cols < matrix.GetLength(1)) 
        return true;
    return false;
}

double[,] FillDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i,j] = rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{Math.Round(matrix[i,j], 3)} ");
        }
        Console.WriteLine();
    }
}

double[] AverageInEachCol(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); ++j)
    {
        double tempSum = 0.0;
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            tempSum += matrix[i,j];
        }
        averages[j] = tempSum / matrix.GetLength(0);
    }
    return averages;
}

void PrintDoubleArray(double[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.Write($"{Math.Round(matrix[i], 3)} ");
    }
}

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 7 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (47, 50, 52): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 47 && numTask != 50 && numTask != 52)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (47, 50, 52): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 47:
    {
        Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.Write("Введите число m - ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n - ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] matrix = FillDoubleMatrix(m, n);
        PrintDoubleMatrix(matrix);
        break;
    }
    case 50:
    {
        Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        int[,] matrix = CreateAndFillIntMatrix();
        PrintIntMatrix(matrix);
        Console.WriteLine();
        Console.Write("Введите номер строки - ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца - ");
        int col = Convert.ToInt32(Console.ReadLine());
        if (IsIncludeIndex(matrix, row, col))
            Console.WriteLine($"Число на позиции [{row},{col}] = {matrix[row, col]}");
        else
            Console.WriteLine("Такого числа в массиве нет");
        break;
    }
    case 52:
    {
        Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. ");
        int[,] matrix = CreateAndFillIntMatrix();
        PrintIntMatrix(matrix);
        Console.WriteLine();
        double[] averages = AverageInEachCol(matrix);
        PrintDoubleArray(averages);
        break;
    }
}