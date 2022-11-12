// Напишите программу, которая принимает на вход число A
// и выдаёт произведение чисел от 1 до A

int Product(int n)
{
    int prod = 1;
    for (int i = 1; i <= n; i = i + 1)
    {
        prod = prod*i;
    }
    return prod;
} 

Console.Clear();
int number = int.Parse(Console.ReadLine()!);
Console.Write(Product(number));
