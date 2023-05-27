// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Enter the number of array elements: ");

int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[elementsCount];

void makeArray(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(0,999);
        Console.Write(randomArray[i] + " ");
    }

}

int sumArray(int[] randomArray)
{
    int sum = 0;
    int i = 0;

    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

makeArray(elementsCount);

Console.Write($"\n Sum of elements at the odd positions: {sumArray(randomArray)}");

Console.WriteLine("\n");
