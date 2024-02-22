//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int remainder = num % 7 + num % 23;
if (remainder == 0)
{
    Console.WriteLine($"{num} кратно 7 и 23");
}
else
{
    Console.WriteLine($"{num} Не кратно 7 и 23");
}