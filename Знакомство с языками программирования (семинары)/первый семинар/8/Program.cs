﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int beginCount = 2;
while (beginCount <= number)
{
    Console.Write($"{beginCount} ");
    beginCount += 2;
}