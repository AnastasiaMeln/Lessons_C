//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max < b)
    max = b;
else if (max < c)
{
    max = c;
}    
Console.WriteLine($"Наибольшее число - {max}");
 
