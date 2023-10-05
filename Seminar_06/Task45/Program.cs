// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(1, 10);
    }
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
int[] arr2 = new int [size];
for (int i = 0; i < arr.Length; ++i)
{
    arr2[i] = arr[i];
}
Console.WriteLine(string.Join(", ", arr2));
arr[1] = 100;
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", arr2));