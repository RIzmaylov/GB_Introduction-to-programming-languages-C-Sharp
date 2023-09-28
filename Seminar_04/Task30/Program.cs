// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; ++i)
    {
        collection[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] coll)
{
    for (int i = 0; i < coll.Length; ++i)
    {
        Console.Write($"[ {coll[i]} ]");
    }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();
System.Console.WriteLine('[' + string.Join(", ", array) + ']'); // альтернативный вариант вывода массива
Console.WriteLine();
