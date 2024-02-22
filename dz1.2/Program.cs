//  Напишите программу, которая принимает на вход координаты 
//  точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//  в которой находится эта точка.

Console.WriteLine("Введите значение X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Значение Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (Y != 0 && X != 0)
{
    if (Y > 0 && X > 0)
    {
        Console.WriteLine("Находится в первой четверти");
    }
    if (Y > 0 && X < 0)
    {
        Console.WriteLine("Находится во второй четверти");
    }
    if (Y < 0 && X < 0)
    {
        Console.WriteLine("Находится в третьей четверти");
    }
    if (Y < 0 && X > 0)
    {
        Console.WriteLine("Находится в четвертой четверти");
    }
}
else
{
Console.WriteLine("Находится на оси координат");
}
