// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!); 
int result = a * a;
if (b == 0)
    Console.WriteLine("1");
else if (b == 1)   
    Console.WriteLine(a);
else if (b > 1)
{    
    for (int i = 2; i < b; i++)
    result *= a;
    Console.WriteLine(result);
}
else
    Console.WriteLine("Степень отрицательная, мне такое не нравится");