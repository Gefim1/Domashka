//  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//   Например, изначально массив выглядел вот так:
//  1 4 7 2       1 4 49 2
//  5 9 2 3       5 81 2 9
//  8 4 2 4       64 4 4 4

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ModArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i%2==0)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if(j%2==0)
                {
                        inArray[i, j] *= inArray[i, j];
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine("-----");
ModArray(array);
PrintArray(array);


