// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();

// int x = new Random().Next(100, 1000);
// Console.WriteLine(x);
// Console.WriteLine((x / 10) % 10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();

// int x = new Random().Next(0, 100000);
// string N = x.ToString();
// Console.WriteLine(x);

// if (x < 100) Console.WriteLine("Третьей цифры нет");
// else Console.WriteLine(N[2]);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите порядковый номер дня недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i == 6 || i == 7) Console.WriteLine("Да");
else if (i < 1 || i > 7) Console.WriteLine("Вы ввели неверные данные");
else Console.WriteLine("Нет");