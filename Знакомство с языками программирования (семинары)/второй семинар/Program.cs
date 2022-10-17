//на вход 2 числа и проверяет является ли оно квадратом другого 3,9 5,25 -4

Console.Write("Введите первое число ");

int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");

int number2 = int.Parse(Console.ReadLine()!);

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.Write("да ");

}
else
{
    Console.Write("нет ");
}
