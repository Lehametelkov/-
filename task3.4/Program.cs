// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите натуральное трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
int i = 0;

while (Num > 0)
{
    array[i] = Num % 10;
    i++;
    Num = Num / 10;
}

for (int j = 0; j < array.Length; j++)
{
    Console.Write($"{array[j]} ");
}