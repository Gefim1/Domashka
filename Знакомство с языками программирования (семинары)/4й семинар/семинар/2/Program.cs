// 
int GetCol(int value)
{
    int count = 0;
    while(value != 0)
    {
        value = value/10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int col = GetCol(N);
Console.WriteLine(col);



