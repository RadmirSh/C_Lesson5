// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] makeArray(int length, int min, int max) //создание массива
{
    int[] firstArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        firstArray[i] = new Random().Next(min, max);
    }

    return firstArray;
}

void PrintArray(Array Array1)  // вывод массива
{
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.Write("array: ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.Write("[ ");

    int counter = Array1.Length;

    foreach (var n in Array1)
    {
        Console.Write($"{n}");
        counter--;

        if (counter > 0)
            Console.Write(", ");
    }
    Console.Write(" ]");
    Console.ForegroundColor = ConsoleColor.White;
}

int randomArray(int[] givenArray)   // решение задачи
{
    int counter = 0;
    for (int i = 0; i < givenArray.Length; i++)
    {
        if (givenArray[i] % 2 == 0)
        {
            counter++;
        }
    }

    return counter;
}

int[] firstArray = makeArray(8, 10, 299);
int evenCount = randomArray(firstArray);
PrintArray(firstArray);
Console.Write($" Even numbers in array is {evenCount}");




