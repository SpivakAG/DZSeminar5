// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
PrintArray(array);
int max = array[0];
int min = array[0];

int maxSearch(int[] array, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}
int minSearch(int[] array, int minValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
    }
    return minValue;
}
max = maxSearch(array, max);
min = minSearch(array, min);
Console.WriteLine($"Максимум = {max}, минимум = {min}. Разница между наибольшим и наименьшим элементом массива равна {max - min}");

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(col[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine();
}