// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance2D(double X1, double Y1, double X2, double Y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)), 3);
}

Console.Write("Координату Х первого числа: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату Y первого числа: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату Х второго числа: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату Y второго числа: ");
double Y2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance2D(X1, Y1, X2, Y2);
Console.WriteLine($"Расстояние между двух точек - {distance}");