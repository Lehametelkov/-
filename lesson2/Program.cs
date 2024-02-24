// найти четные числа в массиве

int n = 10;
int[] array = {2, 3, 4, 8, -4, 25, 36, 2, 53, -3};
int i = 0;

while(i < n)
{
    if (array[i] % 2 == 0) 
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}