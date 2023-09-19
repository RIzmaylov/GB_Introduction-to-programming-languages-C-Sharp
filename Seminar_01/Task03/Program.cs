// Задача №3. Напишите программу, 
// которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 1 || num > 7)
{
    Console.Write("Введите корректный номер дня недели: ");
    num = Convert.ToInt32(Console.ReadLine());
}
switch(num)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресение"); break;
    default : Console.WriteLine("Нет такого дня недели"); break;
}