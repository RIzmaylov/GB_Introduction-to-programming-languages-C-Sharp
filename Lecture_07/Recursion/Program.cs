// Итеративный способ: от 1 до n
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; ++i)
    {
        result += $"{i} ";
    }
    return result;
}

//Рекурсивный способ: от 1 до n
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

//Сумма чисел

int SumFor(int n)
{
    int res = 0;
    for (int i = 1; i <= n; ++i) res += i;
    return res;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

// Факториал

int FactorialFor(int n)
{
    int res = 1;
    for (int i = 1; i <= n; ++i) res *= i;
    return res;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));

// Степень

int PowerFor(int a, int n)
{
    int res = 1;
    for (int i = 1; i <= n; ++i) res *= a;
    return res;
}

int PowerRec(int a, int n)
{
    //return n == 0 & 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));

// Перебор слов на поиск буквы
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return ;
    }
    for (int i = 0; i < alphabet.Length; ++i)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);

// просмотр директорий

string path = "D:\\ПРОГРАММИРОВАНИЕ\\GeekBrains C++ Reload\\1 quarter\\Introduction to programming languages C#\\Lecture_07\\Recursion";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; ++i)
{
    Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; ++i)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; ++i)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path2 = "D:\\ПРОГРАММИРОВАНИЕ\\GeekBrains C++ Reload\\1 quarter\\Introduction to programming languages C#\\Lecture_07";
CatalogInfo(path2);

// Ханойская башня

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

// Обход бинарного дерева как метод подсчета арифметического выражения

string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                  0    1    2     3    4    5     6    7   8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();

// Показательное унижение рекурсии через нахождение Фибоначей

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; ++i)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5 6
//V 1 1 2 3 5 8
DateTime dt = DateTime.Now;
// Console.ReadLine();
for (int m = 10; m < 40; ++m)
{
    Console.WriteLine($"FibonacciIteration({m}) = {FibonacciIteration(m)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
// Console.ReadLine();

dt = DateTime.Now;
for (int m = 10; m < 40; ++m)
{
    Console.WriteLine($"FibonacciRecursion({m}) = {FibonacciRecursion(m)} fIte = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.ReadLine();