// Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
    Console.WriteLine($"Число {number1} наибольшее");
else
  if (number2 > number3)
    Console.WriteLine($"Число {number2} наибольшее");
else
    Console.WriteLine($"Число {number3} наибольшее");