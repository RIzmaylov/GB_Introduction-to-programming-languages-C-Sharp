// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(0, 1000);
    }
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));

int cnt = 0;

for (int i = 0; i < arr.Length; ++i)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        cnt++;
    }
}
Console.WriteLine($"Количество чисел в диапазоне [10, 99] - {cnt}");