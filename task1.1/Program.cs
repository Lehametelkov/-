﻿//Напишите программу, которая на вход принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
//a = 25, b = 5 => да
//a = 2, b = 10 => нет
//a = 9, b = -3 => да
//a = -3, b = 9 => нет

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = num1 == num2 * num2;

string resultStr = result ? "да" : "нет";

Console.WriteLine($"{num1},{num2} => {resultStr}");
