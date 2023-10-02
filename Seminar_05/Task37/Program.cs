// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] result;

if (size % 2 == 0)
    result = new int [size / 2];
else
{
    result = new int [size / 2 + 1];
    result[size / 2] = arr[size / 2];
}
for (int i = 0; i < arr.Length / 2; i++)
{
    result[i] = arr[i] * arr[arr.Length - i - 1];
}
Console.WriteLine(string.Join(", ", result));