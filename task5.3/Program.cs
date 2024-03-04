// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 

int[,] CreateNewMatrix(int rows, int columns, int min, int max)
{                        //  0       1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)//3
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//4
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[] ArifmeticInRow(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        double tempAverage = sumRow / matrix.GetLength(1);
        array[i] = tempAverage;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 6} ");
    }
    Console.WriteLine();
}

int[,] matrix = CreateNewMatrix(4, 4, 0, 10);
ShowMatrix(matrix);
Console.WriteLine();
double[] mass = ArifmeticInRow(matrix);
PrintArray(mass);
