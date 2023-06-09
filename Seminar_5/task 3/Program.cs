// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
    int end = 30, begin = 10;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

Console.Clear();
double[] array = new double[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
double maxValue = array.Max();
double minValue = array.Min();
Console.WriteLine($"{maxValue} - {minValue} = {Math.Round(maxValue - minValue, 2)}");