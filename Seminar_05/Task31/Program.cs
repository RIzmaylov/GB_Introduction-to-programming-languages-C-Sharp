// Задача 31: Задайте массив из N элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Вариант 1:
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];

int sumPositive = 0;
int sumNegative = 0;

FillArray(arr);
Console.WriteLine(string.Join(", ", arr));

for (int i = 0; i < arr.Length; ++i)
{
    if (arr[i] > 0)
    {
        sumPositive += arr[i];
    }
    else
    {
        sumNegative += arr[i];
    }
}
Console.WriteLine($"Сумма  положительных равна - {sumPositive}, а отрицательных - {sumNegative}");

// Вариант 2:

void SumPositiveAndNegative(int[] arr2, out int sumPositive2, out int sumNegative2)
{
    sumPositive2 = 0;
    sumNegative2 = 0;
    for (int i = 0; i < arr2.Length; ++i)
    {
        if (arr2[i] > 0)
        {
            sumPositive2 += arr2[i];
        }
        else
        {
            sumNegative2 += arr2[i];
        }
    }
}

Console.Write("Введите кол-во элементов массива 2: ");
int size2 = Convert.ToInt32(Console.ReadLine());

int[] arr2 = new int [size2];

FillArray(arr2);
Console.WriteLine(string.Join(", ", arr2));
SumPositiveAndNegative(arr2, out int sumP, out int sumN);
Console.WriteLine($"Сумма  положительных равна - {sumP}, а отрицательных - {sumN}");
