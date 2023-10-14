// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы.

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

int[,] TransformateMatrix(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        for (int j = 0; j < result.GetLength(1); ++j)
        {
            result[i,j] = matrix[j,i];
        }
    }
    return result;
}

Console.Write("Введите число m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
int[,] convertMatrix = TransformateMatrix(matrix);
Console.WriteLine();
PrintMatrix(convertMatrix);