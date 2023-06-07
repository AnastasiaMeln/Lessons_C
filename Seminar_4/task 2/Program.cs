// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!); 
int result = 0;
while (n > 0)
{
    result += n % 10;
    n = n / 10;
}
Console.WriteLine(result);
