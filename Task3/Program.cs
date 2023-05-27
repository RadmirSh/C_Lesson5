// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int sizeArray = 8;
int[] counts = new int[sizeArray];
FillArrayRandomElements(counts);
PrintArray(counts);

int max = counts[0];
int min = counts[0];

for (int i = 0; i < counts.Length; i++)
{
    if (counts[i] > max)
    {
        max = counts[i];
    }
    else if (counts[i] < min)
    {
        min = counts[i];
    }
}

Console.WriteLine($"Minimum number: {min}");
Console.WriteLine($"Minimum number: {max}");
Console.WriteLine($"Difference between maximum and minimum elements of array: {max-min}");

Console.WriteLine("\n");



void FillArrayRandomElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1022);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}