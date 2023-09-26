// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        ++i;
    }
}
Method21("Текст", 4);    // Стандартный вызов функции
Method21(count: 4, msg: "Текст 2");   // Вызов с явным указанием аргументов, можно в разном порядке относительно объявления

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

Console.WriteLine(Method3());

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while ( i < count)
    {
        result += text;
        ++i;
    }
    return result;
}

Console.WriteLine(Method4(5, "Text"));

string Method41(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; ++i)
    {
        result += text;
    }
    return result;
}

Console.WriteLine(Method41(5, "Text2"));

//----------------------------------------------------------------------------

for (int i = 2; i <= 10; ++i)
{
    for (int j = 2; j <= 10; ++j)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

//----------------------------------------------------------------------------

//========== Работа с текстом
// Дан текстю Втексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

//---------------------------------------------------------

int[] arr = {1, 4, 2, 6, 7, 8, 3, 6, 4, 7};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; ++i)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; ++i)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; ++j)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);