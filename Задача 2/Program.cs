//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
}

int oddPositionSum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        oddPositionSum += array[i];
    }
}
PrintArray(array);

Console.WriteLine($" Сумма чисел с нечетными индексами = {oddPositionSum}");

void PrintArray(int[] col)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(col[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
}