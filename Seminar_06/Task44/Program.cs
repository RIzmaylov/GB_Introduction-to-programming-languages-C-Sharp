// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите целое число: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
if (size < 2) 
    Console.Write("Мало");
else
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    Console.WriteLine(string.Join(", ", arr));
}
