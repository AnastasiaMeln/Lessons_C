// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите день недели: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 1 || n > 8)
    Console.Write("Нет такого дня недели");
else if (n == 6 || n == 7)
    Console.Write("Это выходной");
else
    Console.Write("Это рабочий день");
