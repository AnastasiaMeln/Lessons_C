﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите пятизначное число: ");
string n = Console.ReadLine()!;
if (n[0] == n[4] && n[1] == n[3])
    Console.Write("Это палиндром");
else
    Console.Write("Это не палиндром");