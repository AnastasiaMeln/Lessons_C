//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);
if (a < b)
    Console.WriteLine($"Наибольшее число - {b}");
else
{
    Console.WriteLine($"Наибольшее число - {a}");
}    