// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3        4 3 4 3
// 4 3 4 1 =>     4 3 4 1
// 2 9 5 4        2 9 25 4
int[,] CreateNewMatrix(int rows, int cloumns, int min, int max)
{                        //  0       1
    int[,] matrix = new int[rows, cloumns];
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

void ReplaseEvenIdxElemToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)//3
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)//4
        {
            matrix[i,j] *= matrix[i,j];
        }
            
    }
}

int[,] array2d = CreateNewMatrix(3,4,1,10);
ShowMatrix(array2d);
Console.WriteLine();
ReplaseEvenIdxElemToSquare(array2d);
ShowMatrix(array2d);
