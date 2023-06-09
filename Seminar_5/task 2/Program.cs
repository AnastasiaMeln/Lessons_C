// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

int sumNumbers(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result = result + array[i];
    return result;    
}


Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(sumNumbers(array));