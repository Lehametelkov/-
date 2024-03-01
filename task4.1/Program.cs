// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int size = 1000;
int min = 1;
int max = 1000;

int[] array = CreateArrayRndInt(size, min, max);
PrintArray(array);

int countPrimeNumb = CountPrimeNumb(array);
Console.WriteLine($"\nКоличество простых чисел в массиве: {countPrimeNumb}");


static int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

static bool IsPrime(int num)
{
    if (num < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}

static int CountPrimeNumb(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (IsPrime(arr[i]))
        {
            count++;
        }
    }

    return count;
}
