// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rnd.Next(-99, 100);
    }
}

void NegToPos(int[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] *= -1;
    }
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [size];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
NegToPos(arr);
Console.WriteLine(string.Join(", ", arr));
