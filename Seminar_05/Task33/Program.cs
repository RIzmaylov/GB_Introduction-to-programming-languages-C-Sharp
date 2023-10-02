// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-99, 100);
    }
}

bool FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (FindNum(arr, num))
    Console.WriteLine("Да!");
else
    Console.WriteLine("Нет!");
