// возведение чисел от 1 до limit в квадрат с помощью функции


void PrintSquares(int limit) // void потому что 
{
    int i = 1;
    while (i <= limit)
    {
        Console.WriteLine($"{i*i} ");
        i++;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);