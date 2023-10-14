// Домашнее задание по семинару 8

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

// int[,] CreateAndFillIntMatrix()
// {
//     Random rnd = new Random();
//     int n = rnd.Next(1, 10);
//     int m = rnd.Next(1, 10);
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); ++i)
//     {
//         for (int j = 0; j < matrix.GetLength(1); ++j)
//         {
//             matrix[i,j] = rnd.Next(0, 9);
//         }
//     }
//     return matrix;
// }

void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

// bool IsIncludeIndex(int[,] matrix, int rows, int cols)
// {
//     if (rows >= 0 && cols >= 0 && rows < matrix.GetLength(0) && cols < matrix.GetLength(1)) 
//         return true;
//     return false;
// }

// double[,] FillDoubleMatrix(int m, int n)
// {
//     double[,] matrix = new double[m,n];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); ++i)
//     {
//         for (int j = 0; j < matrix.GetLength(1); ++j)
//         {
//             matrix[i,j] = rnd.NextDouble();
//         }
//     }
//     return matrix;
// }

// void PrintDoubleMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); ++i)
//     {
//         for (int j = 0; j < matrix.GetLength(1); ++j)
//         {
//             Console.Write($"{Math.Round(matrix[i,j], 3)} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] AverageInEachCol(int[,] matrix)
// {
//     double[] averages = new double[matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(1); ++j)
//     {
//         double tempSum = 0.0;
//         for (int i = 0; i < matrix.GetLength(0); ++i)
//         {
//             tempSum += matrix[i,j];
//         }
//         averages[j] = tempSum / matrix.GetLength(0);
//     }
//     return averages;
// }

// void PrintDoubleArray(double[] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); ++i)
//     {
//         Console.Write($"{Math.Round(matrix[i], 3)} ");
//     }
// }

void SortRowInMatrix(int[,] matrix)
{
    int max;
    for (int k = 0; k < matrix.GetLength(0); ++k)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; ++i)
        {
            max = i;
            for (int j = i + 1; j < matrix.GetLength(1); ++j)
            {
                if (matrix[k, j] > matrix[k, max])
                    max = j;
            }
            int temp = matrix[k, i];
            matrix[k, i] = matrix[k, max];
            matrix[k, max] = temp;
        }
    }
}

int[] FindRowMaxSumValues(int[,] matrix)
{
    int[] indexAndSum = new int[2];
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        int tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            tempSum += matrix[i, j];
        }
        if (indexAndSum[1] < tempSum)
        {
            indexAndSum[0] = i;
            indexAndSum[1] = tempSum;
        }
    }
    return indexAndSum;
}

bool MiltTwoMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for(int i = 0; i < result.GetLength(0); ++i)
        {
            for (int j = 0; j < result.GetLength(1); ++j)
            {
                for (int k = 0; k < matrix1.GetLength(1); ++k)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return true;
    }
    else return false;
}

int[,,] CreateAndFill3DMatrix()
{
    int[,,] matrix3D = new int[4,4,4];
    int start = 10;
    for (int i = 0; i < matrix3D.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix3D.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix3D.GetLength(2); ++k)
                matrix3D[i, j, k] = start++;
        }
    }
    return matrix3D;
}

void Print3DMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix3D.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix3D.GetLength(2); ++k)
                Console.WriteLine($"Число по индексу [{i}, {j}, {k}] = {matrix3D[i, j, k]}");
        }
    }
}

void FillSpiralMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1)) return;
    int n = matrix.GetLength(0);
    int currentChar = 1;
    for (int padding = 0; padding < n/2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
            matrix[padding, j] = currentChar++;
        for (int j = padding + 1; j < n - padding; j++)
            matrix[j, n - padding - 1] = currentChar++;
        for (int i = n - padding - 2; i >= padding; i--)
            matrix[n - padding - 1, i] = currentChar++;
        for (int i = n - padding - 2; i > padding; i--)
            matrix[i, padding] = currentChar++;
    }
    if (n % 2 != 0) matrix[n / 2, n / 2] = currentChar;
}

Console.WriteLine("Добрый день! Домашнее задание Измайлова Р.Э. по 8 семинару курса Введение в С#");
Console.Write("Введите номер задачи из перечисленных (54, 56, 58, 60, 62): ");
int numTask = Convert.ToInt32(Console.ReadLine());
while(numTask != 54 && numTask != 56 && numTask != 58 && numTask != 60 && numTask != 62)
{ 
    Console.Write("Введите корректный номер задачи из перечисленных (54, 56, 58, 60, 62): ");
    numTask = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы выбрали номер задачи - {numTask}");
switch(numTask)
{
    case 54:
    {
        Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.Write("Введите число m - ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n - ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = FillMatrix(m, n);
        PrintIntMatrix(matrix);
        SortRowInMatrix(matrix);
        Console.WriteLine();
        PrintIntMatrix(matrix);
        break;
    }
    case 56:
    {
        Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.Write("Введите число m - ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n - ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = FillMatrix(m, n);
        PrintIntMatrix(matrix);
        int[] result = FindRowMaxSumValues(matrix);
        Console.WriteLine($"Строка с максимальной суммой элементов - {result[0] + 1} с суммой = {result[1]}");
        break;
    }
    case 58:
    {
        Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.Write("Введите число m1 - ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n1 - ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = FillMatrix(m1, n1);
        PrintIntMatrix(matrix1);
        Console.WriteLine();
        Console.Write("Введите число m2 - ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n2 - ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[,] matrix2 = FillMatrix(m2, n2);
        PrintIntMatrix(matrix2);
        int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        if (MiltTwoMatrix(matrix1, matrix2, multMatrix))
        {
            Console.WriteLine("Результат умножения матриц:");
            PrintIntMatrix(multMatrix);
        }
        else
            Console.WriteLine("Матрицы умножить невозможно");
        break;
    }
    case 60:
    {
        Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        int[,,] matrix3D = CreateAndFill3DMatrix();
        Print3DMatrix(matrix3D);
        break;
    }
    case 62:
    {
        Console.WriteLine("Заполните спирально массив 4 на 4.");
        int m = 4, n = 4;
        int[,] matrix = new int[m, n];
        FillSpiralMatrix(matrix);
        PrintIntMatrix(matrix);
        break;
    }
}