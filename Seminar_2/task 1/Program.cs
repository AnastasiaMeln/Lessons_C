//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100 || n > 999)
    Console.Write("Нужно трехзначное число!");
else 
    Console.WriteLine(n / 10 % 10);