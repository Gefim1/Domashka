// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

while (num > 1000)
{
    num /= 10;
}
int num1 = num % 10;

if (num < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine($"Третья цифра это: {num1}");
}