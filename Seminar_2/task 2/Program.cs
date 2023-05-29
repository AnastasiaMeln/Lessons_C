// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
    Console.Write("Нет третьей цифры");
else
{
    string str = Convert.ToString(n);
    Console.Write(str[2]);
}