// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
    int evenCheck = array[i] % 2;
    if (evenCheck == 0)
    {
        evenCount++;
    }
}
PrintArray(array);

Console.WriteLine($" Количество четных чисел в массиве равно {evenCount}");

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(col[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
}