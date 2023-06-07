// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");