// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SumNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        
        }
    }   
    Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях: {sum}");
}

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Int16.Parse(Console.ReadLine()!);

int[] arr = GetArray(n, -10, 10);
SumNum(arr);
Console.WriteLine(String.Join(",", arr));