// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// Пример
// [344 452 341 125] => 2

int ArrayToInteger(int[] array)
{
    int number = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            number++;
        }
    }
    return number;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int maximum = 1000;
int minimum = 100;


Console.WriteLine("Введите размер массива");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);

Console.WriteLine(ArrayToInteger(arrayMain));